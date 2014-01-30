using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NS2MappingHelper
{
	public static class Globals
	{
		private static string executablePath = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace('\\', '/');
		/// <summary>
		/// Gets the full path to the current executable file.
		/// </summary>
		public static string ExecutablePath
		{
			get { return executablePath; }
		}
		private static string applicationRoot = new FileInfo(executablePath).Directory.FullName.Replace('\\', '/').TrimEnd('/');
		/// <summary>
		/// Gets the full path to the root directory where the current executable is located.  Does not have trailing '/'.
		/// </summary>
		public static string ApplicationRoot
		{
			get { return applicationRoot; }
		}
		private static string applicationDirectoryBase = applicationRoot + "/";
		/// <summary>
		/// Gets the full path to the root directory where the current executable is located.  Includes trailing '/'.
		/// </summary>
		public static string ApplicationDirectoryBase
		{
			get { return applicationDirectoryBase; }
		}
		private static string configFilePath = applicationDirectoryBase + "NS2MappingHelper.cfg";
		/// <summary>
		/// Gets the full path to the config file.
		/// </summary>
		public static string ConfigFilePath
		{
			get { return configFilePath; }
		}
	}
}
