#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Configuration;
using ICSharpCode.SharpZipLib.Zip;
using Commanigy.Slingshot.App.Properties;
//using Google.GData.Client;
//using Google.GData.Client.ResumableUpload;
//using Google.Documents;
#endregion

namespace Commanigy.Slingshot.App {
	public class FtpSling {
		public FtpSling() {

		}

		public string Sling(string path) {
			string token = string.Empty;
			string fileToUpload = string.Empty;

			bool isZipped = Settings.Default.ZipPackage || Directory.Exists(path) || Properties.Settings.Default.FtpFileName.ToLower().EndsWith(".zip");

			if (isZipped) {
				token = GenerateID();
				fileToUpload = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());

				if (Directory.Exists(path)) {
					new FastZip().CreateZip(fileToUpload, path, true, "", "");
				}
				else if (File.Exists(path)) {
					ZipFile zf = ZipFile.Create(fileToUpload);
					zf.BeginUpdate();
					zf.Add(path);
					zf.CommitUpdate();
					zf.Close();
				}
			}
			else {
				token = Path.GetFileName(path);
				fileToUpload = path;
			}

			int bufferLength = 16 * 1024;
			byte[] buffer = new byte[bufferLength];

			string ftpUri = BuildFtpUri(string.Format(Properties.Settings.Default.FtpFileName, token));
			
			FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUri);
			request.Method = WebRequestMethods.Ftp.UploadFile;
			request.Credentials = new NetworkCredential(Properties.Settings.Default.FtpUserName, Properties.Settings.Default.FtpPassword);
			request.UsePassive = true;
			request.UseBinary = true;
			request.KeepAlive = false;

			using (FileStream fs = new FileInfo(fileToUpload).OpenRead()) {
				using (Stream ftpStream = request.GetRequestStream()) {
					int contentLength = fs.Read(buffer, 0, bufferLength);
					while (contentLength != 0) {
						ftpStream.Write(buffer, 0, contentLength);
						contentLength = fs.Read(buffer, 0, bufferLength);
					}
					ftpStream.Close();
				}
				fs.Close();
			}

			if (isZipped) {
				if (File.Exists(fileToUpload)) {
					File.Delete(fileToUpload);
				}
			}

			return token;
		}

		private string BuildFtpUri(string ftpFileName) {
			string ftpHost = Properties.Settings.Default.FtpHost;
			string ftpPort = Properties.Settings.Default.FtpPort;
			string ftpPath = Properties.Settings.Default.FtpPath;

			return "ftp://" + (ftpHost + ":" + ftpPort + "/" + ftpPath + "/" + ftpFileName).Replace("//", "/");
		}

		private string GenerateID() {
			long i = 1;
			foreach (byte b in Guid.NewGuid().ToByteArray()) {
				i *= ((int)b + 1);
			}
			return string.Format("{0:x}", i - DateTime.Now.Ticks);
		}
	}
}