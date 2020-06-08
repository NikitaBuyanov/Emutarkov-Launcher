using EFT;
using System.Reflection;
using UnityEngine;
using static EmuLib.Utils.Reflection.PrivateValueAccessor;

namespace EmuLib.Utils.Reflection
{
	internal static class LocalGameUtils
	{
		public static FieldInfo GetFinishCallBack(AbstractGame game)
		{
			FieldInfo callBackField = GetPrivateFieldInfo(game.GetType().BaseType, "callback_0");

			if (callBackField != null)
			{
				return callBackField;
			}

			Debug.LogError("LocalGameUtils GetFinishCallBack() callBackField is null");
			return null;
		}

		public static FieldInfo GetCreatePlayerOwnerFunc(AbstractGame game)
		{
			FieldInfo createOwnerFunc = GetPrivateFieldInfo(game.GetType().BaseType, "func_1");

			if (createOwnerFunc != null)
			{
				return createOwnerFunc;
			}

			Debug.LogError("LocalGameUtils GetCreatePlayerOwnerFunc() createOwnerFunc is null");
			return null;
		}

		public static FieldInfo GetCreatePlayerFunc(AbstractGame game)
		{
			FieldInfo createOwnerFunc = GetPrivateFieldInfo(game.GetType().BaseType, "func_0");

			if (createOwnerFunc != null)
			{
				return createOwnerFunc;
			}

			Debug.LogError("LocalGameUtils GetCreatePlayerFunc() createOwnerFunc is null");
			return null;
		}
	}
}