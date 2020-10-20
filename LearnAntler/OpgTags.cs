using LearnAntler.DTO;

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
		public const string Separator = "Separator:";
	}

	public static class OpgDefaults
	{
		public const int FileVersion = 3;
		public const string Separator = "\t";
	}
}
