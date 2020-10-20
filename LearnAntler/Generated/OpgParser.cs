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
		NEWLINE=1, WHITESPACE=2, FileOpenTag=3, FileCloseTag=4, HeaderOpenTag=5, 
		HeaderCloseTag=6, HeaderExtOpenTag=7, HeaderExtCloseTag=8, BodyOpenTag=9, 
		BodyCloseTag=10, SectionOpenTag=11, SectionCloseTag=12, HeaderContent=13, 
		FloatingBodyTag=14, FileVersionTag=15, FileVersionContent=16, SeparatorTag=17, 
		SeparatorContent=18, NUMBER=19, TEXT=20;
	public const int
		RULE_file = 0, RULE_fileContent = 1, RULE_legacySection = 2, RULE_additionalSection = 3, 
		RULE_header = 4, RULE_headerExt = 5, RULE_body = 6, RULE_headerContent = 7, 
		RULE_fileVersion = 8, RULE_separator = 9;
	public static readonly string[] ruleNames = {
		"file", "fileContent", "legacySection", "additionalSection", "header", 
		"headerExt", "body", "headerContent", "fileVersion", "separator"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, "'<opimrtascii>'", "'</opimrtascii>'", "'<asciiheader>'", 
		"'</asciiheader>'", "'<asciiheaderext>'", "'</asciiheaderext>'", "'<body>'", 
		"'</body>'", null, "'</section>'", "'temp'", "'temp2'", "'File Version:'", 
		null, "'Separator:'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "NEWLINE", "WHITESPACE", "FileOpenTag", "FileCloseTag", "HeaderOpenTag", 
		"HeaderCloseTag", "HeaderExtOpenTag", "HeaderExtCloseTag", "BodyOpenTag", 
		"BodyCloseTag", "SectionOpenTag", "SectionCloseTag", "HeaderContent", 
		"FloatingBodyTag", "FileVersionTag", "FileVersionContent", "SeparatorTag", 
		"SeparatorContent", "NUMBER", "TEXT"
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
			State = 20; Match(FileOpenTag);
			State = 21; fileContent();
			State = 22; Match(FileCloseTag);
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
			State = 24; header();
			State = 26;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==HeaderExtOpenTag) {
				{
				State = 25; headerExt();
				}
			}

			State = 31;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==SectionOpenTag) {
				{
				{
				State = 28; additionalSection();
				}
				}
				State = 33;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 34; body();
			State = 38;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==SectionOpenTag) {
				{
				{
				State = 35; additionalSection();
				}
				}
				State = 40;
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
			State = 44;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case HeaderOpenTag:
				EnterOuterAlt(_localctx, 1);
				{
				State = 41; header();
				}
				break;
			case HeaderExtOpenTag:
				EnterOuterAlt(_localctx, 2);
				{
				State = 42; headerExt();
				}
				break;
			case BodyOpenTag:
			case FloatingBodyTag:
				EnterOuterAlt(_localctx, 3);
				{
				State = 43; body();
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
			State = 46; Match(SectionOpenTag);
			State = 47; Match(SectionCloseTag);
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
			State = 49; Match(HeaderOpenTag);
			State = 50; headerContent();
			State = 51; Match(HeaderCloseTag);
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
			State = 53; Match(HeaderExtOpenTag);
			State = 54; Match(HeaderExtCloseTag);
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
			State = 59;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==FloatingBodyTag) {
				{
				{
				State = 56; Match(FloatingBodyTag);
				}
				}
				State = 61;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 62; Match(BodyOpenTag);
			State = 63; Match(BodyCloseTag);
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
		public FileVersionContext fileVersion() {
			return GetRuleContext<FileVersionContext>(0);
		}
		public SeparatorContext separator() {
			return GetRuleContext<SeparatorContext>(0);
		}
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
			State = 65; fileVersion();
			State = 66; separator();
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

	public partial class FileVersionContext : ParserRuleContext {
		public ITerminalNode FileVersionTag() { return GetToken(OpgParser.FileVersionTag, 0); }
		public ITerminalNode NEWLINE() { return GetToken(OpgParser.NEWLINE, 0); }
		public ITerminalNode FileVersionContent() { return GetToken(OpgParser.FileVersionContent, 0); }
		public FileVersionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fileVersion; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOpgVisitor<TResult> typedVisitor = visitor as IOpgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFileVersion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FileVersionContext fileVersion() {
		FileVersionContext _localctx = new FileVersionContext(Context, State);
		EnterRule(_localctx, 16, RULE_fileVersion);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 68; Match(FileVersionTag);
			State = 70;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==FileVersionContent) {
				{
				State = 69; Match(FileVersionContent);
				}
			}

			State = 72; Match(NEWLINE);
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

	public partial class SeparatorContext : ParserRuleContext {
		public ITerminalNode SeparatorTag() { return GetToken(OpgParser.SeparatorTag, 0); }
		public ITerminalNode NEWLINE() { return GetToken(OpgParser.NEWLINE, 0); }
		public ITerminalNode SeparatorContent() { return GetToken(OpgParser.SeparatorContent, 0); }
		public SeparatorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_separator; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IOpgVisitor<TResult> typedVisitor = visitor as IOpgVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSeparator(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SeparatorContext separator() {
		SeparatorContext _localctx = new SeparatorContext(Context, State);
		EnterRule(_localctx, 18, RULE_separator);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 74; Match(SeparatorTag);
			State = 76;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==SeparatorContent) {
				{
				State = 75; Match(SeparatorContent);
				}
			}

			State = 78; Match(NEWLINE);
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
		'\x5964', '\x3', '\x16', 'S', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', 
		'\x3', '\x3', '\x5', '\x3', '\x1D', '\n', '\x3', '\x3', '\x3', '\a', '\x3', 
		' ', '\n', '\x3', '\f', '\x3', '\xE', '\x3', '#', '\v', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\a', '\x3', '\'', '\n', '\x3', '\f', '\x3', '\xE', 
		'\x3', '*', '\v', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', 
		'\x4', '/', '\n', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\b', '\a', '\b', '<', '\n', '\b', '\f', '\b', '\xE', 
		'\b', '?', '\v', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x5', '\n', 'I', 
		'\n', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x5', 
		'\v', 'O', '\n', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x2', '\x2', 
		'\f', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\xE', '\x10', '\x12', '\x14', 
		'\x2', '\x2', '\x2', 'P', '\x2', '\x16', '\x3', '\x2', '\x2', '\x2', '\x4', 
		'\x1A', '\x3', '\x2', '\x2', '\x2', '\x6', '.', '\x3', '\x2', '\x2', '\x2', 
		'\b', '\x30', '\x3', '\x2', '\x2', '\x2', '\n', '\x33', '\x3', '\x2', 
		'\x2', '\x2', '\f', '\x37', '\x3', '\x2', '\x2', '\x2', '\xE', '=', '\x3', 
		'\x2', '\x2', '\x2', '\x10', '\x43', '\x3', '\x2', '\x2', '\x2', '\x12', 
		'\x46', '\x3', '\x2', '\x2', '\x2', '\x14', 'L', '\x3', '\x2', '\x2', 
		'\x2', '\x16', '\x17', '\a', '\x5', '\x2', '\x2', '\x17', '\x18', '\x5', 
		'\x4', '\x3', '\x2', '\x18', '\x19', '\a', '\x6', '\x2', '\x2', '\x19', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x1C', '\x5', '\n', '\x6', 
		'\x2', '\x1B', '\x1D', '\x5', '\f', '\a', '\x2', '\x1C', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x1C', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'!', '\x3', '\x2', '\x2', '\x2', '\x1E', ' ', '\x5', '\b', '\x5', '\x2', 
		'\x1F', '\x1E', '\x3', '\x2', '\x2', '\x2', ' ', '#', '\x3', '\x2', '\x2', 
		'\x2', '!', '\x1F', '\x3', '\x2', '\x2', '\x2', '!', '\"', '\x3', '\x2', 
		'\x2', '\x2', '\"', '$', '\x3', '\x2', '\x2', '\x2', '#', '!', '\x3', 
		'\x2', '\x2', '\x2', '$', '(', '\x5', '\xE', '\b', '\x2', '%', '\'', '\x5', 
		'\b', '\x5', '\x2', '&', '%', '\x3', '\x2', '\x2', '\x2', '\'', '*', '\x3', 
		'\x2', '\x2', '\x2', '(', '&', '\x3', '\x2', '\x2', '\x2', '(', ')', '\x3', 
		'\x2', '\x2', '\x2', ')', '\x5', '\x3', '\x2', '\x2', '\x2', '*', '(', 
		'\x3', '\x2', '\x2', '\x2', '+', '/', '\x5', '\n', '\x6', '\x2', ',', 
		'/', '\x5', '\f', '\a', '\x2', '-', '/', '\x5', '\xE', '\b', '\x2', '.', 
		'+', '\x3', '\x2', '\x2', '\x2', '.', ',', '\x3', '\x2', '\x2', '\x2', 
		'.', '-', '\x3', '\x2', '\x2', '\x2', '/', '\a', '\x3', '\x2', '\x2', 
		'\x2', '\x30', '\x31', '\a', '\r', '\x2', '\x2', '\x31', '\x32', '\a', 
		'\xE', '\x2', '\x2', '\x32', '\t', '\x3', '\x2', '\x2', '\x2', '\x33', 
		'\x34', '\a', '\a', '\x2', '\x2', '\x34', '\x35', '\x5', '\x10', '\t', 
		'\x2', '\x35', '\x36', '\a', '\b', '\x2', '\x2', '\x36', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x37', '\x38', '\a', '\t', '\x2', '\x2', '\x38', 
		'\x39', '\a', '\n', '\x2', '\x2', '\x39', '\r', '\x3', '\x2', '\x2', '\x2', 
		':', '<', '\a', '\x10', '\x2', '\x2', ';', ':', '\x3', '\x2', '\x2', '\x2', 
		'<', '?', '\x3', '\x2', '\x2', '\x2', '=', ';', '\x3', '\x2', '\x2', '\x2', 
		'=', '>', '\x3', '\x2', '\x2', '\x2', '>', '@', '\x3', '\x2', '\x2', '\x2', 
		'?', '=', '\x3', '\x2', '\x2', '\x2', '@', '\x41', '\a', '\v', '\x2', 
		'\x2', '\x41', '\x42', '\a', '\f', '\x2', '\x2', '\x42', '\xF', '\x3', 
		'\x2', '\x2', '\x2', '\x43', '\x44', '\x5', '\x12', '\n', '\x2', '\x44', 
		'\x45', '\x5', '\x14', '\v', '\x2', '\x45', '\x11', '\x3', '\x2', '\x2', 
		'\x2', '\x46', 'H', '\a', '\x11', '\x2', '\x2', 'G', 'I', '\a', '\x12', 
		'\x2', '\x2', 'H', 'G', '\x3', '\x2', '\x2', '\x2', 'H', 'I', '\x3', '\x2', 
		'\x2', '\x2', 'I', 'J', '\x3', '\x2', '\x2', '\x2', 'J', 'K', '\a', '\x3', 
		'\x2', '\x2', 'K', '\x13', '\x3', '\x2', '\x2', '\x2', 'L', 'N', '\a', 
		'\x13', '\x2', '\x2', 'M', 'O', '\a', '\x14', '\x2', '\x2', 'N', 'M', 
		'\x3', '\x2', '\x2', '\x2', 'N', 'O', '\x3', '\x2', '\x2', '\x2', 'O', 
		'P', '\x3', '\x2', '\x2', '\x2', 'P', 'Q', '\a', '\x3', '\x2', '\x2', 
		'Q', '\x15', '\x3', '\x2', '\x2', '\x2', '\t', '\x1C', '!', '(', '.', 
		'=', 'H', 'N',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
