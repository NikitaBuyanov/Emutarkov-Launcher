using System;
using System.IO;
using System.Reflection;

namespace Launcher
{
	public class AssemblyLoader
	{
		private readonly string filepath;

		public AssemblyLoader(string filepath)
		{
			this.filepath = filepath;
			AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEvent);
		}

		private Assembly AssemblyResolveEvent(object sender, ResolveEventArgs args)
		{
			string assembly = new AssemblyName(args.Name).Name;
			string filename = Path.Combine(Environment.CurrentDirectory, filepath + assembly + ".dll");

			// resources are embedded inside assembly
			if (filename.Contains("resources"))
			{
				return null;
			}

			return Assembly.LoadFrom(filename);
		}
	}
}
