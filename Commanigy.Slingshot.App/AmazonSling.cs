#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Configuration;
using Amazon.S3;
using Amazon.S3.Model;
#endregion

namespace Commanigy.Slingshot.App {
	public class AmazonSling {
		public AmazonSling() {
		}

		public string Sling(string path) {
			string token = Guid.NewGuid().ToString("N");

			string zipPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
			
			ICSharpCode.SharpZipLib.Zip.FastZip fz = new ICSharpCode.SharpZipLib.Zip.FastZip();
			fz.CreateZip(zipPath, path, true, "", "");

			using (AmazonS3 client = Amazon.AWSClientFactory.CreateAmazonS3Client("accesskey", "secret")) {
				try {
					// simple object put
					PutObjectRequest request = new PutObjectRequest();
					request.WithBucketName("slingshot")
						.WithKey(token + ".zip")
						.WithCannedACL(S3CannedACL.PublicRead)
						.WithFilePath(zipPath);

					using (S3Response response = client.PutObject(request)) {
						// work with it
						Console.WriteLine(response.AmazonId2);
					}
				}
				catch (AmazonS3Exception amazonS3Exception) {
					if (amazonS3Exception.ErrorCode != null &&
						(amazonS3Exception.ErrorCode.Equals("InvalidAccessKeyId") ||
						amazonS3Exception.ErrorCode.Equals("InvalidSecurity"))) {
						Console.WriteLine("Please check the provided AWS Credentials.");
						Console.WriteLine("If you haven't signed up for Amazon S3, please visit http://aws.amazon.com/s3");
					}
					else {
						Console.WriteLine("An error occurred with the message '{0}' when writing an object", amazonS3Exception.Message);
					}
				}
			}

			if (File.Exists(zipPath)) {
				File.Delete(zipPath);
			}

			return token;
		}

		public string Slung(string token) {
			return "path";
		}
	}
}