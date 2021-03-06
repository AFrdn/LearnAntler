﻿using FluentAssertions;
using LearnAntler;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace OpgAntlrTests
{
	[TestClass]
	public class ParserTests
	{
		[TestMethod]
		public void File_FileStartTagMissing_Error()
		{
			var test = new TestHelper();
			var parser = test.Setup($"<unknown>");
			var context = parser.file();

			test.ParserErrors.Should().Contain(
				x => x.Contains($"expecting '{OpgTags.FileStart}'"));
		}

		[TestMethod]
		public void File_FileEndTagMissing_Error()
		{
			var test = new TestHelper();
			var parser = test.Setup($"{OpgTags.FileStart}{OpgPrebuilt.FileContent}");
			parser.file();

			test.ParserErrors.Should().Contain(
				x => x.Contains($"missing '{OpgTags.FileEnd}'"));
		}

		[TestMethod]
		public void File_FileTagsPresent_NoError()
		{
			var test = new TestHelper();
			var text = $"{OpgTags.FileStart}{OpgPrebuilt.FileContent}{OpgTags.FileEnd}";
			var parser = test.Setup(text);
			parser.file();

			test.ParserErrors.Should().BeEmpty();
		}

		[TestMethod]
		public void File_NoContent_Error()
		{
			var test = new TestHelper();
			var parser = test.Setup($"{OpgTags.FileStart}{OpgTags.FileEnd}");
			parser.file();

			test.ParserErrors.Should().Contain(
				x => x.Contains($"mismatched input '{OpgTags.FileEnd}'"));
		}
		
		[TestMethod]
		public void Header_HeaderStartTagMissing_Error()
		{
			var test = new TestHelper();
			var parser = test.Setup($"Anything");
			parser.header();

			test.ParserErrors.Should().Contain(
				x => x.Contains($"expecting '{OpgTags.HeaderStart}'"));
		}

		[TestMethod]
		public void Header_HeaderEndTagMissing_Error()
		{
			var test = new TestHelper();
			var parser = test.Setup($"{OpgTags.HeaderStart}{OpgPrebuilt.HeaderContent}");
			parser.header();

			test.ParserErrors.Should().Contain(
				x => x.Contains($"missing '{OpgTags.HeaderEnd}'"));
		}

		[TestMethod]
		public void Header_FileVersionEntryAbsent_Error()
		{
			var test = new TestHelper();
			var headerContent = new HeaderContentBuilder().WithoutFileVersion().Build();
			var parser = test.Setup($"{OpgTags.HeaderStart}{headerContent}{OpgTags.HeaderEnd}");
			parser.header();

			test.ParserErrors.Should().Contain(
				x => x.Contains($"expecting '{OpgTags.FileVersion}'"));
		}

		[TestMethod]
		public void Header_FileVersionValueAbsent_NoError()
		{
			var test = new TestHelper();
			var text = new HeaderContentBuilder().WithFileVersion(null).Build();
			var parser = test.Setup(text);
			parser.headerContent();

			test.ParserErrors.Should().BeEmpty();
		}

		[TestMethod]
		public void Header_SeparatorEntryAbsent_Error()
		{
			var test = new TestHelper();
			var headerContent = new HeaderContentBuilder().WithoutSeparator().Build();
			var parser = test.Setup($"{OpgTags.HeaderStart}{headerContent}{OpgTags.HeaderEnd}");
			parser.header();

			test.ParserErrors.Should().Contain(
				x => x.Contains($"expecting '{OpgTags.Separator}'"));
		}

		[TestMethod]
		public void Header_SeparatorValueAbsent_NoError()
		{
			var test = new TestHelper();
			var text = new HeaderContentBuilder().WithSeparator(string.Empty).Build();
			var parser = test.Setup(text);
			parser.headerContent();

			test.ParserErrors.Should().BeEmpty();
		}
	}
}
