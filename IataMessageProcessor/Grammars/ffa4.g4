// Определение грамматики телекса FFA
grammar ffa4;

/*Parser Rules*/

ffa4:									standardMessageIdentification consignmentDetail flightDetails specialServiceRequest? otherServiceInformation? bookingReference shipmentReferenceInformation?;

standardMessageIdentification:			standardMessageIdentifier SeparatorSlant messageTypeVersionNumber SeparatorCrlf;
consignmentDetail:						awbIdentification awbOriginAndDestination quantityDetail volumeDetail? densityGroup? totalConsignmentPieces? natureOfGoods shrs? SeparatorCrlf;
flightDetails:							flightInfoDetails+;
specialServiceRequest:					LineIdentifierSsr ssrDetails1stLine ssrDetails2stLine?;
otherServiceInformation:				LineIdentifierOsi osiDetails1stLine osiDetails2stLine?;
bookingReference:						lineIdentifier SeparatorSlant requestingOfficeMessageAddress? rofr? SeparatorCrlf;
shipmentReferenceInformation:			lineIdentifier SeparatorSlant referenceNumber? supplementary1or2? SeparatorCrlf;

/*Вспомогательные элементы*/
flightInfoDetails:						flightIdentification SeparatorSlant airportsOfDepartureAndArrival SeparatorSlant spaceAllocationCode SeparatorCrlf;
flightIdentification:					carrierCode flightNumber SeparatorSlant dayOfScheduledDeparture monthOfScheduledDeparture;
airportsOfDepartureAndArrival:			airportCodeOfDeparture airportCodeOfArrival;
awbIdentification:						airlinePrefix SeparatorHyphen awbSerialNumber;
awbOriginAndDestination:				airportCodeOfOrigin? airportCodeOfDestitation;
quantityDetail:							SeparatorSlant shipmentDescriptionCode numberOfPieces weightCode weight;
volumeDetail:							volumeCode volumeAmount;
densityGroup:							densityIndicator densityGroupInner;
totalConsignmentPieces:					shipmentDescriptionCode numberOfPieces;
shrs:									SeparatorCrlf specialHandlingRequirements+;
specialHandlingRequirements:			SeparatorSlant specialHandlingCode;
ssrDetails1stLine:						ssrDescription SeparatorCrlf;
ssrDetails2stLine:						SeparatorSlant ssrDescription SeparatorCrlf;
osiDetails1stLine:						osiDescription SeparatorCrlf;
osiDetails2stLine:						SeparatorSlant osiDescription SeparatorCrlf;
natureOfGoods:							SeparatorSlant manifestDescriptionOfGoods;
requestingOfficeMessageAddress:			airportCityCode officeFunctionDesignator companyDesignator;
rofr:									SeparatorSlant requestingOfficeFileReference? requestingParticipantIdentification?;
requestingOfficeFileReference:			fileReference;
requestingParticipantIdentification:	SeparatorSlant participantIdentifier SeparatorSlant participantCode SeparatorSlant airportCityCode;
supplementary1or2:						SeparatorSlant supplementaryShipmentInformation1? supplementaryShipmentInformation2?;
supplementaryShipmentInformation1:		innerSupplementaryShipmentInformation;
supplementaryShipmentInformation2:		SeparatorSlant innerSupplementaryShipmentInformation;



/** Parser bottom*/

standardMessageIdentifier:				A A A;
messageTypeVersionNumber:				N N? N?;
lineIdentifier:							A A A;
spaceAllocationCode:					A A;
airlinePrefix:							N N N;
awbSerialNumber:						N N N N N N N N;
airportCodeOfDeparture:					A A A;
airportCodeOfOrigin:					A A A;
airportCodeOfDestitation:				A A A;
airportCodeOfArrival:					A A A;
shipmentDescriptionCode:				A;
volumeCode:								A A;
volumeAmount:							N+ (('.'| ',') N+)?;
densityIndicator:						A A;
densityGroupInner:						N N?;
dayOfScheduledDeparture:				N N;
monthOfScheduledDeparture:				A A A;
flightNumber:							N N N N? A?;
carrierCode:							(A | N) (A | N);
weightCode:								A;
weight:									N+ (('.'| ',') N+)?;
numberOfPieces:							N N? N? N?;
specialHandlingCode:					(A | N) (A | N) (A | N);
airportCityCode:						A A A;
officeFunctionDesignator:				(A | N) (A | N);
companyDesignator:						(A | N) (A | N);
participantIdentifier:					(A | N)+;
participantCode:						(A | N)+;
manifestDescriptionOfGoods:				~(SeparatorSlant|SeparatorCrlf)+;
ssrDescription:							~(SeparatorSlant|SeparatorCrlf)+;
osiDescription:							~(SeparatorSlant|SeparatorCrlf)+;
referenceNumber:						~(SeparatorSlant|SeparatorCrlf)+;
innerSupplementaryShipmentInformation:	~(SeparatorSlant|SeparatorCrlf)+;
fileReference:							~(SeparatorSlant|SeparatorCrlf)+;


/*Lexer Rules*/

/**lexers*/
LineIdentifierSsr:						'SSR/';
LineIdentifierOsi:						'OSI/';


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
