using System;
using System.IO;

namespace Launcher
{
	public static class JsonHandler
	{
		private const string launcherConfig = "launcher.config.json";
		private const string clientConfig = "client.config.json";
		private static readonly string filepath;

		static JsonHandler()
		{
			filepath = Environment.CurrentDirectory;
		}

		public static LauncherConfig LoadLauncherConfig()
		{
			return Json.Load<LauncherConfig>(Path.Combine(filepath, launcherConfig));
		}

		public static void SaveLauncherConfig(LauncherConfig data)
		{
			Json.Save(Path.Combine(filepath, launcherConfig), data);
		}

		public static ClientConfig LoadClientConfig()
		{
			return Json.Load<ClientConfig>(Path.Combine(filepath, clientConfig));
		}

		public static void SaveClientConfig(ClientConfig data)
		{
			Json.Save(Path.Combine(filepath, clientConfig), data);
		}
	}
}
