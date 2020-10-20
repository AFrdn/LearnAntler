using LearnAntler;

namespace OpgAntlrTests
{
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