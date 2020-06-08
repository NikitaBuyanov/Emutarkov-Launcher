namespace Launcher
{
	public class ClientConfig
	{
		public string BackendUrl;
		public string Version;
		public string BuildVersion;
		public bool LocalGame;
		public int AmmoPoolSize;
		public int WeaponsPoolSize;
		public int MagsPoolSize;
		public int ItemsPoolSize;
		public int PlayersPoolSize;
		public int ObservedFix;
		public int TargetFrameRate;
		public int BotsCount;
		public bool ResetSettings;
		public bool SaveResults;
		public int FixedFrameRate;

		public ClientConfig()
		{
			BackendUrl = "https://127.0.0.1";
			Version = "live";
			BuildVersion = "000";
			LocalGame = false;
			AmmoPoolSize = -1;
			WeaponsPoolSize = -1;
			MagsPoolSize = -1;
			ItemsPoolSize = -1;
			PlayersPoolSize = 30;
			ObservedFix = 1;
			TargetFrameRate = -1;
			BotsCount = -1;
			ResetSettings = false;
			SaveResults = true;
			FixedFrameRate = 60;
		}
	}
}
