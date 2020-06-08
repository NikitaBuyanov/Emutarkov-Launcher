using ComponentAce.Compression.Libs.zlib;
using EmuLib.Utils.Reflection;
using System;
using System.IO;
using System.Net;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace EmuLib.Utils.HTTP
{
	public abstract class HttpUtils
	{
		private static string _host;

		public class Create
		{
			private Action<byte[]> _onResponse;
			private readonly string _phpSession;

			public Create(string phpSession = null)
			{
				_phpSession = phpSession;
				_host = ConfigUtils.GetConfig()?.BackendUrl;
			}

			public void Get(string url, Action<byte[]> onFinish = null)
			{
				HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(_host + url);
				webRequest.ServerCertificateValidationCallback = (sender, certificate, chain, errors) => true;
				webRequest.Method = "GET";
				webRequest.Timeout = 10000;

				if (_phpSession != null)
				{
					if (webRequest.CookieContainer == null)
					{
						webRequest.CookieContainer = new CookieContainer();
					}

					string domain = _host.Replace("https://", "").Replace("/", "");
					webRequest.CookieContainer.Add(new Cookie("PHPSESSID", _phpSession) { Domain = domain });
				}

				_onResponse = onFinish;
				webRequest.BeginGetResponse(ResponseHandler, webRequest);
			}

			public void Post(string url, string data, bool compression, Action<byte[]> onFinish = null)
			{
				byte[] sendData = compression ? SimpleZlib.CompressToBytes(data, 9) : Encoding.UTF8.GetBytes(data);

				UnityWebRequest request = new UnityWebRequest(_host + url, UnityWebRequest.kHttpVerbPUT)
				{
					uploadHandler = new UploadHandlerRaw(sendData),
					downloadHandler = new DownloadHandlerBuffer()
				};

				request.SetRequestHeader("Content-Type", "application/json");
				request.certificateHandler = new CertificateCheck();

				if (_phpSession != null)
				{
					request.SetRequestHeader("Cookie", $"PHPSESSID={_phpSession}");
					request.SetRequestHeader("SessionId", _phpSession);
				}

				request.SendWebRequest();
			}

			private void ResponseHandler(IAsyncResult asyncResult)
			{
				HttpWebRequest webRequest = (HttpWebRequest)asyncResult.AsyncState;

				try
				{
					using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.EndGetResponse(asyncResult))
					{
						byte[] buffer = new byte[1024];
						MemoryStream output = new MemoryStream();

						using (Stream input = webResponse.GetResponseStream())
						{
							if (input != null)
							{
								int size = input.Read(buffer, 0, buffer.Length);

								while (size > 0)
								{
									output.Write(buffer, 0, size);

									size = input.Read(buffer, 0, buffer.Length);
								}
							}

							buffer = output.ToArray();
						}

						output.Flush();
						output.Close();
						_onResponse?.Invoke(buffer);
					}
				}
				catch (Exception ex)
				{
					Debug.LogError(ex);
				}
			}
		}

		private sealed class CertificateCheck : CertificateHandler
		{
			protected override bool ValidateCertificate(byte[] certificateData)
			{
				return true;
			}
		}

		public abstract class ServerResponse<T>
		{
			public int Err;
			public string Errmsg;
			public T Data;
			public uint Crc;
		}
	}
}