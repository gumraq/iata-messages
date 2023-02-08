// Определение грамматики телекса FBL
grammar fbl4;

/*Parser Rules*/

fbl4:									standardMessageIdentification flightIdAndPointOfLoading destinationHeader+ listCompleteIndicator;

standardMessageIdentification:			standardMessageIdentifier SeparatorSlant messageTypeVersionNumber SeparatorCrlf;
flightIdAndPointOfLoading:				messageSequenceNumber SeparatorSlant flightIdentification SeparatorSlant airportCodeOfLoading aircraftIdentification? SeparatorCrlf;
destinationHeader:						pointOfUnloading bookedCargo*;
listCompleteIndicator:					endOfMessageCode SeparatorCrlf;

flightIdentification:					carrierCode flightNumber SeparatorSlant dayOfScheduledDeparture monthOfScheduledDeparture;
aircraftIdentification:					SeparatorSlant aircraftRegistration;
pointOfUnloading:						airportCodeOfUnloading nilCargoIndication? SeparatorCrlf;
bookedCargo:							consignmentDetail dimensionsInformation? consignmentOriginInformation? uldDescription? specialServiceRequest? otherServiceInformation? otherCustSecurityAndRegulatCtrlInfo?;

consignmentDetail:						awbIdentification awbOriginAndDestination quantityDetail volumeDetail? densityGroup? totalConsignmentPieces? natureOfGoods shrs? SeparatorCrlf;
dimensionsInformation:					lineIdentifier dimensions+;
consignmentOriginInformation:			SeparatorSlant consignmentOriginInfoDetail SeparatorCrlf;
consignmentOriginInfoDetail:			forwardingAgent?  inwardFlightDetails? movementPriority?;
uldDescription:							LineIdentifierUld numberOfUldsTotal uldDescriptionItems+;
specialServiceRequest:					LineIdentifierSsr ssrDetails1stLine ssrDetails2stLine?;
otherServiceInformation:				LineIdentifierOsi osiDetails1stLine osiDetails2stLine?;
otherCustSecurityAndRegulatCtrlInfo:	lineIdentifier otherCustSecurityAndRegulatCtrlInfoDet+;


/*Вспомогательные элементы*/
nilCargoIndication:						SeparatorSlant nilCargoCode;
awbIdentification:						airlinePrefix SeparatorHyphen awbSerialNumber;
awbOriginAndDestination:				airportCodeOfOrigin? airportCodeOfDestitation;
quantityDetail:							SeparatorSlant shipmentDescriptionCode numberOfPieces weightCode weight;
volumeDetail:							volumeCode volumeAmount;
densityGroup:							densityIndicator densityGroupInner;
totalWeightDetails:						weightCode weight;
totalConsignmentPieces:					shipmentDescriptionCode numberOfPieces;
shrs:									SeparatorCrlf specialHandlingRequirements+;
specialHandlingRequirements:			SeparatorSlant specialHandlingCode;
ssrDetails1stLine:						ssrDescription SeparatorCrlf;
ssrDetails2stLine:						SeparatorSlant ssrDescription SeparatorCrlf;
osiDetails1stLine:						osiDescription SeparatorCrlf;
osiDetails2stLine:						SeparatorSlant osiDescription SeparatorCrlf;
uldDescriptionItems:					uldDescriptionInnerItems+ SeparatorCrlf;
uldDescriptionInnerItems:				SeparatorSlant uldIdentification uldPositionInformation? weightOfUldContents;
uldIdentification:						uldType uldNumber?;
uldNumber:								uldSerialNumber uldOwnerCode;
uldPositionInformation:					SeparatorHyphen uldLoadingIndicator;
weightOfUldContents:					SeparatorSlant weightCode weight;
forwardingAgent:						abbreviatedName;
inwardFlightDetails:					SeparatorSlant carrierCode flightNumber SeparatorSlant dayOfArrival monthOfArrival SeparatorSlant airportCodeOfLoading?;
movementPriority:						SeparatorSlant movementPriorityCode;
natureOfGoods:							SeparatorSlant manifestDescriptionOfGoods;
dimensions:								SeparatorSlant totalWeightDetails SeparatorSlant dimensionsDetails SeparatorSlant numberOfPieces SeparatorCrlf;
dimensionsDetails:						measurementUnitCode lengthDimension SeparatorHyphen widthDimension SeparatorHyphen heightDimension;
otherCustSecurityAndRegulatCtrlInfoDet:	SeparatorSlant isoCountryCode? SeparatorSlant informationIdentifier? SeparatorSlant custSecurityAndRegulatCtrlInfoId? SeparatorSlant supplemCustSecurityAndRegulatCtrlInfo SeparatorCrlf;



/** Parser bottom*/

standardMessageIdentifier:				A A A;
messageTypeVersionNumber:				N N? N?;
messageSequenceNumber:					N N?;
lineIdentifier:							A A A;
airlinePrefix:							N N N;
awbSerialNumber:						N N N N N N N N;
airportCodeOfLoading:					A A A;
airportCodeOfUnloading:					A A A;
airportCodeOfOrigin:					A A A;
airportCodeOfDestitation:				A A A;
nilCargoCode:							A A A;
numberOfUldsTotal:						N N?;
movementPriorityCode:					A;
shipmentDescriptionCode:				A;
volumeCode:								A A;
volumeAmount:							N+ (('.'| ',') N+)?;
densityIndicator:						A A;
densityGroupInner:						N N?;
dayOfScheduledDeparture:				N N;
monthOfScheduledDeparture:				A A A;
dayOfArrival:							N N;
monthOfArrival:							A A A;
flightNumber:							N N N N? A?;
carrierCode:							(A | N) (A | N);
uldType:								A (A | N) (A | N);
uldSerialNumber:						(A | N) N N N N?;
uldOwnerCode:							(A | N) (A | N);
uldLoadingIndicator:					A;
measurementUnitCode:					(A | N) (A | N)? (A | N)?;
lengthDimension:						N N? N? N? N?;
widthDimension:							N N? N? N? N?;
heightDimension:						N N? N? N? N?;
weightCode:								A;
weight:									N+ (('.'| ',') N+)?;
numberOfPieces:							N N? N? N?;
specialHandlingCode:					(A | N) (A | N) (A | N);
isoCountryCode:							A A;						
informationIdentifier:					A A A;
custSecurityAndRegulatCtrlInfoId:		A A?;
endOfMessageCode:						A A A A;
aircraftRegistration:					~(SeparatorSlant|SeparatorCrlf)+;
supplemCustSecurityAndRegulatCtrlInfo:	~(SeparatorSlant|SeparatorCrlf)+;
manifestDescriptionOfGoods:				~(SeparatorSlant|SeparatorCrlf)+;
abbreviatedName:						~(SeparatorSlant|SeparatorCrlf)+;
ssrDescription:							~(SeparatorSlant|SeparatorCrlf)+;
osiDescription:							~(SeparatorSlant|SeparatorCrlf)+;



/*Lexer Rules*/

/**lexers*/
LineIdentifierSsr:						'SSR/';
LineIdentifierOsi:						'OSI/';
LineIdentifierUld:						'ULD/';

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
