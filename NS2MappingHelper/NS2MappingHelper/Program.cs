using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace NS2MappingHelper
{
	static class Program
	{
		public static NS2MappingHelperConfiguration cfg;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			cfg = new NS2MappingHelperConfiguration();
			cfg.Load(Globals.ConfigFilePath);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main(args));
		}
	}
}
