using NLog.Targets;

namespace EmuLib.Hooks
{
	[Target(nameof(EmuLibTarget))]
	public sealed class EmuLibTarget : TargetWithLayout
	{
		public EmuLibTarget()
		{
			Loader.Load();
		}
	}
}
