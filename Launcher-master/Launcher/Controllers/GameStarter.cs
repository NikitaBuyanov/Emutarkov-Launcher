using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Launcher
{
	public class GameStarter
	{
		public int LaunchGame(ServerInfo server, AccountInfo account)
		{
			string clientExecutable = "EscapeFromTarkov.exe";

			if (account.wipe)
			{
				RemoveRegisteryKeys();
				CleanTempFiles();
			}

			if (!File.Exists(clientExecutable))
			{
				return -1;
			}

			ClientConfig clientConfig = JsonHandler.LoadClientConfig();
			clientConfig.BackendUrl = server.backendUrl;
			JsonHandler.SaveClientConfig(clientConfig);

			ProcessStartInfo clientProcess = new ProcessStartInfo(clientExecutable)
			{
				Arguments = "-bC5vLmcuaS5u=" + GenerateToken(account) + " -token=" + account.id + " -screenmode=fullscreen -window-mode=borderless",
				UseShellExecute = false,
				WorkingDirectory = Environment.CurrentDirectory
			};

			Process.Start(clientProcess);

			return 1;
		}

		private void RemoveRegisteryKeys()
		{
			try
			{
				RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Battlestate Games\EscapeFromTarkov", true);

				foreach (string value in key.GetValueNames())
				{
					key.DeleteValue(value);
				}
			}
			catch
			{
				// very first time launching tarkov, maybe display a message that one should buy the game to support the devs?
			}
		}

		private void CleanTempFiles()
		{
			string tempDir = @"Battlestate Games\EscapeFromTarkov";
			DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Path.GetTempPath(), tempDir));

			if (!Directory.Exists(tempDir))
			{
				return;
			}

			foreach (FileInfo file in directoryInfo.GetFiles())
			{
				file.Delete();
			}

			foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
			{
				directory.Delete(true);
			}
		}

		private string GenerateToken(AccountInfo data)
		{
			LoginToken token = new LoginToken(data.email, data.password);
			string serialized = Json.Serialize(token);
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(serialized)) + "=";
		}
	}
}
