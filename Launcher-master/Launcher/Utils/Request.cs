using System;
using System.IO;
using System.Net;
using System.Text;
using ComponentAce.Compression.Libs.zlib;

namespace Launcher
{
	public class Request
	{
		public static string Session;
		public string RemoteEndPoint;

		public Request(string session, string remoteEndPoint)
		{
			Session = session;
			RemoteEndPoint = remoteEndPoint;
		}

		public string Send(string url, string data = null, bool compress = true)
		{
			// disable SSL encryption
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

			// set session headers
			WebRequest request = WebRequest.Create(new Uri(RemoteEndPoint + url));

			if (!string.IsNullOrEmpty(Session))
			{
				request.Headers.Add("Cookie", $"PHPSESSID={Session}");
				request.Headers.Add("SessionId", Session);
			}

			// set request type and body
			if (!string.IsNullOrEmpty(data))
			{
				byte[] bytes = (compress) ? SimpleZlib.CompressToBytes(data, zlibConst.Z_BEST_COMPRESSION) : Encoding.UTF8.GetBytes(data);

				request.Method = "POST";
				request.ContentType = "application/json";
				request.ContentLength = bytes.Length;

				using (Stream requestStream = request.GetRequestStream())
				{
					requestStream.Write(bytes, 0, bytes.Length);
				}
			}
			else
			{
				request.Method = "GET";
			}

			// get response data
			WebResponse response = request.GetResponse();

			using (Stream responseStream = response.GetResponseStream())
			{
				using (MemoryStream ms = new MemoryStream())
				{
					responseStream.CopyTo(ms);
					return SimpleZlib.Decompress(ms.ToArray(), null);
				}
			}
		}
	}
}
