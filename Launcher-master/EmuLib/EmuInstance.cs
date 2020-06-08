using Comfort.Common;
using EFT;
using EmuLib.Monitors;
using EmuLib.Utils.Camera;
using EmuLib.Utils.Reflection;
using UnityEngine;
using GClass_Config = GClass266;

namespace EmuLib
{
	public class EmuInstance : MonoBehaviour
	{
		private const float MonitorPeriod = 1f;
		private float _monitorNextTime;
		public static Player Player;

		public void Start()
		{
			if (!Singleton<EmuInstance>.Instantiated)
				Singleton<EmuInstance>.Create(this);

			ConfigUtils.ResetConfig();
			GClass_Config.LoadApplicationConfig();

			Debug.LogError("EmuInstance Start() method.");

		}

		private void Update()
		{
			CameraUtils.CheckSwitchCameraCombination();
		}

		public void FixedUpdate()
		{
			AbstractGame game = Singleton<AbstractGame>.Instance;
			if (game == null) return;

			// run monitoring utils
			RunMonitoringWithPeriod(game);
			CreatePlayerOwnerMonitor.CheckCreatePlayerOwnerCallBack(game);
		}

		private void RunMonitoringWithPeriod(AbstractGame game)
		{
			if (Time.time < _monitorNextTime) return;
			_monitorNextTime = Time.time + MonitorPeriod;

			// saving profile progress
			GameFinishCallBackMonitor.CheckFinishCallBack(game);
		}
	}
}