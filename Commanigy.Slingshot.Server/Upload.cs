#region Using directives
using System;
using System.Web;
using System.IO;
#endregion

namespace Commanigy.Slingshot.Server {
	/// <summary>
	/// 
	/// </summary>
	public class Upload : IHttpHandler {
		private string storageLocation = @"c:\temp\filer";

		public bool IsReusable { get { return true; } }

		public void ProcessRequest(HttpContext context) {
			string token;

			int tokenIndex = context.Request.RawUrl.IndexOf("/upload/");
			token = context.Request.RawUrl.Substring(tokenIndex + 8);
			if (string.IsNullOrEmpty(token)) {
				token = Guid.NewGuid().ToString("N");
				InitiateUpload(context, token);
				return;
			}

			//if (string.IsNullOrEmpty(context.Request.Headers["If-Match"])) {
			//    token = Guid.NewGuid().ToString("N");
			//    InitiateUpload(context, token);
			//    return;
			//}

			//token = context.Request.Headers["If-Match"];

			if (context.Request.ContentLength > 0 && !string.IsNullOrEmpty(context.Request.Headers["Content-Range"])) {
				UploadPart(context, token);
			}
			else {
				UploadStatus(context, token);
			}
		}

		private void UploadPart(HttpContext context, string token) {
			// expects header: Content-Range: 0-99/100
			long totalLength = Convert.ToInt64(context.Request.Headers["Content-Range"].Split('/')[1]);

			string path = Path.Combine(storageLocation, token);

			long rangeLength = 0;

			// stream buffer into existing file
			FileInfo f = new FileInfo(path);
			using (FileStream fs = f.Open(FileMode.Append, FileAccess.Write)) {
				const int size = 16384;
				byte[] bytes = new byte[size];
				int numBytes;

				while ((numBytes = context.Request.InputStream.Read(bytes, 0, size)) > 0) {
					fs.Write(bytes, 0, numBytes);
					rangeLength += numBytes;
				}
			}

			//context.Response.AddHeader("ETag", token);

			long currentLength = new FileInfo(path).Length;

			// do we have entire file?
			if (currentLength < totalLength) {
				context.Response.Status = "308 Resume Incomplete";
				context.Response.AddHeader("Range", string.Format("0-{0}", rangeLength));
			}
			else {
				context.Response.Status = "200 OK";
			}
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="context"></param>
		/// <param name="token"></param>
		private void UploadStatus(HttpContext context, string token) {
			string path = Path.Combine(storageLocation, token);
			if (File.Exists(path)) {
				long length = new FileInfo(path).Length;

				context.Response.Status = "308 Resume Incomplete";
//				context.Response.AddHeader("ETag", token);
				context.Response.AddHeader("Range", string.Format("0-{0}", length));
			}
			else {
				context.Response.Status = "404 File Not Found";
			}
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="context"></param>
		private void InitiateUpload(HttpContext context, string token) {
			context.Response.Status = "200 OK";

			context.Response.AddHeader("Range", "0-0");
			context.Response.AddHeader("Location", context.Request.Url.AbsoluteUri + token);
			//context.Response.AddHeader("ETag", token);
		}
	}
}