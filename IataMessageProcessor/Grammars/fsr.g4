// (FREIGHT BOOKED LIST REQUEST (FSR) MESSAGE)
grammar fsr;


fsr:									standardMessageIdentification consignmentDetail flightDetails* otherServiceInformation?;

standardMessageIdentification:			standardMessageIdentifier SeparatorCrlf;
consignmentDetail:						awbIdentification awbOriginAndDestination? quantityDetail? totalConsignmentPieces? natureOfGoods? SeparatorCrlf;
flightDetails:							flightIdentification SeparatorSlant airportsOfDepartureAndArrival SeparatorCrlf;
otherServiceInformation:				lineIdentifier osiDetails1stLine osiDetails2stLine?;

awbIdentification:						airlinePrefix SeparatorHyphen awbSerialNumber;
awbOriginAndDestination:				airportCodeOfOrigin airportCodeOfDestitation;
quantityDetail:							SeparatorSlant shipmentDescriptionCode numberOfPieces weightDetails?;
totalConsignmentPieces:					shipmentDescriptionCode numberOfPieces;
weightDetails:							weightCode weight;
natureOfGoods:							SeparatorSlant manifestDescriptionOfGoods;
flightIdentification:					carrierCode flightNumber? SeparatorSlant flightDate?;
airportsOfDepartureAndArrival:			airportCodeOfDeparture airportCodeOfArrival;
osiDetails1stLine:						SeparatorSlant osiDescription SeparatorCrlf;
osiDetails2stLine:						SeparatorSlant osiDescription SeparatorCrlf;
flightDate:								dayOfScheduledDeparture monthOfScheduledDeparture;

standardMessageIdentifier:				A A A;
lineIdentifier:							A A A;
airlinePrefix:							N N N;
awbSerialNumber:						N N N N N N N N;
shipmentDescriptionCode:				A;
numberOfPieces:							N N? N? N?;
weightCode:								A;
weight:									N+ (('.'| ',') N+)?;
carrierCode:							A A;
flightNumber:							N N N N? A?;
dayOfScheduledDeparture:				N N;
monthOfScheduledDeparture:				A A A;
airportCodeOfDeparture:					A A A;
airportCodeOfArrival:					A A A;
airportCodeOfOrigin:					A A A;
airportCodeOfDestitation:				A A A;
manifestDescriptionOfGoods:				~(SeparatorCrlf)+;
osiDescription:							~(SeparatorCrlf)+;


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
