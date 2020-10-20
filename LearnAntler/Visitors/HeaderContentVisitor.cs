using LearnAntler.DTO;

namespace LearnAntler.Visitors
{
	public sealed class HeaderContentVisitor : OpgBaseVisitor<Header>
	{
		public override Header VisitHeaderContent(OpgParser.HeaderContentContext context)
		{
			var header = new Header
			{
				FileVersion = VisitFileVersion(context.fileVersion())
			};
			return header;
		}

		private new int VisitFileVersion(OpgParser.FileVersionContext context)
		{
			var content = context.FileVersionContent();
			var success = int.TryParse(content?.GetText(), out var result);
			return success ? result : OpgDefaults.FileVersion;
		}
	}

}
