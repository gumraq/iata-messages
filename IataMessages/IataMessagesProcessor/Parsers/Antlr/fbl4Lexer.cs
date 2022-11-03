//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from fbl4.g4 by ANTLR 4.10.1

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
public partial class fbl4Lexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, LineIdentifierSsr=3, LineIdentifierOsi=4, LineIdentifierUld=5, 
		SeparatorSlant=6, SeparatorHyphen=7, A=8, N=9, G=10, SeparatorCrlf=11;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "LineIdentifierSsr", "LineIdentifierOsi", "LineIdentifierUld", 
		"SeparatorSlant", "SeparatorHyphen", "A", "N", "G", "SeparatorCrlf", "DIGIT", 
		"CAPITAL_LETTER", "SMALL_LETTER", "SLANT", "HYPHEN", "SPACE", "EXCLAMATION_MARK", 
		"DOUBLE_QUOTE", "NUMBER_SIGN", "DOLLAR_SIGN", "PERCENT", "AMPERSAND", 
		"SINGLE_QUOTE", "LEFT_OPENING_PARENTHESIS", "RIGHT_CLOSING_PARENTHESIS", 
		"ASTERISK", "PLUS", "COMMA", "DOT", "COLON", "SEMICOLON", "LESS_THAN", 
		"EQUAL_SIGN", "GREATER_THAN", "QUESTION_MARK", "AT_SYMBOL", "LEFT_OPENING_BRACKET", 
		"BACK_SLASH", "RIGHT_CLOSING_BRACKET", "CARET_CIRCUMFLEX", "UNDERSCORE", 
		"GRAVE_ACCENT", "LEFT_OPENING_BRACE", "VERTICAL_BAR", "RIGHT_CLOSING_BRACE", 
		"TILDE"
	};


	public fbl4Lexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public fbl4Lexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'.'", "','", "'SSR/'", "'OSI/'", "'ULD/'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "LineIdentifierSsr", "LineIdentifierOsi", "LineIdentifierUld", 
		"SeparatorSlant", "SeparatorHyphen", "A", "N", "G", "SeparatorCrlf"
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

	public override string GrammarFileName { get { return "fbl4.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static fbl4Lexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,11,234,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,1,0,1,0,1,1,1,1,1,2,1,2,1,
		2,1,2,1,2,1,3,1,3,1,3,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,5,1,5,1,6,1,6,1,7,
		1,7,1,8,1,8,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,
		9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,9,3,9,
		154,8,9,1,10,3,10,157,8,10,1,10,1,10,3,10,161,8,10,1,11,1,11,1,12,1,12,
		1,13,1,13,1,14,1,14,1,15,1,15,1,16,1,16,1,17,1,17,1,18,1,18,1,19,1,19,
		1,20,1,20,1,21,1,21,1,22,1,22,1,23,1,23,1,24,1,24,1,25,1,25,1,26,1,26,
		1,27,1,27,1,28,1,28,1,29,1,29,1,30,1,30,1,31,1,31,1,32,1,32,1,33,1,33,
		1,34,1,34,1,35,1,35,1,36,1,36,1,37,1,37,1,38,1,38,1,39,1,39,1,40,1,40,
		1,41,1,41,1,42,1,42,1,43,1,43,1,44,1,44,1,45,1,45,1,46,1,46,0,0,47,1,1,
		3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,11,23,0,25,0,27,0,29,0,31,
		0,33,0,35,0,37,0,39,0,41,0,43,0,45,0,47,0,49,0,51,0,53,0,55,0,57,0,59,
		0,61,0,63,0,65,0,67,0,69,0,71,0,73,0,75,0,77,0,79,0,81,0,83,0,85,0,87,
		0,89,0,91,0,93,0,1,0,3,1,0,48,57,1,0,65,90,1,0,97,122,229,0,1,1,0,0,0,
		0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,
		0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,1,95,1,0,0,0,3,
		97,1,0,0,0,5,99,1,0,0,0,7,104,1,0,0,0,9,109,1,0,0,0,11,114,1,0,0,0,13,
		116,1,0,0,0,15,118,1,0,0,0,17,120,1,0,0,0,19,153,1,0,0,0,21,160,1,0,0,
		0,23,162,1,0,0,0,25,164,1,0,0,0,27,166,1,0,0,0,29,168,1,0,0,0,31,170,1,
		0,0,0,33,172,1,0,0,0,35,174,1,0,0,0,37,176,1,0,0,0,39,178,1,0,0,0,41,180,
		1,0,0,0,43,182,1,0,0,0,45,184,1,0,0,0,47,186,1,0,0,0,49,188,1,0,0,0,51,
		190,1,0,0,0,53,192,1,0,0,0,55,194,1,0,0,0,57,196,1,0,0,0,59,198,1,0,0,
		0,61,200,1,0,0,0,63,202,1,0,0,0,65,204,1,0,0,0,67,206,1,0,0,0,69,208,1,
		0,0,0,71,210,1,0,0,0,73,212,1,0,0,0,75,214,1,0,0,0,77,216,1,0,0,0,79,218,
		1,0,0,0,81,220,1,0,0,0,83,222,1,0,0,0,85,224,1,0,0,0,87,226,1,0,0,0,89,
		228,1,0,0,0,91,230,1,0,0,0,93,232,1,0,0,0,95,96,5,46,0,0,96,2,1,0,0,0,
		97,98,5,44,0,0,98,4,1,0,0,0,99,100,5,83,0,0,100,101,5,83,0,0,101,102,5,
		82,0,0,102,103,5,47,0,0,103,6,1,0,0,0,104,105,5,79,0,0,105,106,5,83,0,
		0,106,107,5,73,0,0,107,108,5,47,0,0,108,8,1,0,0,0,109,110,5,85,0,0,110,
		111,5,76,0,0,111,112,5,68,0,0,112,113,5,47,0,0,113,10,1,0,0,0,114,115,
		3,29,14,0,115,12,1,0,0,0,116,117,3,31,15,0,117,14,1,0,0,0,118,119,3,25,
		12,0,119,16,1,0,0,0,120,121,3,23,11,0,121,18,1,0,0,0,122,154,3,33,16,0,
		123,154,3,35,17,0,124,154,3,37,18,0,125,154,3,39,19,0,126,154,3,41,20,
		0,127,154,3,43,21,0,128,154,3,45,22,0,129,154,3,47,23,0,130,154,3,49,24,
		0,131,154,3,51,25,0,132,154,3,53,26,0,133,154,3,55,27,0,134,154,3,57,28,
		0,135,154,3,59,29,0,136,154,3,61,30,0,137,154,3,63,31,0,138,154,3,65,32,
		0,139,154,3,67,33,0,140,154,3,69,34,0,141,154,3,71,35,0,142,154,3,73,36,
		0,143,154,3,75,37,0,144,154,3,77,38,0,145,154,3,79,39,0,146,154,3,81,40,
		0,147,154,3,83,41,0,148,154,3,85,42,0,149,154,3,87,43,0,150,154,3,89,44,
		0,151,154,3,91,45,0,152,154,3,93,46,0,153,122,1,0,0,0,153,123,1,0,0,0,
		153,124,1,0,0,0,153,125,1,0,0,0,153,126,1,0,0,0,153,127,1,0,0,0,153,128,
		1,0,0,0,153,129,1,0,0,0,153,130,1,0,0,0,153,131,1,0,0,0,153,132,1,0,0,
		0,153,133,1,0,0,0,153,134,1,0,0,0,153,135,1,0,0,0,153,136,1,0,0,0,153,
		137,1,0,0,0,153,138,1,0,0,0,153,139,1,0,0,0,153,140,1,0,0,0,153,141,1,
		0,0,0,153,142,1,0,0,0,153,143,1,0,0,0,153,144,1,0,0,0,153,145,1,0,0,0,
		153,146,1,0,0,0,153,147,1,0,0,0,153,148,1,0,0,0,153,149,1,0,0,0,153,150,
		1,0,0,0,153,151,1,0,0,0,153,152,1,0,0,0,154,20,1,0,0,0,155,157,5,13,0,
		0,156,155,1,0,0,0,156,157,1,0,0,0,157,158,1,0,0,0,158,161,5,10,0,0,159,
		161,5,13,0,0,160,156,1,0,0,0,160,159,1,0,0,0,161,22,1,0,0,0,162,163,7,
		0,0,0,163,24,1,0,0,0,164,165,7,1,0,0,165,26,1,0,0,0,166,167,7,2,0,0,167,
		28,1,0,0,0,168,169,5,47,0,0,169,30,1,0,0,0,170,171,5,45,0,0,171,32,1,0,
		0,0,172,173,5,32,0,0,173,34,1,0,0,0,174,175,5,33,0,0,175,36,1,0,0,0,176,
		177,5,34,0,0,177,38,1,0,0,0,178,179,5,35,0,0,179,40,1,0,0,0,180,181,5,
		36,0,0,181,42,1,0,0,0,182,183,5,37,0,0,183,44,1,0,0,0,184,185,5,38,0,0,
		185,46,1,0,0,0,186,187,5,39,0,0,187,48,1,0,0,0,188,189,5,40,0,0,189,50,
		1,0,0,0,190,191,5,41,0,0,191,52,1,0,0,0,192,193,5,42,0,0,193,54,1,0,0,
		0,194,195,5,43,0,0,195,56,1,0,0,0,196,197,5,44,0,0,197,58,1,0,0,0,198,
		199,5,46,0,0,199,60,1,0,0,0,200,201,5,58,0,0,201,62,1,0,0,0,202,203,5,
		59,0,0,203,64,1,0,0,0,204,205,5,60,0,0,205,66,1,0,0,0,206,207,5,61,0,0,
		207,68,1,0,0,0,208,209,5,62,0,0,209,70,1,0,0,0,210,211,5,63,0,0,211,72,
		1,0,0,0,212,213,5,64,0,0,213,74,1,0,0,0,214,215,5,91,0,0,215,76,1,0,0,
		0,216,217,5,92,0,0,217,78,1,0,0,0,218,219,5,93,0,0,219,80,1,0,0,0,220,
		221,5,94,0,0,221,82,1,0,0,0,222,223,5,95,0,0,223,84,1,0,0,0,224,225,5,
		96,0,0,225,86,1,0,0,0,226,227,5,123,0,0,227,88,1,0,0,0,228,229,5,124,0,
		0,229,90,1,0,0,0,230,231,5,125,0,0,231,92,1,0,0,0,232,233,5,126,0,0,233,
		94,1,0,0,0,4,0,153,156,160,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
