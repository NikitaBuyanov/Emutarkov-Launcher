using System.Reflection;
using UnityEngine;
using GameConfig = GClass266;
using IniConfig = GClass412;

namespace EmuLib.Utils.Reflection
{
	internal static class ConfigUtils
	{
		public static IniConfig GetConfig()
		{
			object config = PrivateValueAccessor.GetStaticPropertyValue(typeof(GameConfig), "Config");

			if (config != null)
			{
				return config as IniConfig;
			}

			Debug.LogError("ConfigUtils GetConfig() method. config is null");
			return null;
		}

		public static void ResetConfig()
		{
			PropertyInfo config = PrivateValueAccessor.GetStaticPropertyInfo(typeof(GameConfig), "Config");

			if (config == null)
			{
				Debug.LogError("ConfigUtils GetConfig() method. config is null");
				return;
			}

			config.SetValue(null, null);
		}
	}
}