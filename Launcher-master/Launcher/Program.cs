using System;
using System.Windows.Forms;

namespace Launcher
{
	public static class Program
	{
		[STAThread]
		private static void Main()
		{
			new AssemblyLoader("EscapeFromTarkov_Data/Managed/");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}
