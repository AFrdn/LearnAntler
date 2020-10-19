using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAntler.Visitors
{
	public sealed class HeaderContentVisitor : OpgBaseVisitor<int>
	{
		public override int VisitHeaderContent(OpgParser.HeaderContentContext context)
		{
			var version = VisitFileVersion(context.fileVersion());
			return version;
		}

		public override int VisitFileVersion(OpgParser.FileVersionContext context)
		{
			var content = context.FileVersionContent();
			var success = int.TryParse(content?.GetText(), out var result);
			return success ? result : 0;
		}
	}

	
}
