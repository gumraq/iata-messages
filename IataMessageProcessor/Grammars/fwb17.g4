// Определение грамматики телекса FWB
// (AIR WAYBILL DATA (FWB) MESSAGE)
grammar fwb17;

/*Parser Rules*/

fwb17:									standardMessageIdentification awbConsignmentDetail flightBookings? routing shipper consignee agent? specialServiceRequest? alsoNotify? accountingInformation? chargeDeclarations rateDescription otherCharges? prepaidChargeSummary? collectChargeSummary? shippersCertification? carriersExecution otherServiceInformation? ccChargesInDestinationCurrency? senderReference customsOrigin? commissionInformation? salesIncentiveInformation? agentReferenceData? specialHandlingDetails? nominatedHandlingParty? shipmentReferenceInformation? otherParticipantInformation* otherCustSecurityAndRegulatCtrlInfo?;

standardMessageIdentification:			standardMessageIdentifier SeparatorSlant messageTypeVersionNumber SeparatorCrlf;
awbConsignmentDetail:					awbIdentification awbOriginAndDestination quantityDetail volumeDetail? densityGroup? SeparatorCrlf;
flightBookings:							lineIdentifier flightIdentification+ SeparatorCrlf;
routing:								lineIdentifier firstDestinationCarrier onwardDestinationCarrier* SeparatorCrlf;
shipper:								lineIdentifier accountDetail? SeparatorCrlf name streetAddress location codedLocation contactDetail* SeparatorCrlf;
consignee:								lineIdentifier accountDetail? SeparatorCrlf name streetAddress location codedLocation contactDetail* SeparatorCrlf;
agent:									lineIdentifier accountDetailAgt SeparatorCrlf nameDetail place;
specialServiceRequest:					lineIdentifier ssrDetail+;
alsoNotify:								lineIdentifier SeparatorCrlf name streetAddress location codedLocation contactDetail* SeparatorCrlf;
accountingInformation:					lineIdentifier accountDetails+;
chargeDeclarations:						lineIdentifier SeparatorSlant isoCurrencyCode SeparatorSlant chargeCode? SeparatorSlant prepaidCollectChargeDeclarations? SeparatorSlant valueForCarriageDeclaration SeparatorSlant valueForCustomsDeclaration SeparatorSlant valueForInsuranceDeclaration SeparatorCrlf;
rateDescription:						lineIdentifier rateDescriptionItems+;
otherCharges:							lineIdentifier otherChargeDetails+;
prepaidChargeSummary:					LineIdentifierPpd chargesOrTaxes* SeparatorCrlf totalCharges* SeparatorCrlf;
collectChargeSummary:					LineIdentifierCol chargesOrTaxes* SeparatorCrlf totalCharges* SeparatorCrlf;
shippersCertification:					lineIdentifier SeparatorSlant signature SeparatorCrlf;
carriersExecution:						lineIdentifier awbIssueDetails authorisation? SeparatorCrlf;
otherServiceInformation:				lineIdentifier osiItems+;
ccChargesInDestinationCurrency:			lineIdentifier SeparatorSlant destinationCurrency currencyConversionRate SeparatorSlant ccChargesInDestinationCurrencyInner SeparatorSlant chargesAtDestination SeparatorSlant totalCollectCharges SeparatorCrlf;
senderReference:						lineIdentifier SeparatorSlant senderOfficeMessageAddress? sofr? SeparatorCrlf;
customsOrigin:							lineIdentifier SeparatorSlant customsOriginCode SeparatorCrlf;
commissionInformation:					lineIdentifier SeparatorSlant noCommissionIndication? commissionAmountOrPercentage? SeparatorCrlf;
salesIncentiveInformation:				LineIdentifierSii SeparatorSlant salesIncentiveDetail salesIncentiveIndication? SeparatorCrlf;
agentReferenceData:						lineIdentifier SeparatorSlant agentReference SeparatorCrlf;
specialHandlingDetails:					lineIdentifier specialHandlingRequirements+ SeparatorCrlf;
nominatedHandlingParty:					LineIdentifierNom SeparatorSlant nameInner SeparatorSlant placeInner SeparatorCrlf;
shipmentReferenceInformation:			LineIdentifierSri SeparatorSlant referenceNumber? supplementary1or2? SeparatorCrlf;
otherParticipantInformation:			lineIdentifier SeparatorSlant nameInner SeparatorCrlf SeparatorSlant otherParticipantOfficeMessageAddress? opofr?  SeparatorCrlf;
otherCustSecurityAndRegulatCtrlInfo:	lineIdentifier otherCustSecurityAndRegulatCtrlInfoDet+;




/**Rate description*/
//Level 2
rateDescriptionItems:					chargeLineCount elementFrom3To10? elementFrom11To19?;

//Level 3
chargeLineCount:						SeparatorSlant hwbRateLineNumber;
elementFrom3To10:						numberOfPiecesRcpDetails? grossWeightDetails? rateClassDetails? commodityItemNumberDetails? chargeableWeightDetails? rateChargeDetails? totalDetails? SeparatorCrlf;
elementFrom11To19:						(goodsDescription | goodsConsolidation | dimensions | volume | uldNumber | shippersLoadAndCount | harmonisedCommodityCode | countryOfOriginOfGoods | serviceCodeDetails) SeparatorCrlf;

//Level 4// ТРЕБУЕТСЯ ДОРАБОТКА
numberOfPiecesRcpDetails:				SeparatorSlant hwbColumnIdentifier (numberOfPieces | rateCombinationPoint);
grossWeightDetails:						SeparatorSlant weightInfo;
rateClassDetails:						SeparatorSlant hwbColumnIdentifier rateClassCode;
commodityItemNumberDetails:				SeparatorSlant hwbColumnIdentifier (commodityItemNumber | uldRateClassType | rateClassCodeBasisAndPercentage);
chargeableWeightDetails:				SeparatorSlant hwbColumnIdentifier weight;
rateChargeDetails:						SeparatorSlant hwbColumnIdentifier (rateOrCharge | discount);
totalDetails:							SeparatorSlant hwbColumnIdentifier (chargeAmount | discount);
// ТРЕБУЕТСЯ ДОРАБОТКА

goodsDescription:						GoodsDescriptionIdentifier natureAndQuantityOfGoods;
goodsConsolidation:						ConsolidationIdentifier natureAndQuantityOfGoods;
dimensions:								DimensionsIdentifier weightInfo? SeparatorSlant dimentionsDimNda;
volume:									VolumeIdentifier volumeCode volumeAmount;
uldNumber:								UldNumberIdentifier uldType uldSerialNumber uldOwnerCode;
shippersLoadAndCount:					ShippersLoadAndCountIdentifier slac;
harmonisedCommodityCode:				HarmonisedCommodityCodeIdentifier harmonisedCommodityCodeInner;
countryOfOriginOfGoods:					CountryOfOriginOfGoodsIdentifier isoCountryCode;
serviceCodeDetails:						SeparatorSlant serviceCode;

//Level 5
rateClassCodeBasisAndPercentage:		rateClassCodeBasis classRatePercentage;
weightInfo:								weightCode weight;
dimentionsDimNda:						measurementUnitCode dimension?;
dimension:								lengthDimension SeparatorHyphen widthDimension SeparatorHyphen heightDimension SeparatorSlant numberOfPieces;
/**End rate description*/




/*Вспомогательные элементы*/

awbIdentification:						airlinePrefix SeparatorHyphen awbSerialNumber;
awbOriginAndDestination:				airportCodeOfOrigin airportCodeOfDestitation;
quantityDetail:							SeparatorSlant shipmentDescriptionCode numberOfPieces weightCode weight;
volumeDetail:							volumeCode volumeAmount;
densityGroup:							densityIndicator densityGroupInner;
specialHandlingRequirements:			SeparatorSlant specialHandlingCode;
flightIdentification:					SeparatorSlant carrierCode flightNumber SeparatorSlant day;
firstDestinationCarrier:				SeparatorSlant airportCode? carrierCode;
onwardDestinationCarrier:				SeparatorSlant airportCode carrierCode?;
prepaidCollectChargeDeclarations:		pcIndWeightValuation pcIndOtherCharges;
valueForCarriageDeclaration:			declaredValueForCarriage | noValue;
valueForCustomsDeclaration:				declaredValueForCustoms | noValue;
valueForInsuranceDeclaration:			amountOfInsurance | noValue;
otherChargeDetails:						chargeLine otherChargeItems+ SeparatorCrlf;
chargeLine:								SeparatorSlant pcIndOtherCharges SeparatorSlant;
otherChargeItems:						otherChargeCode entitlementCode chargeAmount;
chargesOrTaxes:							SeparatorSlant chargeIdentifier chargeAmount;
totalCharges:							SeparatorSlant chargeIdentifier chargeAmount;
awbIssueDetails:						SeparatorSlant day month year SeparatorSlant placeInner? airportCityCode?;
authorisation:							SeparatorSlant signature;
destinationCurrency:					isoCurrencyCode;
currencyConversionRate:					rateOfExchange;
ccChargesInDestinationCurrencyInner:	chargeAmount;
chargesAtDestination:					chargeAmount;
totalCollectCharges:					chargeAmount;
noCommissionIndication:					cassIndicator;
commissionAmountOrPercentage:			SeparatorSlant commissionAmount? commissionPercentage?;
commissionAmount:						cassSettlementFactor;
commissionPercentage:					SeparatorSlant cassSettlementFactor;
salesIncentiveDetail:					chargeAmount;
salesIncentiveIndication:				SeparatorSlant cassIndicator;
agentReference:							fileReference;
otherCustSecurityAndRegulatCtrlInfoDet:	SeparatorSlant isoCountryCode? SeparatorSlant informationIdentifier? SeparatorSlant custSecurityAndRegulatCtrlInfoId? SeparatorSlant supplemCustSecurityAndRegulatCtrlInfo SeparatorCrlf;
accountDetail:							SeparatorSlant accountNumber;
name:									NamIdentifier nameDetail+;
nameDetail:								SeparatorSlant nameInner SeparatorCrlf;
streetAddress:							AdrIdentifier streetAddressDetail+;
streetAddressDetail:					SeparatorSlant streetAddressInner SeparatorCrlf;
location:								LocIdentifier SeparatorSlant placeInner stateProvince? SeparatorCrlf;
stateProvince:							SeparatorSlant stateProvinceInner;
codedLocation:							SeparatorSlant isoCountryCode postCode?;
postCode:								SeparatorSlant postCodeInner;
contactDetail:							SeparatorSlant contactIdentifier SeparatorSlant contactNumber;
accountDetailAgt:						SeparatorSlant accountNumber? SeparatorSlant iataCargoAgentNumericCode cargoAgentCassOrParticipantId?;
cargoAgentCassOrParticipantId:			SeparatorSlant cargoAgentCassAddress? participantId?;
participantId:							SeparatorSlant participantIdentifier;
cargoAgentCassAddress:					cargoAgentCassAddressInner;
accountDetails:							SeparatorSlant accountingInformationIdentifier SeparatorSlant accountingInformationInner SeparatorCrlf;
place:									SeparatorSlant placeInner SeparatorCrlf;
ssrDetail:								SeparatorSlant specialServiceRequestInner SeparatorCrlf;
osiItems:								SeparatorSlant otherServiceInformationItem SeparatorCrlf;
sofr:									SeparatorSlant senderOfficeFileReference? senderParticipantIdentification?;
senderOfficeMessageAddress:				airportCityCode officeFunctionDesignator companyDesignator;
senderOfficeFileReference:				fileReference;
senderParticipantIdentification:		SeparatorSlant participantIdentifier SeparatorSlant participantCode SeparatorSlant airportCode;
supplementary1or2:						SeparatorSlant supplementaryShipmentInformation1? supplementaryShipmentInformation2?;
supplementaryShipmentInformation1:		innerSupplementaryShipmentInformation;
supplementaryShipmentInformation2:		SeparatorSlant innerSupplementaryShipmentInformation;
otherParticipantOfficeMessageAddress:	airportCityCode officeFunctionDesignator companyDesignator;
opofr:									SeparatorSlant otherParticipantOfficeFileReference? otherParticipantIdentification?;
otherParticipantOfficeFileReference:	fileReference;
otherParticipantIdentification:			SeparatorSlant participantIdentifier SeparatorSlant participantCode SeparatorSlant airportCityCode;



/** Parser bottom*/

standardMessageIdentifier:				A A A;
messageTypeVersionNumber:				N N? N?;
lineIdentifier:							A A A;
chargeCode:								A A;
airlinePrefix:							N N N;
awbSerialNumber:						N N N N N N N N;
airportCodeOfOrigin:					A A A;
airportCodeOfDestitation:				A A A;
shipmentDescriptionCode:				A;
volumeCode:								A A;
volumeAmount:							N+ (('.'| ',') N+)?;
densityIndicator:						A A;
densityGroupInner:						N N?;
declaredValueForCarriage:				N+ (('.'| ',') N+)?;
declaredValueForCustoms:				N+ (('.'| ',') N+)?;
amountOfInsurance:						N+ (('.'| ',') N+)?;
noValue:								A A A;
contactIdentifier:						(A | N) (A | N)? (A | N)?;
contactNumber:							(A | N)+;
iataCargoAgentNumericCode:				N N N N N N N;
cargoAgentCassAddressInner:				N N N N;
accountingInformationIdentifier:		A A A;
day:									N N;
month:									A A A;
year:									N N;
airportCode:							A A A;
flightNumber:							N N N N? A?;
carrierCode:							(A | N) (A | N);
serviceCode:							A;
uldType:								A (A | N) (A | N);
uldSerialNumber:						(A | N) N N N N?;
uldOwnerCode:							(A | N) (A | N);
slac:									N N? N? N? N?;
harmonisedCommodityCodeInner:			(A | N)+;
measurementUnitCode:					(A | N) (A | N)? (A | N)?;
lengthDimension:						N N? N? N? N?;
widthDimension:							N N? N? N? N?;
heightDimension:						N N? N? N? N?;
rateOrCharge:							N+ (('.'| ',') N+)?;
discount:								N+ (('.'| ',') N+)?;
commodityItemNumber:					N N N N N? N? N?;
uldRateClassType:						N A? A?;
rateClassCodeBasis:						A;
rateClassCode:							A;
classRatePercentage:					N N? N?;
weightCode:								A;
weight:									N+ (('.'| ',') N+)?;
rateCombinationPoint:					A A A;
numberOfPieces:							N N? N? N?;
hwbColumnIdentifier:					A;
hwbRateLineNumber:						N N?;
pcIndWeightValuation:					A;
pcIndOtherCharges:						A;
otherChargeCode:						A A;
entitlementCode:						A;
chargeIdentifier:						A A;
customsOriginCode:						(A | N) (A | N)?;
cassSettlementFactor:					N+ (('.'| ',') N+)?;
isoCurrencyCode:						A A A;
rateOfExchange:							N+ (('.'| ',') N+)?;
chargeAmount:							N+ (('.'| ',') N+)?;
cassIndicator:							A A?;
specialHandlingCode:					A A A;
airportCityCode:						A A A;
officeFunctionDesignator:				(A | N) (A | N);
companyDesignator:						(A | N) (A | N);
participantIdentifier:					(A | N) (A | N)? (A | N)?;
participantCode:						(A | N)+;
isoCountryCode:							A A;						
informationIdentifier:					A A A;
custSecurityAndRegulatCtrlInfoId:		A A?;
supplemCustSecurityAndRegulatCtrlInfo:	~SeparatorSlant+;
fileReference:							~SeparatorSlant+;
nameInner:								~SeparatorSlant+;
placeInner:								~SeparatorSlant+;
referenceNumber:						~SeparatorSlant+;
innerSupplementaryShipmentInformation:	~SeparatorSlant+;
signature:								~SeparatorSlant+;
otherServiceInformationItem:			~SeparatorSlant+;
specialServiceRequestInner:				~SeparatorSlant+;
accountingInformationInner:				~SeparatorSlant+;
accountNumber:							~SeparatorSlant+;
streetAddressInner:						~SeparatorSlant+;
stateProvinceInner:						~SeparatorSlant+;
postCodeInner:							~SeparatorSlant+;
natureAndQuantityOfGoods:				~SeparatorSlant+;



/*Lexer Rules*/

/**lexers*/
LineIdentifierSri:						'SRI';
LineIdentifierNom:						'NOM';
LineIdentifierSii:						'SII';
LineIdentifierPpd:						'PPD';
LineIdentifierCol:						'COL';

NamIdentifier:							'NAM';
AdrIdentifier:							'ADR';
LocIdentifier:							'LOC';

GoodsDescriptionIdentifier:				'/NG/';
ConsolidationIdentifier:				'/NC/';
DimensionsIdentifier:					'/ND/';
VolumeIdentifier:						'/NV/';
UldNumberIdentifier:					'/NU/';
ShippersLoadAndCountIdentifier:			'/NS/';
HarmonisedCommodityCodeIdentifier:		'/NH/';
CountryOfOriginOfGoodsIdentifier:		'/NO/';


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
