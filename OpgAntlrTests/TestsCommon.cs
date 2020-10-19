using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;


namespace OpgAntlrTests
{
	internal class TestLexerErrorListener : IAntlrErrorListener<int>
	{
		public List<string> Errors { get; } = new List<string>();

		public void SyntaxError(TextWriter output, IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine,
			string msg, RecognitionException e)
		{
			Errors.Add(msg);
		}
	}

	internal class TestParserErrorListener : IAntlrErrorListener<IToken>
	{
		public List<string> Errors { get; } = new List<string>();

		public void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine,
			string msg, RecognitionException e)
		{
			Errors.Add(msg);
		}
	}

	public class TestHelper
	{
		private TestLexerErrorListener mLexerListener;
		private TestParserErrorListener mParserListener;

		public List<string> LexerErrors => mLexerListener.Errors;
		public List<string> ParserErrors => mParserListener.Errors;

		public OpgParser Setup(string text)
		{
			var inputStream = new AntlrInputStream(text);
			var opgLexer = new OpgLexer(inputStream);
			opgLexer.RemoveErrorListeners();
			mLexerListener = new TestLexerErrorListener();
			opgLexer.AddErrorListener(mLexerListener);
			var commonTokenStream = new CommonTokenStream(opgLexer);
			var opgParser = new OpgParser(commonTokenStream);
			opgParser.RemoveErrorListeners();
			mParserListener = new TestParserErrorListener();
			opgParser.AddErrorListener(mParserListener);
			return opgParser;
		}
	}
}
