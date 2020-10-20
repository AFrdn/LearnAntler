using System.Text;
using LearnAntler;

namespace OpgAntlrTests
{
	public class HeaderContentBuilder
	{
		private string mNewLine = "\r\n";
		private bool mIncludeFileVersion = true;
		private int? mFileVersion = 42;
		private bool mIncludeSeparator = true;
		private string mSeparator = ";";

		public string Build()
		{
			var sb = new StringBuilder();
			var fileVersionString = mFileVersion.HasValue ? mFileVersion.ToString() : string.Empty;
			if (mIncludeFileVersion)
			{
				sb.AppendLine($"{OpgTags.FileVersion} {fileVersionString}");
			}

			if (mIncludeSeparator)
			{
				sb.AppendLine($"{OpgTags.Separator} {mSeparator}");
			}

			return sb.ToString();
		}

		public HeaderContentBuilder WithFileVersion(int? fileVersion)
		{
			mFileVersion = fileVersion;
			return this;
		}

		public HeaderContentBuilder WithoutFileVersion()
		{
			mIncludeFileVersion = false;
			return this;
		}

		public HeaderContentBuilder WithSeparator(string separator)
		{
			mSeparator = separator;
			return this;
		}

		public HeaderContentBuilder WithoutSeparator()
		{
			mIncludeSeparator = false;
			return this;
		}
	}
}