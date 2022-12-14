//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ffa4.g4 by ANTLR 4.10.1

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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public partial class ffa4Lexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, LineIdentifierSsr=3, LineIdentifierOsi=4, SeparatorSlant=5, 
		SeparatorHyphen=6, A=7, N=8, G=9, SeparatorCrlf=10;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "LineIdentifierSsr", "LineIdentifierOsi", "SeparatorSlant", 
		"SeparatorHyphen", "A", "N", "G", "SeparatorCrlf", "DIGIT", "CAPITAL_LETTER", 
		"SMALL_LETTER", "SLANT", "HYPHEN", "SPACE", "EXCLAMATION_MARK", "DOUBLE_QUOTE", 
		"NUMBER_SIGN", "DOLLAR_SIGN", "PERCENT", "AMPERSAND", "SINGLE_QUOTE", 
		"LEFT_OPENING_PARENTHESIS", "RIGHT_CLOSING_PARENTHESIS", "ASTERISK", "PLUS", 
		"COMMA", "DOT", "COLON", "SEMICOLON", "LESS_THAN", "EQUAL_SIGN", "GREATER_THAN", 
		"QUESTION_MARK", "AT_SYMBOL", "LEFT_OPENING_BRACKET", "BACK_SLASH", "RIGHT_CLOSING_BRACKET", 
		"CARET_CIRCUMFLEX", "UNDERSCORE", "GRAVE_ACCENT", "LEFT_OPENING_BRACE", 
		"VERTICAL_BAR", "RIGHT_CLOSING_BRACE", "TILDE"
	};


	public ffa4Lexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ffa4Lexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'.'", "','", "'SSR/'", "'OSI/'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "LineIdentifierSsr", "LineIdentifierOsi", "SeparatorSlant", 
		"SeparatorHyphen", "A", "N", "G", "SeparatorCrlf"
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

	public override string GrammarFileName { get { return "ffa4.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static ffa4Lexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,10,227,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,1,0,1,0,1,1,1,1,1,2,1,2,1,2,1,2,1,2,
		1,3,1,3,1,3,1,3,1,3,1,4,1,4,1,5,1,5,1,6,1,6,1,7,1,7,1,8,1,8,1,8,1,8,1,
		8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,
		1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,1,8,3,8,147,8,8,1,9,3,9,150,8,9,1,9,1,
		9,3,9,154,8,9,1,10,1,10,1,11,1,11,1,12,1,12,1,13,1,13,1,14,1,14,1,15,1,
		15,1,16,1,16,1,17,1,17,1,18,1,18,1,19,1,19,1,20,1,20,1,21,1,21,1,22,1,
		22,1,23,1,23,1,24,1,24,1,25,1,25,1,26,1,26,1,27,1,27,1,28,1,28,1,29,1,
		29,1,30,1,30,1,31,1,31,1,32,1,32,1,33,1,33,1,34,1,34,1,35,1,35,1,36,1,
		36,1,37,1,37,1,38,1,38,1,39,1,39,1,40,1,40,1,41,1,41,1,42,1,42,1,43,1,
		43,1,44,1,44,1,45,1,45,0,0,46,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,
		19,10,21,0,23,0,25,0,27,0,29,0,31,0,33,0,35,0,37,0,39,0,41,0,43,0,45,0,
		47,0,49,0,51,0,53,0,55,0,57,0,59,0,61,0,63,0,65,0,67,0,69,0,71,0,73,0,
		75,0,77,0,79,0,81,0,83,0,85,0,87,0,89,0,91,0,1,0,3,1,0,48,57,1,0,65,90,
		1,0,97,122,222,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,
		0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,1,
		93,1,0,0,0,3,95,1,0,0,0,5,97,1,0,0,0,7,102,1,0,0,0,9,107,1,0,0,0,11,109,
		1,0,0,0,13,111,1,0,0,0,15,113,1,0,0,0,17,146,1,0,0,0,19,153,1,0,0,0,21,
		155,1,0,0,0,23,157,1,0,0,0,25,159,1,0,0,0,27,161,1,0,0,0,29,163,1,0,0,
		0,31,165,1,0,0,0,33,167,1,0,0,0,35,169,1,0,0,0,37,171,1,0,0,0,39,173,1,
		0,0,0,41,175,1,0,0,0,43,177,1,0,0,0,45,179,1,0,0,0,47,181,1,0,0,0,49,183,
		1,0,0,0,51,185,1,0,0,0,53,187,1,0,0,0,55,189,1,0,0,0,57,191,1,0,0,0,59,
		193,1,0,0,0,61,195,1,0,0,0,63,197,1,0,0,0,65,199,1,0,0,0,67,201,1,0,0,
		0,69,203,1,0,0,0,71,205,1,0,0,0,73,207,1,0,0,0,75,209,1,0,0,0,77,211,1,
		0,0,0,79,213,1,0,0,0,81,215,1,0,0,0,83,217,1,0,0,0,85,219,1,0,0,0,87,221,
		1,0,0,0,89,223,1,0,0,0,91,225,1,0,0,0,93,94,5,46,0,0,94,2,1,0,0,0,95,96,
		5,44,0,0,96,4,1,0,0,0,97,98,5,83,0,0,98,99,5,83,0,0,99,100,5,82,0,0,100,
		101,5,47,0,0,101,6,1,0,0,0,102,103,5,79,0,0,103,104,5,83,0,0,104,105,5,
		73,0,0,105,106,5,47,0,0,106,8,1,0,0,0,107,108,3,27,13,0,108,10,1,0,0,0,
		109,110,3,29,14,0,110,12,1,0,0,0,111,112,3,23,11,0,112,14,1,0,0,0,113,
		114,3,21,10,0,114,16,1,0,0,0,115,147,3,31,15,0,116,147,3,33,16,0,117,147,
		3,35,17,0,118,147,3,37,18,0,119,147,3,39,19,0,120,147,3,41,20,0,121,147,
		3,43,21,0,122,147,3,45,22,0,123,147,3,47,23,0,124,147,3,49,24,0,125,147,
		3,51,25,0,126,147,3,53,26,0,127,147,3,55,27,0,128,147,3,57,28,0,129,147,
		3,59,29,0,130,147,3,61,30,0,131,147,3,63,31,0,132,147,3,65,32,0,133,147,
		3,67,33,0,134,147,3,69,34,0,135,147,3,71,35,0,136,147,3,73,36,0,137,147,
		3,75,37,0,138,147,3,77,38,0,139,147,3,79,39,0,140,147,3,81,40,0,141,147,
		3,83,41,0,142,147,3,85,42,0,143,147,3,87,43,0,144,147,3,89,44,0,145,147,
		3,91,45,0,146,115,1,0,0,0,146,116,1,0,0,0,146,117,1,0,0,0,146,118,1,0,
		0,0,146,119,1,0,0,0,146,120,1,0,0,0,146,121,1,0,0,0,146,122,1,0,0,0,146,
		123,1,0,0,0,146,124,1,0,0,0,146,125,1,0,0,0,146,126,1,0,0,0,146,127,1,
		0,0,0,146,128,1,0,0,0,146,129,1,0,0,0,146,130,1,0,0,0,146,131,1,0,0,0,
		146,132,1,0,0,0,146,133,1,0,0,0,146,134,1,0,0,0,146,135,1,0,0,0,146,136,
		1,0,0,0,146,137,1,0,0,0,146,138,1,0,0,0,146,139,1,0,0,0,146,140,1,0,0,
		0,146,141,1,0,0,0,146,142,1,0,0,0,146,143,1,0,0,0,146,144,1,0,0,0,146,
		145,1,0,0,0,147,18,1,0,0,0,148,150,5,13,0,0,149,148,1,0,0,0,149,150,1,
		0,0,0,150,151,1,0,0,0,151,154,5,10,0,0,152,154,5,13,0,0,153,149,1,0,0,
		0,153,152,1,0,0,0,154,20,1,0,0,0,155,156,7,0,0,0,156,22,1,0,0,0,157,158,
		7,1,0,0,158,24,1,0,0,0,159,160,7,2,0,0,160,26,1,0,0,0,161,162,5,47,0,0,
		162,28,1,0,0,0,163,164,5,45,0,0,164,30,1,0,0,0,165,166,5,32,0,0,166,32,
		1,0,0,0,167,168,5,33,0,0,168,34,1,0,0,0,169,170,5,34,0,0,170,36,1,0,0,
		0,171,172,5,35,0,0,172,38,1,0,0,0,173,174,5,36,0,0,174,40,1,0,0,0,175,
		176,5,37,0,0,176,42,1,0,0,0,177,178,5,38,0,0,178,44,1,0,0,0,179,180,5,
		39,0,0,180,46,1,0,0,0,181,182,5,40,0,0,182,48,1,0,0,0,183,184,5,41,0,0,
		184,50,1,0,0,0,185,186,5,42,0,0,186,52,1,0,0,0,187,188,5,43,0,0,188,54,
		1,0,0,0,189,190,5,44,0,0,190,56,1,0,0,0,191,192,5,46,0,0,192,58,1,0,0,
		0,193,194,5,58,0,0,194,60,1,0,0,0,195,196,5,59,0,0,196,62,1,0,0,0,197,
		198,5,60,0,0,198,64,1,0,0,0,199,200,5,61,0,0,200,66,1,0,0,0,201,202,5,
		62,0,0,202,68,1,0,0,0,203,204,5,63,0,0,204,70,1,0,0,0,205,206,5,64,0,0,
		206,72,1,0,0,0,207,208,5,91,0,0,208,74,1,0,0,0,209,210,5,92,0,0,210,76,
		1,0,0,0,211,212,5,93,0,0,212,78,1,0,0,0,213,214,5,94,0,0,214,80,1,0,0,
		0,215,216,5,95,0,0,216,82,1,0,0,0,217,218,5,96,0,0,218,84,1,0,0,0,219,
		220,5,123,0,0,220,86,1,0,0,0,221,222,5,124,0,0,222,88,1,0,0,0,223,224,
		5,125,0,0,224,90,1,0,0,0,225,226,5,126,0,0,226,92,1,0,0,0,4,0,146,149,
		153,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
