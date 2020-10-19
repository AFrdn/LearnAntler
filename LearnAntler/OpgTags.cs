using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LearnAntler
{
	public static class OpgTags
	{
		public const string FileStart = "<opimrtascii>";
		public const string FileEnd = "</opimrtascii>";
		public const string HeaderStart = "<asciiheader>";
		public const string HeaderEnd = "</asciiheader>";
		public const string HeaderExtStart = "<asciiheaderext>";
		public const string HeaderExtEnd = "</asciiheaderext>";
		public const string BodyStart = "<body>";
		public const string BodyEnd = "</body>";
		public const string FileVersion = "File Version:";
	}

	public class HeaderContentBuilder
	{
		private int? mFileVersion = 42;

		public string Build()
		{
			var fileVersionString = mFileVersion.HasValue ? mFileVersion.ToString() : string.Empty;
			return $"{OpgTags.FileVersion} {fileVersionString}";
		}

		public HeaderContentBuilder WithFileVersion(int? fileVersion)
		{
			mFileVersion = fileVersion;
			return this;
		}
	}

	public static class OpgPrebuilt
	{
		public static readonly string HeaderContent = new HeaderContentBuilder().Build();

		public static readonly string Header =
			$"{OpgTags.HeaderStart}" +
			$"{HeaderContent}" +
			$"{OpgTags.HeaderEnd}";

		public static string HeaderExt =
			$"{OpgTags.HeaderExtStart}" +
			$"{OpgTags.HeaderExtEnd}";

		public static string Body =
			$"{OpgTags.BodyStart}" +
			$"{OpgTags.BodyEnd}";

		public static string FileContent =
			$"{Header}" +
			$"{HeaderExt}" +
			$"{Body}";

	}
}
