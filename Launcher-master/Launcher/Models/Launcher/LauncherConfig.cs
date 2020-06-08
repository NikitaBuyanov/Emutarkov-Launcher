using System;
using System.Collections.Generic;

namespace Launcher
{
	public class LauncherConfig
	{
		public List<string> Servers;
		public string Email;
		public string Password;
		public string GamePath;
		public bool MinimizeToTray;

		public LauncherConfig()
		{
			Servers = new List<string>();
			Email = "";
			Password = "";
			GamePath = Environment.CurrentDirectory;
			MinimizeToTray = true;
		}
	}
}
