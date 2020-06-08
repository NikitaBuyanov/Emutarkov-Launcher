using EFT;
using UnityEngine;

namespace EmuLib.Utils.Reflection
{
	internal static class MainAppUtils
	{
		public static MainApplication GetMainApp()
		{
			ClientApplication clientApp = ClientAppUtils.GetClientApp();

			if (clientApp != null)
			{
				return clientApp as MainApplication;
			}

			Debug.LogError("MainAppUtils GetMainApp() method. clientApp is null");
			return null;
		}
	}
}