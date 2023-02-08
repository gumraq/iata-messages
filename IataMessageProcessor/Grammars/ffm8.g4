// Определение грамматики телекса FFM
grammar ffm8;

/*Parser Rules*/

ffm8:									standardMessageIdentification flightIdAndPointOfLoading destinationHeader+ manifestCompleteIndicator;

standardMessageIdentification:			standardMessageIdentifier SeparatorSlant messageTypeVersionNumber SeparatorCrlf;
flightIdAndPointOfLoading:				messageSequenceNumber SeparatorSlant flightIdentification SeparatorSlant airportCodeOfLoading aircraftIdentification? firstPointOfArrivalInformation? SeparatorCrlf;
destinationHeader:						pointOfUnloading bulkLoadedCargo? uldLoadedCargo*;
manifestCompleteIndicator:				endOfMessageCode SeparatorCrlf;

pointOfUnloading:						airportCodeOfUnloading nilCargoIndication? arrivalInformation? departureInformation? SeparatorCrlf;
bulkLoadedCargo:						consignments+;
uldLoadedCargo:							uldDescription uldMovementInformation* uldUtilisationDetail? consignments+;

consignments:							consignmentDetail dimensionsInformation? consignmentOnwardMovementInfo? otherServiceInformation? customsOrigin? otherCustSecurityAndRegulatCtrlInfo?;
uldDescription:							LineIdentifierUld uldIdentification uldPositionInformation? uldRemarks? SeparatorCrlf;
uldMovementInformation:					uldOnwardRoutingDetail uldOnwardBookingDetail? SeparatorCrlf;
uldUtilisationDetail:					SeparatorSlant uldVolumeAvailableCode SeparatorCrlf;
otherServiceInformation:				lineIdentifier osiDetails1stLine osiDetails2stLine?;
customsOrigin:							lineIdentifier SeparatorSlant customsOriginCode SeparatorCrlf;
otherCustSecurityAndRegulatCtrlInfo:	lineIdentifier otherCustSecurityAndRegulatCtrlInfoDet+;



/*Вспомогательные элементы*/
flightIdentification:					carrierCode flightNumber SeparatorSlant dayOfScheduledDeparture monthOfScheduledDeparture timeOfScheduledDeparture?;
firstPointOfArrivalInformation:			SeparatorSlant isoCountryCode SeparatorSlant dayOfScheduledArrival monthOfScheduledArrival timeOfScheduledArrival SeparatorSlant airportCodeOfArrival;
nilCargoIndication:						SeparatorSlant nilCargoCode;
aircraftIdentification:					SeparatorSlant aircraftRegistration;
arrivalInformation:						SeparatorSlant arrivalInformationDetail;
departureInformation:					SeparatorSlant departureInformationDetail;
arrivalInformationDetail:				dayOfScheduledArrival monthOfScheduledArrival timeOfScheduledArrival;
departureInformationDetail:				dayOfScheduledDeparture monthOfScheduledDeparture timeOfScheduledDeparture;
awbIdentification:						airlinePrefix SeparatorHyphen awbSerialNumber;
awbOriginAndDestination:				airportCodeOfOrigin? airportCodeOfDestitation;
quantityDetail:							SeparatorSlant shipmentDescriptionCode numberOfPieces weightCode weight;
volumeDetail:							volumeCode volumeAmount;
densityGroup:							densityIndicator densityGroupInner;
totalWeightDetails:						weightCode weight;
totalConsignmentPieces:					shipmentDescriptionCode numberOfPieces;
shrs:									SeparatorCrlf specialHandlingRequirements+;
specialHandlingRequirements:			SeparatorSlant specialHandlingCode;
consignmentDetail:						awbIdentification awbOriginAndDestination quantityDetail volumeDetail? densityGroup? totalConsignmentPieces? natureOfGoods shrs? SeparatorCrlf;
dimensionsInformation:					lineIdentifier dimensions+;
consignmentOnwardMovementInfo:			consignmentOnward+ movementPriority?;
consignmentOnward:						onwardRoutingDetail onwardBookingDetail? SeparatorCrlf;
onwardRoutingDetail:					SeparatorSlant airportCodeOfNextDestination carrierCode;
onwardBookingDetail:					flightNumber SeparatorSlant dayOfScheduledDeparture monthOfScheduledDeparture;
osiDetails1stLine:						SeparatorSlant osiDescription SeparatorCrlf;
osiDetails2stLine:						SeparatorSlant osiDescription SeparatorCrlf;
uldOnwardRoutingDetail:					SeparatorSlant airportCodeOfNextDestination carrierCode;
uldOnwardBookingDetail:					flightNumber SeparatorSlant dayOfScheduledDeparture monthOfScheduledDeparture;
uldIdentification:						uldType uldSerialNumber uldOwnerCode;
uldPositionInformation:					SeparatorHyphen uldLoadingIndicator;
uldRemarks:								SeparatorSlant uldRemarksDescription;
movementPriority:						SeparatorSlant movementPriorityCode SeparatorCrlf;
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
airportCodeOfArrival:					A A A;
airportCodeOfNextDestination:			A A A;
uldVolumeAvailableCode:					N;
nilCargoCode:							A A A;
movementPriorityCode:					A;
shipmentDescriptionCode:				A;
volumeCode:								A A;
volumeAmount:							N+ (('.'| ',') N+)?;
densityIndicator:						A A;
densityGroupInner:						N N?;
dayOfScheduledArrival:					N N;
monthOfScheduledArrival:				A A A;
timeOfScheduledArrival:					N N N N;
dayOfScheduledDeparture:				N N;
monthOfScheduledDeparture:				A A A;
timeOfScheduledDeparture:				N N N N;
flightNumber:							N N N N? A?;
customsOriginCode:						(A | N) (A | N)?;
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
uldRemarksDescription:					~(SeparatorSlant|SeparatorCrlf)+;
osiDescription:							~(SeparatorSlant|SeparatorCrlf)+;



/*Lexer Rules*/

/**lexers*/
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
