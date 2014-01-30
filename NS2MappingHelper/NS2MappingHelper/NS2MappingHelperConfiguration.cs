using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NS2MappingHelper
{
	public class NS2MappingHelperConfiguration : SerializableObjectBase
	{
		public string ns2Path = "";
		public bool useBuilder = true;
		public string lastOpenMod = "";
		public List<NS2Mod> mods = new List<NS2Mod>();
		public NS2MappingHelperConfiguration()
		{
		}
	}
}
