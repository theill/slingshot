#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Web;
using System.IO;
using System.Text.RegularExpressions;
#endregion

namespace Commanigy.Slingshot.App {
	public class GoogleUrl {
		private const string m_postFormat = "&user=toolbar@google.com&url={0}&auth_token={1}";

		public static string Shorten(string url) {
			string token = GenerateAuthToken(url);
			string post = String.Format(m_postFormat, HttpUtility.UrlEncode(url), token);

			HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://goo.gl/api/url");
			request.ServicePoint.Expect100Continue = false;
			request.Method = "POST";
			request.UserAgent = "toolbar";
			request.ContentLength = post.Length;
			request.ContentType = "application/x-www-form-urlencoded";
			request.Headers.Add("Cache-Control", "no-cache");

			using (Stream requestStream = request.GetRequestStream()) {
				byte[] postBuffer = Encoding.ASCII.GetBytes(post);
				requestStream.Write(postBuffer, 0, postBuffer.Length);
			}

			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) {
				using (Stream responseStream = response.GetResponseStream()) {
					using (StreamReader responseReader = new StreamReader(responseStream)) {
						string json = responseReader.ReadToEnd();
						return Regex.Match(json, @"{""short_url"":""([^""]*)""}").Groups[1].Value;
					}
				}
			}
		}

		static string GenerateAuthToken(string b) {
			long i = __e(b);

			i = i >> 2 & 1073741823;
			i = i >> 4 & 67108800 | i & 63;
			i = i >> 4 & 4193280 | i & 1023;
			i = i >> 4 & 245760 | i & 16383;

			long h = __f(b);
			long k = (i >> 2 & 15) << 4 | h & 15;
			k |= (i >> 6 & 15) << 12 | (h >> 8 & 15) << 8;
			k |= (i >> 10 & 15) << 20 | (h >> 16 & 15) << 16;
			k |= (i >> 14 & 15) << 28 | (h >> 24 & 15) << 24;

			return "7" + __d(k);
		}

		static long __c(long a, long b, long c) {
			long l = 0;
			l += (a & 4294967295);
			l += (b & 4294967295);
			l += (c & 4294967295);

			return l;
		}

		static long __c(long a, long b, long c, long d) {
			long l = 0;
			l += (a & 4294967295);
			l += (b & 4294967295);
			l += (c & 4294967295);
			l += (d & 4294967295);

			return l;
		}

		static string __d(long l) {
			string ll = l.ToString();
			string m = (l > 0 ? l : l + 4294967296).ToString();
			bool n = false;
			long o = 0;

			for (int p = m.Length - 1; p >= 0; --p) {
				long q = Int64.Parse(m[p].ToString());

				if (n) {
					q *= 2;
					o += (long)Math.Floor((double)q / 10) + q % 10;
				}
				else {
					o += q;
				}

				n = !n;
			}

			long mm = o % 10;

			o = 0;

			if (mm != 0) {
				o = 10 - mm;

				if (ll.Length % 2 == 1) {
					if (o % 2 == 1) o += 9;
					o /= 2;
				}
			}

			m = o.ToString();
			m += ll;

			return m;
		}

		static long __e(string l) {
			long m = 5381;
			for (int o = 0; o < l.Length; o++) {
				m = __c(m << 5, m, (long)l[o]);
			}
			return m;
		}

		static long __f(string l) {
			long m = 0;
			for (int o = 0; o < l.Length; o++) {
				m = __c(l[o], m << 6, m << 16, -m);
			}
			return m;
		}
	}
}
