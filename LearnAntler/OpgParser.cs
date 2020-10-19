//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Opg.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class OpgParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		FileOpenTag=1, FileCloseTag=2, HeaderOpenTag=3, HeaderCloseTag=4, HeaderExtOpenTag=5, 
		HeaderExtCloseTag=6, BodyOpenTag=7, BodyCloseTag=8, SectionOpenTag=9, 
		SectionCloseTag=10, HeaderContent=11, FloatingBodyTag=12;
	public const int
		RULE_file = 0, RULE_fileContent = 1, RULE_legacySection = 2, RULE_additionalSection = 3, 
		RULE_header = 4, RULE_headerExt = 5, RULE_body = 6, RULE_headerContent = 7;
	public static readonly string[] ruleNames = {
		"file", "fileContent", "legacySection", "additionalSection", "header", 
		"headerExt", "body", "headerContent"
	};

	private static readonly string[] _LiteralNames = {
		null, "'<opimrtascii>'", "'</opimrtascii>'", "'<asciiheader>'", "'</asciiheader>'", 
		"'<asciiheaderext>'", "'</asciiheaderext>'", "'<body>'", "'</body>'", 
		null, "'</section>'", "'header content goes here'", "'temp2'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "FileOpenTag", "FileCloseTag", "HeaderOpenTag", "HeaderCloseTag", 
		"HeaderExtOpenTag", "HeaderExtCloseTag", "BodyOpenTag", "BodyCloseTag", 
		"SectionOpenTag", "SectionCloseTag", "HeaderContent", "FloatingBodyTag"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Opg.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static OpgParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public OpgParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public OpgParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class FileContext : ParserRuleContext {
		public ITerminalNode FileOpenTag() { return GetToken(OpgParser.FileOpenTag, 0); }
		public FileContentContext fileContent() {
			return GetRuleContext<FileContentContext>(0);
		}
		public ITerminalNode FileCloseTag() { return GetToken(OpgParser.FileCloseTag, 0); }
		public FileContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_file; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOpgVisitor<TResult> typedVisitor = visitor as IOpgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFile(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FileContext file() {
		FileContext _localctx = new FileContext(Context, State);
		EnterRule(_localctx, 0, RULE_file);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 16; Match(FileOpenTag);
			State = 17; fileContent();
			State = 18; Match(FileCloseTag);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FileContentContext : ParserRuleContext {
		public HeaderContext header() {
			return GetRuleContext<HeaderContext>(0);
		}
		public BodyContext body() {
			return GetRuleContext<BodyContext>(0);
		}
		public HeaderExtContext headerExt() {
			return GetRuleContext<HeaderExtContext>(0);
		}
		public AdditionalSectionContext[] additionalSection() {
			return GetRuleContexts<AdditionalSectionContext>();
		}
		public AdditionalSectionContext additionalSection(int i) {
			return GetRuleContext<AdditionalSectionContext>(i);
		}
		public FileContentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fileContent; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOpgVisitor<TResult> typedVisitor = visitor as IOpgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFileContent(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FileContentContext fileContent() {
		FileContentContext _localctx = new FileContentContext(Context, State);
		EnterRule(_localctx, 2, RULE_fileContent);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 20; header();
			State = 22;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==HeaderExtOpenTag) {
				{
				State = 21; headerExt();
				}
			}

			State = 27;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==SectionOpenTag) {
				{
				{
				State = 24; additionalSection();
				}
				}
				State = 29;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 30; body();
			State = 34;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==SectionOpenTag) {
				{
				{
				State = 31; additionalSection();
				}
				}
				State = 36;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LegacySectionContext : ParserRuleContext {
		public HeaderContext header() {
			return GetRuleContext<HeaderContext>(0);
		}
		public HeaderExtContext headerExt() {
			return GetRuleContext<HeaderExtContext>(0);
		}
		public BodyContext body() {
			return GetRuleContext<BodyContext>(0);
		}
		public LegacySectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_legacySection; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOpgVisitor<TResult> typedVisitor = visitor as IOpgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLegacySection(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LegacySectionContext legacySection() {
		LegacySectionContext _localctx = new LegacySectionContext(Context, State);
		EnterRule(_localctx, 4, RULE_legacySection);
		try {
			State = 40;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case HeaderOpenTag:
				EnterOuterAlt(_localctx, 1);
				{
				State = 37; header();
				}
				break;
			case HeaderExtOpenTag:
				EnterOuterAlt(_localctx, 2);
				{
				State = 38; headerExt();
				}
				break;
			case BodyOpenTag:
			case FloatingBodyTag:
				EnterOuterAlt(_localctx, 3);
				{
				State = 39; body();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AdditionalSectionContext : ParserRuleContext {
		public ITerminalNode SectionOpenTag() { return GetToken(OpgParser.SectionOpenTag, 0); }
		public ITerminalNode SectionCloseTag() { return GetToken(OpgParser.SectionCloseTag, 0); }
		public AdditionalSectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_additionalSection; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOpgVisitor<TResult> typedVisitor = visitor as IOpgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAdditionalSection(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AdditionalSectionContext additionalSection() {
		AdditionalSectionContext _localctx = new AdditionalSectionContext(Context, State);
		EnterRule(_localctx, 6, RULE_additionalSection);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 42; Match(SectionOpenTag);
			State = 43; Match(SectionCloseTag);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class HeaderContext : ParserRuleContext {
		public ITerminalNode HeaderOpenTag() { return GetToken(OpgParser.HeaderOpenTag, 0); }
		public HeaderContentContext headerContent() {
			return GetRuleContext<HeaderContentContext>(0);
		}
		public ITerminalNode HeaderCloseTag() { return GetToken(OpgParser.HeaderCloseTag, 0); }
		public HeaderContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_header; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOpgVisitor<TResult> typedVisitor = visitor as IOpgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitHeader(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public HeaderContext header() {
		HeaderContext _localctx = new HeaderContext(Context, State);
		EnterRule(_localctx, 8, RULE_header);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 45; Match(HeaderOpenTag);
			State = 46; headerContent();
			State = 47; Match(HeaderCloseTag);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class HeaderExtContext : ParserRuleContext {
		public ITerminalNode HeaderExtOpenTag() { return GetToken(OpgParser.HeaderExtOpenTag, 0); }
		public ITerminalNode HeaderExtCloseTag() { return GetToken(OpgParser.HeaderExtCloseTag, 0); }
		public HeaderExtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_headerExt; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOpgVisitor<TResult> typedVisitor = visitor as IOpgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitHeaderExt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public HeaderExtContext headerExt() {
		HeaderExtContext _localctx = new HeaderExtContext(Context, State);
		EnterRule(_localctx, 10, RULE_headerExt);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 49; Match(HeaderExtOpenTag);
			State = 50; Match(HeaderExtCloseTag);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BodyContext : ParserRuleContext {
		public ITerminalNode BodyOpenTag() { return GetToken(OpgParser.BodyOpenTag, 0); }
		public ITerminalNode BodyCloseTag() { return GetToken(OpgParser.BodyCloseTag, 0); }
		public ITerminalNode[] FloatingBodyTag() { return GetTokens(OpgParser.FloatingBodyTag); }
		public ITerminalNode FloatingBodyTag(int i) {
			return GetToken(OpgParser.FloatingBodyTag, i);
		}
		public BodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_body; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOpgVisitor<TResult> typedVisitor = visitor as IOpgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBody(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public BodyContext body() {
		BodyContext _localctx = new BodyContext(Context, State);
		EnterRule(_localctx, 12, RULE_body);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 55;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==FloatingBodyTag) {
				{
				{
				State = 52; Match(FloatingBodyTag);
				}
				}
				State = 57;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 58; Match(BodyOpenTag);
			State = 59; Match(BodyCloseTag);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class HeaderContentContext : ParserRuleContext {
		public ITerminalNode HeaderContent() { return GetToken(OpgParser.HeaderContent, 0); }
		public HeaderContentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_headerContent; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOpgVisitor<TResult> typedVisitor = visitor as IOpgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitHeaderContent(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public HeaderContentContext headerContent() {
		HeaderContentContext _localctx = new HeaderContentContext(Context, State);
		EnterRule(_localctx, 14, RULE_headerContent);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 61; Match(HeaderContent);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\xE', '\x42', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\x5', '\x3', '\x19', '\n', '\x3', 
		'\x3', '\x3', '\a', '\x3', '\x1C', '\n', '\x3', '\f', '\x3', '\xE', '\x3', 
		'\x1F', '\v', '\x3', '\x3', '\x3', '\x3', '\x3', '\a', '\x3', '#', '\n', 
		'\x3', '\f', '\x3', '\xE', '\x3', '&', '\v', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x5', '\x4', '+', '\n', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\a', '\b', 
		'\x38', '\n', '\b', '\f', '\b', '\xE', '\b', ';', '\v', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x2', 
		'\x2', '\n', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\xE', '\x10', '\x2', 
		'\x2', '\x2', '?', '\x2', '\x12', '\x3', '\x2', '\x2', '\x2', '\x4', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\x6', '*', '\x3', '\x2', '\x2', '\x2', '\b', 
		',', '\x3', '\x2', '\x2', '\x2', '\n', '/', '\x3', '\x2', '\x2', '\x2', 
		'\f', '\x33', '\x3', '\x2', '\x2', '\x2', '\xE', '\x39', '\x3', '\x2', 
		'\x2', '\x2', '\x10', '?', '\x3', '\x2', '\x2', '\x2', '\x12', '\x13', 
		'\a', '\x3', '\x2', '\x2', '\x13', '\x14', '\x5', '\x4', '\x3', '\x2', 
		'\x14', '\x15', '\a', '\x4', '\x2', '\x2', '\x15', '\x3', '\x3', '\x2', 
		'\x2', '\x2', '\x16', '\x18', '\x5', '\n', '\x6', '\x2', '\x17', '\x19', 
		'\x5', '\f', '\a', '\x2', '\x18', '\x17', '\x3', '\x2', '\x2', '\x2', 
		'\x18', '\x19', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x1A', '\x1C', '\x5', '\b', '\x5', '\x2', '\x1B', '\x1A', 
		'\x3', '\x2', '\x2', '\x2', '\x1C', '\x1F', '\x3', '\x2', '\x2', '\x2', 
		'\x1D', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1E', '\x3', '\x2', 
		'\x2', '\x2', '\x1E', ' ', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x1D', 
		'\x3', '\x2', '\x2', '\x2', ' ', '$', '\x5', '\xE', '\b', '\x2', '!', 
		'#', '\x5', '\b', '\x5', '\x2', '\"', '!', '\x3', '\x2', '\x2', '\x2', 
		'#', '&', '\x3', '\x2', '\x2', '\x2', '$', '\"', '\x3', '\x2', '\x2', 
		'\x2', '$', '%', '\x3', '\x2', '\x2', '\x2', '%', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '&', '$', '\x3', '\x2', '\x2', '\x2', '\'', '+', '\x5', 
		'\n', '\x6', '\x2', '(', '+', '\x5', '\f', '\a', '\x2', ')', '+', '\x5', 
		'\xE', '\b', '\x2', '*', '\'', '\x3', '\x2', '\x2', '\x2', '*', '(', '\x3', 
		'\x2', '\x2', '\x2', '*', ')', '\x3', '\x2', '\x2', '\x2', '+', '\a', 
		'\x3', '\x2', '\x2', '\x2', ',', '-', '\a', '\v', '\x2', '\x2', '-', '.', 
		'\a', '\f', '\x2', '\x2', '.', '\t', '\x3', '\x2', '\x2', '\x2', '/', 
		'\x30', '\a', '\x5', '\x2', '\x2', '\x30', '\x31', '\x5', '\x10', '\t', 
		'\x2', '\x31', '\x32', '\a', '\x6', '\x2', '\x2', '\x32', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x33', '\x34', '\a', '\a', '\x2', '\x2', '\x34', 
		'\x35', '\a', '\b', '\x2', '\x2', '\x35', '\r', '\x3', '\x2', '\x2', '\x2', 
		'\x36', '\x38', '\a', '\xE', '\x2', '\x2', '\x37', '\x36', '\x3', '\x2', 
		'\x2', '\x2', '\x38', ';', '\x3', '\x2', '\x2', '\x2', '\x39', '\x37', 
		'\x3', '\x2', '\x2', '\x2', '\x39', ':', '\x3', '\x2', '\x2', '\x2', ':', 
		'<', '\x3', '\x2', '\x2', '\x2', ';', '\x39', '\x3', '\x2', '\x2', '\x2', 
		'<', '=', '\a', '\t', '\x2', '\x2', '=', '>', '\a', '\n', '\x2', '\x2', 
		'>', '\xF', '\x3', '\x2', '\x2', '\x2', '?', '@', '\a', '\r', '\x2', '\x2', 
		'@', '\x11', '\x3', '\x2', '\x2', '\x2', '\a', '\x18', '\x1D', '$', '*', 
		'\x39',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
