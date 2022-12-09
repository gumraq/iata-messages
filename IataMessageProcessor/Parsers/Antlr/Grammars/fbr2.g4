// (FREIGHT BOOKED LIST REQUEST (FBR) MESSAGE)
grammar fbr2;


fbr2:									standardMessageIdentification flightInformation requestReference;

standardMessageIdentification:			standardMessageIdentifier SeparatorSlant messageTypeVersionNumber SeparatorCrlf;
flightInformation:						lineIdentifier SeparatorSlant flightIdentification SeparatorCrlf;
requestReference:						lineIdentifier SeparatorSlant requestingOfficeMessageAddress? rofr? SeparatorCrlf;

flightIdentification:					carrierCode flightNumber SeparatorSlant dayOfScheduledDeparture monthOfScheduledDeparture SeparatorSlant airportCodeOfLoading airportCodeOfUnloading?;
requestingOfficeMessageAddress:			airportCityCode officeFunctionDesignator companyDesignator;
rofr:									SeparatorSlant requestingOfficeFileReference? requestingParticipantIdentification?;
requestingOfficeFileReference:			fileReference;
requestingParticipantIdentification:	SeparatorSlant participantIdentifier SeparatorSlant participantCode SeparatorSlant airportCityCode;


standardMessageIdentifier:				A A A;
messageTypeVersionNumber:				N N? N?;
lineIdentifier:							A A A;
carrierCode:							A A;
flightNumber:							N N N N? A?;
dayOfScheduledDeparture:				N N;
monthOfScheduledDeparture:				A A A;
airportCodeOfLoading:					A A A;
airportCodeOfUnloading:					A A A;
airportCityCode:						A A A;
officeFunctionDesignator:				(A | N) (A | N);
companyDesignator:						(A | N) (A | N);
fileReference:							~(SeparatorSlant|SeparatorCrlf)+;
participantIdentifier:					(A | N)+;
participantCode:						(A | N)+;


/*Lexer Rules*/

/**lexers*/
SeparatorSlant:							SLANT;
SeparatorHyphen:						HYPHEN;
A:										CAPITAL_LETTER;
N:										DIGIT;
G:										SPACE | EXCLAMATION_MARK | DOUBLE_QUOTE | NUMBER_SIGN | DOLLAR_SIGN | PERCENT | AMPERSAND | SINGLE_QUOTE | LEFT_OPENING_PARENTHESIS | RIGHT_CLOSING_PARENTHESIS | ASTERISK | PLUS | COMMA | DOT | COLON | SEMICOLON | LESS_THAN | EQUAL_SIGN | GREATER_THAN | QUESTION_MARK | AT_SYMBOL | LEFT_OPENING_BRACKET | BACK_SLASH | RIGHT_CLOSING_BRACKET | CARET_CIRCUMFLEX | UNDERSCORE | GRAVE_ACCENT | LEFT_OPENING_BRACE | VERTICAL_BAR | RIGHT_CLOSING_BRACE | TILDE;
SeparatorCrlf:							'\r'? '\n' | '\r';

/**Note*/
// Примечание к лексеру:
// не удается завести правило лексера для T, M, которые упоминаются в Cargo IMP.
// однако получается указать эти правила в парсере. Это решает проблему. однако не получается изящно решить задачу. То есть:
// ~SeparatorSlant			это			T;
// A | N					это			M;
// N+ (('.'| ',') N+)?		это			N[...i]P

/**fragments*/
fragment DIGIT:							[0-9];
fragment CAPITAL_LETTER:				[A-Z];
fragment SMALL_LETTER:					[a-z];	// не используется
fragment SLANT:							'/';
fragment HYPHEN:						'-';
fragment SPACE:							' ';
fragment EXCLAMATION_MARK:				'!';
fragment DOUBLE_QUOTE:					'"';
fragment NUMBER_SIGN:					'#';
fragment DOLLAR_SIGN:					'$';
fragment PERCENT:						'%';
fragment AMPERSAND:						'&';
fragment SINGLE_QUOTE:					'\'';
fragment LEFT_OPENING_PARENTHESIS:		'(';
fragment RIGHT_CLOSING_PARENTHESIS:		')';
fragment ASTERISK:						'*';
fragment PLUS:							'+';
fragment COMMA:							',';
fragment DOT:							'.';
fragment COLON:							':';
fragment SEMICOLON:						';';
fragment LESS_THAN:						'<';
fragment EQUAL_SIGN:					'=';
fragment GREATER_THAN:					'>';
fragment QUESTION_MARK:					'?';
fragment AT_SYMBOL:						'@';
fragment LEFT_OPENING_BRACKET:			'[';
fragment BACK_SLASH:					'\\';
fragment RIGHT_CLOSING_BRACKET:			']';
fragment CARET_CIRCUMFLEX:				'^';
fragment UNDERSCORE:					'_';
fragment GRAVE_ACCENT:					'`';
fragment LEFT_OPENING_BRACE:			'{';
fragment VERTICAL_BAR:					'|';
fragment RIGHT_CLOSING_BRACE:			'}';
fragment TILDE:							'~';
