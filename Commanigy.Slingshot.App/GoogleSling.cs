#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Configuration;
using Google.GData.Client;
using Google.GData.Client.ResumableUpload;
using Google.Documents;
#endregion

namespace Commanigy.Slingshot.App {
	public class GoogleSling {
		public const string ContentLengthOverrideHeader = "X-Upload-Content-Length";
		public const string ContentOverrideHeader = "X-Upload-Content-Type";
		public const string EtagHeader = "Etag";
		public const string IfMatch = "If-Match";
		public const string IfMatchAll = "*";
		public const string IfNoneMatch = "If-None-Match";
		public const string SetCookieHeader = "Set-Cookie";

		private string zipPath;

		private static int MB = 1048576;

		private int chunkSize;

		public GoogleSling()
			: this(25) {
		}

		public GoogleSling(int chunkSize) {
			if (chunkSize < 1) {
				throw new ArgumentException("chunkSize needs to be > 0");
			}

			this.chunkSize = chunkSize;
		}

		public string Sling(string path) {
			string token = Guid.NewGuid().ToString("N");

			zipPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());

			ICSharpCode.SharpZipLib.Zip.FastZip fz = new ICSharpCode.SharpZipLib.Zip.FastZip();
			fz.CreateZip(zipPath, path, true, "", "");

			int CHUNK_SIZE = 10485760;

			ClientLoginAuthenticator cla = new ClientLoginAuthenticator("commanigy-slingshot-v1", ServiceNames.Documents, "username", "password");

			// Set up resumable uploader and notifications
			ResumableUploader ru = new ResumableUploader(CHUNK_SIZE);
			ru.AsyncOperationCompleted += new AsyncOperationCompletedEventHandler(this.OnDone);
			ru.AsyncOperationProgress += new AsyncOperationProgressEventHandler(this.OnProgress);

			// Set metadata for our upload.
			Document entry = new Document();
			entry.Title = string.Format("testupload", token);
			//entry.MediaSource = new MediaFileSource(new FileStream(zipPath, FileMode.Open), "test.zip", "application/zip");
			//entry.MediaSource = new MediaFileSource(zipPath, "application/zip");
			entry.MediaSource = new MediaFileSource(zipPath, "application/zip");

			// Add the upload uri to document entry.
			Uri createUploadUrl = new Uri("https://docs.google.com/feeds/upload/create-session/default/private/full");
			AtomLink link = new AtomLink(createUploadUrl.AbsoluteUri);
			link.Rel = ResumableUploader.CreateMediaRelation;
			entry.DocumentEntry.Links.Add(link);

			string userObject = "Just a sample text";

			ru.InsertAsync(cla, entry.DocumentEntry, userObject);
			//ru.InsertAsync(cla, createUploadUrl, new FileStream(zipPath, FileMode.Open), "application/zip", "mytest.zip", userObject);

			return token;
		}


		public Uri InitiateUpload(Uri resumableUploadUri, string contentType, long contentLength) {
			HttpWebRequest request = PrepareRequest(resumableUploadUri, contentType, contentLength);

			WebResponse response = request.GetResponse();
			return new Uri(response.Headers["Location"]);
		}


		private HttpWebRequest PrepareRequest(Uri target, string contentType, long contentLength) {
			HttpWebRequest request = WebRequest.Create(target) as HttpWebRequest;
			request.Method = HttpMethods.Post;
			request.Headers.Add(ContentOverrideHeader + ": " + contentType);
			if (contentLength != -1) {
				request.Headers.Add(HttpSling.ContentLengthOverrideHeader + ": " + contentLength);
			}

			return request;
		}


		/// <summary>
		/// Note the URI passed in here, is the session URI obtained by InitiateUpload
		/// </summary>
		/// <param name="targetUri"></param>
		/// <param name="authentication"></param>
		/// <param name="payload"></param>
		/// <param name="mediaType"></param>
		public WebResponse UploadStream(string httpMethod, Uri sessionUri, Stream payload, string mediaType, object data) {
			HttpWebResponse returnResponse = null;
			// upload one part at a time
			int index = 0;
			bool isDone = false;

			// if the passed in stream is NOT at the beginning, we assume
			// that we are resuming
			try {
				// calculate a new index, we will resume in chunk sizes
				if (payload.Position != 0) {
					index = (int)((double)payload.Position / (this.chunkSize * MB));
				}
			}
			catch (System.NotSupportedException) {
				index = 0;
			}

			do {
				HttpWebResponse response;
				try {
					response = UploadStreamPart(index, httpMethod, sessionUri, payload, mediaType, data);
					if (data != null && CheckIfOperationIsCancelled(data) == true) {
						break;
					}

					index++;
					{
						int status = (int)response.StatusCode;
						switch (status) {

							case 308:
								isDone = false;
								break;
							case 200:
							case 201:
								isDone = true;
								returnResponse = response;
								break;
							default:
								throw new ApplicationException("Unexpected return code during resumable upload");

						}

					}
				}
				finally {
					response = null;
				}
			} while (isDone == false);
			return returnResponse;
		}

		private HttpWebResponse UploadStreamPart(int partIndex, string httpMethod, Uri sessionUri, Stream payload, string mediaType, object data) {
			HttpWebRequest request = WebRequest.Create(sessionUri) as HttpWebRequest;
			request.Method = httpMethod;
			request.AllowWriteStreamBuffering = false;
			request.Timeout = 600000;

			// write the data
			request.ContentType = mediaType;
			CopyData(payload, request, partIndex, data);

			HttpWebResponse response = null;
			try {
				// an exception is called for everything else than 200 (and we might get 308 for a resume upload)
				response = request.GetResponse() as HttpWebResponse;
			}
			catch (WebException wx) {
				if (wx.Status == WebExceptionStatus.ProtocolError) {
					response = wx.Response as HttpWebResponse;
				}
				else {
					throw;
				}
			}

			return response;
		}

		private long GetStreamLength(Stream s) {
			long result;

			try {
				result = s.Length;
			}
			catch (NotSupportedException) {
				result = -1;
			}

			return result;
		}


		//////////////////////////////////////////////////////////////////////
		/// <summary>takes our copy of the stream, and puts it into the request stream
		/// returns FALSE when we are done by reaching the end of the input stream</summary> 
		//////////////////////////////////////////////////////////////////////
		protected bool CopyData(Stream input, HttpWebRequest request, int partIndex, object data) {
			long chunkCounter = 0;
			long chunkStart = partIndex * this.chunkSize * MB;
			long dataLength;

			dataLength = GetStreamLength(input);

			// calculate the range
			// move the source stream to the correct position
			input.Seek(chunkStart, SeekOrigin.Begin);

			const int size = 16384;
			byte[] bytes = new byte[size];
			int numBytes;

			// to reduce memory consumption, we read in 16K chunks
			// first calculate the contentlength. We can not modify
			// headers AFTER we started writing to the stream
			// Note: we want to read in chunksize*MB, but it might be less
			// if we have smaller files or are at the last chunk
			while ((numBytes = input.Read(bytes, 0, size)) > 0) {
				chunkCounter += numBytes;

				if (chunkCounter >= (this.chunkSize * MB)) {
					break;
				}
			}
			request.ContentLength = chunkCounter;

			// modify the content-range header
			string contentRange = String.Format("bytes {0}-{1}/{2}", chunkStart, chunkStart + chunkCounter - 1, dataLength > 0 ? dataLength.ToString() : "*");
			request.Headers.Add(HttpRequestHeader.ContentRange, contentRange);

			// stream it into the real request stream
			using (Stream req = request.GetRequestStream()) {
				// move the source stream to the correct position
				input.Seek(chunkStart, SeekOrigin.Begin);
				chunkCounter = 0;

				// to reduce memory consumption, we read in 16K chunks

				while ((numBytes = input.Read(bytes, 0, size)) > 0) {
					req.Write(bytes, 0, numBytes);
					chunkCounter += numBytes;

					// while we are writing along, send notifications out
					if (data != null) {
						if (CheckIfOperationIsCancelled(data) == true) {
							break;
						}
						//else if (data.Delegate != null && data.DataHandler != null) {
						// TODO: future
						//AsyncOperationProgressEventArgs args;
						//int current = (int)((double)(chunkStart + chunkCounter - 1) / dataLength * 100);

						//args = new AsyncOperationProgressEventArgs(dataLength, (chunkStart + chunkCounter - 1),
						//    (int)current,
						//    request.RequestUri,
						//    request.Method,
						//    data.UserData);
						//data.DataHandler.SendProgressData(data, args);
						//}
					}

					if (chunkCounter >= request.ContentLength) {
						break;
					}
				}
			}

			return chunkCounter < (this.chunkSize * MB);
		}

		private bool CheckIfOperationIsCancelled(object o) {
			// TODO: implement
			return false;
		}

		private void OnDone(object sender, AsyncOperationCompletedEventArgs e) {
			//MessageBox.Show("done: " + e.ToString());
			Console.WriteLine("Done: " + e.Error);

			if (File.Exists(zipPath)) {
				File.Delete(zipPath);
			}
		}

		private void OnProgress(object sender, AsyncOperationProgressEventArgs e) {
			//MessageBox.Show("progress: " + e.ToString());
			Console.WriteLine("Nailed " + e.ProgressPercentage + "%");
		}
	}
}