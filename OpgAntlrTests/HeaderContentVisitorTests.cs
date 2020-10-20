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
		public void HeaderContentVisitor_VersionProvided_GetValue()
		{
			var test = new TestHelper();
			const int expected = 13;
			var opgText = new HeaderContentBuilder().WithFileVersion(expected).Build();
			var parser = test.Setup(opgText);
			var context = parser.headerContent();
			var sut = new HeaderContentVisitor();

			var header = sut.VisitHeaderContent(context);

			header.FileVersion.Should().Be(expected);
		}

		[TestMethod]
		public void HeaderContentVisitor_VersionAbsent_GetDefault()
		{
			var test = new TestHelper();
			const int expected = OpgDefaults.FileVersion;
			var opgText = new HeaderContentBuilder().WithFileVersion(null).Build();
			var parser = test.Setup(opgText);
			var context = parser.headerContent();
			var sut = new HeaderContentVisitor();

			var header = sut.VisitHeaderContent(context);

			header.FileVersion.Should().Be(expected);
		}

		[TestMethod]
		public void HeaderContentVisitor_SeparatorProvided_GetValue()
		{
			var test = new TestHelper();
			const string expected = "@";
			var opgText = new HeaderContentBuilder().WithSeparator(expected).Build();
		}

		[TestMethod]
		public void HeaderContentVisitor_SeparatorAbsent_GetDefault()
		{

		}
	}
}
