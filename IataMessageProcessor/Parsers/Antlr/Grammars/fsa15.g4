// Определение грамматики телекса FSU
// (AIR WAYBILL DATA (FSA) MESSAGE)
grammar fsa15;

/*Parser Rules*/

fsa15:									standardMessageIdentification multicarrierConsignments+;

standardMessageIdentification:			standardMessageIdentifier SeparatorSlant messageTypeVersionNumber SeparatorCrlf;
multicarrierConsignments:				consignmentDetail statusDetails* otherServiceInformation?;
statusDetails:							statusDetail uldDescriptions? otherServiceInformation?;
statusDetail:							statusDetailsRcs | statusDetailsRct | statusDetailsRcf | statusDetailsBkd | statusDetailsMan | statusDetailsDep | statusDetailsPre | statusDetailsTrm | statusDetailsTfd | statusDetailsNfd | statusDetailsAwd | statusDetailsCcd | statusDetailsDlv | statusDetailsDis | statusDetailsCrc | statusDetailsDdl | statusDetailsTgc | statusDetailsArr | statusDetailsAwr | statusDetailsFoh | otherCustSecurityAndRegulatCtrlInfo;
otherServiceInformation:				lineIdentifier osiDetails1stLine osiDetails2stLine?;

statusDetailsRcs:						LineIdentifierRcs movementDetailRcs          quantityDetail receivedFromDetail? SeparatorCrlf volumeOrDensityWithCrlf?;
statusDetailsRct:						LineIdentifierRct movementDetailRct          quantityDetail receivedfromDetailSep? SeparatorCrlf;
statusDetailsRcf:						LineIdentifierRcf movementDetailWithFlightId quantityDetail timeInformations? SeparatorCrlf;
statusDetailsBkd:						LineIdentifierBkd movementDetail             quantityDetail timeAndVolumeInformation? SeparatorCrlf;
statusDetailsMan:						LineIdentifierMan movementDetail             quantityDetail timeInformations? SeparatorCrlf;
statusDetailsDep:						LineIdentifierDep movementDetail             quantityDetail timeInformations? SeparatorCrlf;
statusDetailsPre:						LineIdentifierPre movementDetail             quantityDetail timeInformations? SeparatorCrlf; 
statusDetailsTrm:						LineIdentifierTrm movementDetailTrm          quantityDetail SeparatorCrlf;
statusDetailsTfd:						LineIdentifierTfd movementDetailTfd          quantityDetail transferReference? transferredFromDetail? SeparatorCrlf;
statusDetailsNfd:						LineIdentifierNfd movementDetailNfd          quantityDetail notificationToDetail? SeparatorCrlf;
statusDetailsAwd:						LineIdentifierAwd movementDetailAwd          quantityDetail deliveryToDetail? SeparatorCrlf;
statusDetailsCcd:						LineIdentifierCcd movementDetailCcd          quantityDetail SeparatorCrlf;
statusDetailsDlv:						LineIdentifierDlv movementDetailDlv          quantityDetail deliveryToDetail? SeparatorCrlf;
statusDetailsDis:						LineIdentifierDis movementDetailWithFlightId discrepancyDescription quantityDetail SeparatorCrlf;
statusDetailsCrc:						LineIdentifierCrc reportingDetail            quantityDetail movementDetailWithSlant? SeparatorCrlf;
statusDetailsDdl:						LineIdentifierDdl movementDetailDdl          quantityDetail deliveryToDetail? SeparatorCrlf; 
statusDetailsTgc:						LineIdentifierTgc movementDetailTgc          quantityDetail SeparatorCrlf;
statusDetailsArr:						LineIdentifierArr movementDetailWithFlightId quantityDetail timeInformations? SeparatorCrlf;
statusDetailsAwr:						LineIdentifierAwr movementDetailWithFlightId quantityDetail timeInformations? SeparatorCrlf;
statusDetailsFoh:						LineIdentifierFoh movementDetailFoh          quantityDetail receivedFromDetail? SeparatorCrlf volumeOrDensityWithCrlf?;
otherCustSecurityAndRegulatCtrlInfo:	lineIdentifier otherCustSecurityAndRegulatCtrlInfoDet+;


consignmentDetail:						awbIdentification awbOriginAndDestination? quantityDetail? totalConsignmentPieces? SeparatorCrlf;
quantityDetail:							SeparatorSlant shipmentDescriptionCode numberOfPieces weightInformation?;
movementDetail:							carrierCode? flightNumber? SeparatorSlant dayOfScheduledDeparture? monthOfScheduledDeparture? SeparatorSlant airportCodeOfDeparture airportCodeOfArrival;
movementDetailRcs:						dayOfReceipt monthOfReceipt actualTimeOfGivenStatusEvent SeparatorSlant airportCodeOfReceipt;
movementDetailRct:						transferringCarrier SeparatorSlant dayOfTransfer monthOfTransfer actualTimeOfGivenStatusEvent SeparatorSlant airportCodeOfTransfer;
movementDetailTrm:						receivingCarrier SeparatorSlant airportCodeOfTransfer;
movementDetailTfd:						receivingCarrier SeparatorSlant dayOfTransfer monthOfTransfer actualTimeOfGivenStatusEvent SeparatorSlant airportCodeOfTransfer;
movementDetailNfd:						dayOfNotification monthOfNotification actualTimeOfGivenStatusEvent SeparatorSlant airportCodeOfNotification;
movementDetailAwd:						dayOfDelivery monthOfDelivery actualTimeOfGivenStatusEvent SeparatorSlant airportCodeOfDelivery;
movementDetailCcd:						dayOfClearance monthOfClearance actualTimeOfGivenStatusEvent SeparatorSlant airportCodeOfClearance;
movementDetailDlv:						dayOfDelivery monthOfDelivery actualTimeOfGivenStatusEvent SeparatorSlant airportCodeOfDelivery;
movementDetailDdl:						dayOfDeliveryToConsigneesDoor monthOfDeliveryToConsigneesDoor actualTimeOfGivenStatusEvent SeparatorSlant airportCodeOfDeliveryToConsigneesDoor;
movementDetailTgc:						dayOfTransfer monthOfTransfer actualTimeOfGivenStatusEvent SeparatorSlant airportCodeOfTransfer;
movementDetailFoh:						dayOfReceipt monthOfReceipt actualTimeOfGivenStatusEvent SeparatorSlant airportCodeOfReceipt;
movementDetailWithSlant:				SeparatorSlant movementDetail;
movementDetailWithFlightId:				flightIdentification? SeparatorSlant dayOfScheduledArrival monthOfScheduledArrival actualTimeOfGivenStatusEvent dayChangeIndicator? SeparatorSlant airportCodeOfArrival;
reportingDetail:						dayOfReporting monthOfReporting actualTimeOfGivenStatusEvent SeparatorSlant airportCodeOfReporting;

/*Вспомогательные элементы*/
awbIdentification:						airlinePrefix SeparatorHyphen awbSerialNumber;
awbOriginAndDestination:				airportCodeOfOrigin airportCodeOfDestitation;
weightInformation:						weightCode weight;
volumeDetail:							volumeCode volumeAmount;
densityGroup:							densityIndicator densityGroupInner;
volumeOrDensity:						SeparatorSlant volumeOrDensityDetail;
volumeOrDensityWithCrlf:				SeparatorSlant volumeOrDensityDetail SeparatorCrlf;
volumeOrDensityDetail:					volumeDetail | densityGroup;
totalConsignmentPieces:					shipmentDescriptionCode numberOfPieces;
flightIdentification:					carrierCode flightNumber;
timeInformations:						SeparatorSlant timeOfDepartureInformation? timeOfArrivalInformation?;
timeAndVolumeInformation:				SeparatorSlant timeOfDepartureInformation? timeOfArrivalAndVolume?;
timeOfDepartureInformation:				timeInformation;
timeOfArrivalInformation:				SeparatorSlant timeInformation;
timeInformation:						typeOfTimeIndicator time dayChangeIndicator?;
timeOfArrivalAndVolume:					SeparatorSlant timeInformation? volumeOrDensity?;
dayChangeIndicator:						SeparatorHyphen dayChangeIndicatorCode;
receivedfromDetailSep:					SeparatorCrlf SeparatorSlant receivingCarrier receivedName?;
discrepancyDescription:					SeparatorSlant discrepancyCode;
transferReference:						SeparatorSlant transferManifestNumber;
transferredFromDetail:					SeparatorCrlf SeparatorSlant transferringCarrier transferredName?;
uldDescriptions:						LineIdentifierUld uldDescription+ SeparatorCrlf;
uldDescription:							SeparatorSlant uldIdentification uldPositionInformation?;
uldIdentification:						uldType uldSerialNumber uldOwnerCode;
uldPositionInformation:					SeparatorHyphen uldLoadingIndicator;
osiDetails1stLine:						SeparatorSlant osiDescription SeparatorCrlf;
osiDetails2stLine:						SeparatorSlant osiDescription SeparatorCrlf;
receivedFromDetail:						SeparatorSlant name;
transferredName:						SeparatorSlant name;
receivedName:							SeparatorSlant name;
notificationToDetail:					SeparatorSlant name;
deliveryToDetail:						SeparatorSlant name;
otherCustSecurityAndRegulatCtrlInfoDet:	SeparatorSlant isoCountryCode? SeparatorSlant informationIdentifier? SeparatorSlant custSecurityAndRegulatCtrlInfoId? SeparatorSlant supplemCustSecurityAndRegulatCtrlInfo SeparatorCrlf;


/** Parser bottom*/

standardMessageIdentifier:				A A A;
messageTypeVersionNumber:				N N? N?;
lineIdentifier:							A A A;
airlinePrefix:							N N N;
awbSerialNumber:						N N N N N N N N;
airportCodeOfOrigin:					A A A;
airportCodeOfDestitation:				A A A;
airportCodeOfArrival:					A A A;
airportCodeOfDeparture:					A A A;
airportCodeOfNotification:				A A A;
airportCodeOfDelivery:					A A A;
airportCodeOfClearance:					A A A;
airportCodeOfReporting:					A A A;
airportCodeOfDeliveryToConsigneesDoor:	A A A;
transferManifestNumber:					N N N N N N;
shipmentDescriptionCode:				A;
dayChangeIndicatorCode:					A;
typeOfTimeIndicator:					A;
volumeCode:								A A;
volumeAmount:							N+ (('.'| ',') N+)?;
densityIndicator:						A A;
receivingCarrier:						A A;
uldLoadingIndicator:					A;
densityGroupInner:						N N?;
discrepancyCode:						A A A A;
dayOfReceipt:							N N;
dayOfTransfer:							N N;
dayOfScheduledArrival:					N N;
dayOfScheduledDeparture:				N N;
dayOfNotification:						N N;
dayOfDelivery:							N N;
dayOfClearance:							N N;
dayOfReporting:							N N;
dayOfDeliveryToConsigneesDoor:			N N;
monthOfReceipt:							A A A;
monthOfTransfer:						A A A;
monthOfScheduledArrival:				A A A;
monthOfScheduledDeparture:				A A A;
monthOfNotification:					A A A;
monthOfClearance:						A A A;
monthOfDelivery:						A A A;
monthOfReporting:						A A A;
monthOfDeliveryToConsigneesDoor:		A A A;
actualTimeOfGivenStatusEvent:			N N N N;
time:									N N N N;
airportCodeOfReceipt:					A A A;
airportCodeOfTransfer:					A A A;
flightNumber:							N N N N? A?;
carrierCode:							(A | N) (A | N);
transferringCarrier:					(A | N) (A | N);
uldType:								A (A | N) (A | N);
uldSerialNumber:						(A | N) N N N N?;
uldOwnerCode:							(A | N) (A | N);
weightCode:								A;
weight:									N+ (('.'| ',') N+)?;
numberOfPieces:							N N? N? N?;
isoCountryCode:							A A;						
informationIdentifier:					A A A;
custSecurityAndRegulatCtrlInfoId:		A A?;
supplemCustSecurityAndRegulatCtrlInfo:	~SeparatorCrlf+;
osiDescription:							~SeparatorCrlf+;
name:									~SeparatorCrlf+;


/*Lexer Rules*/

/**lexers*/
LineIdentifierRcs:						'RCS/';
LineIdentifierRct:						'RCT/';
LineIdentifierRcf:						'RCF/';
LineIdentifierBkd:						'BKD/';
LineIdentifierMan:						'MAN/';
LineIdentifierDep:						'DEP/';
LineIdentifierPre:						'PRE/';
LineIdentifierTrm:						'TRM/';
LineIdentifierTfd:						'TFD/';
LineIdentifierNfd:						'NFD/';
LineIdentifierAwd:						'AWD/';
LineIdentifierCcd:						'CCD/';
LineIdentifierDlv:						'DLV/';
LineIdentifierDis:						'DIS/';
LineIdentifierCrc:						'CRC/';
LineIdentifierDdl:						'DDL/';
LineIdentifierTgc:						'TGC/';
LineIdentifierArr:						'ARR/';
LineIdentifierAwr:						'AWR/';
LineIdentifierFoh:						'FOH/';
LineIdentifierUld:						'ULD';

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
