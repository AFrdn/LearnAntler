using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAntler.DTO
{
	public class Header
	{
		public int FileVersion { get; set; } = OpgDefaults.FileVersion;
		public string Separator { get; set; } = OpgDefaults.Separator;
	}
}
