namespace Launcher
{
	public static class RequestHandler
	{
		private static Request request;

		static RequestHandler()
		{
			request = new Request(null, "https://127.0.0.1");
		}

		public static string GetBackendUrl()
		{
			return request.RemoteEndPoint;
		}

		public static void SetSession(string session)
		{
			Request.Session = session;
		}

		public static void ChangeBackendUrl(string backendUrl)
		{
			request.RemoteEndPoint = backendUrl;
		}

		public static string RequestConnect()
		{
			return request.Send("/launcher/server/connect");
		}

		public static string RequestLogin(LoginRequestData data)
		{
			return request.Send("/launcher/profile/login", Json.Serialize(data));
		}

		public static string RequestRegister(RegisterRequestData data)
		{
			return request.Send("/launcher/profile/register", Json.Serialize(data));
		}

		public static string RequestRemove(LoginRequestData data)
		{
			return request.Send("/launcher/profile/remove", Json.Serialize(data));
		}

		public static string RequestAccount(LoginRequestData data)
		{
			return request.Send("/launcher/profile/get", Json.Serialize(data));
		}

		public static string RequestChangeEmail(ChangeRequestData data)
		{
			return request.Send("/launcher/profile/change/email", Json.Serialize(data));
		}

		public static string RequestChangePassword(ChangeRequestData data)
		{
			return request.Send("/launcher/profile/change/password", Json.Serialize(data));
		}

		public static string RequestWipe(RegisterRequestData data)
		{
			return request.Send("/launcher/profile/change/wipe", Json.Serialize(data));
		}
	}
}
