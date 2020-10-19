using FluentAssertions;
using LearnAntler;
using LearnAntler.Visitors;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace OpgAntlrTests
{
	[TestClass]
	public class HeaderContentVisitorTests
	{
		[TestMethod]
		public void HeaderContentVisitor_VersionProvided_RecoverVersion()
		{
			var test = new TestHelper();
			var expected = 13;
			var opgText = new HeaderContentBuilder().WithFileVersion(expected).Build();
			var parser = test.Setup(opgText);
			var context = parser.headerContent();
			var sut = new HeaderContentVisitor();

			var fileVersion = sut.VisitHeaderContent(context);

			fileVersion.Should().Be(expected);
		}

		[TestMethod]
		public void HeaderContentVisitor_VersionNotProvided_GetZero()
		{
			var test = new TestHelper();
			var expected = 0;
			var opgText = new HeaderContentBuilder().WithFileVersion(null).Build();
			var parser = test.Setup(opgText);
			var context = parser.headerContent();
			var sut = new HeaderContentVisitor();

			var fileVersion = sut.VisitHeaderContent(context);

			fileVersion.Should().Be(expected);
		}
	}
}
