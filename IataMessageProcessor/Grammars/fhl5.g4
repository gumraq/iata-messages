// Определение грамматики телекса FHL
grammar fhl5;

/*Parser Rules*/

fhl5:									standardMessageIdentification masterAwbConsignmentDetail houseWaybills+ shipperNameAndAddress? consigneeNameAndAddress? chargeDeclarations?;

standardMessageIdentification:			standardMessageIdentifier SeparatorSlant messageTypeVersionNumber SeparatorCrlf;
masterAwbConsignmentDetail:				lineIdentifier SeparatorSlant masterAwbIdentification awbOriginAndDestination quantityDetail SeparatorCrlf;
houseWaybills:							houseWaybillSummaryDetails+ freeTextDescriptionOfGoods? harmonisedTariffScheduleInformation? otherCustSecurityAndRegulatCtrlInfo?;
shipperNameAndAddress:					ShpLineIdentifier name streetAddress location codedLocation contactDetail* SeparatorCrlf;
consigneeNameAndAddress:				CneLineIdentifier name streetAddress location codedLocation contactDetail* SeparatorCrlf;
chargeDeclarations:						lineIdentifier SeparatorSlant isoCurrencyCode SeparatorSlant prepaidCollectChargeDeclarations? SeparatorSlant valueForCarriageDeclaration SeparatorSlant valueForCustomsDeclaration SeparatorSlant valueForInsuranceDeclaration SeparatorCrlf;

/*Вспомогательные элементы*/

houseWaybillSummaryDetails:				HbsLineIdentifier hwbSerialNumber SeparatorSlant houseWaybillOriginAndDestination SeparatorSlant houseWaybillTotals natureOfGoods shrs? SeparatorCrlf;
freeTextDescriptionOfGoods:				lineIdentifier freeTextDescriptions+;
harmonisedTariffScheduleInformation:	lineIdentifier harmonisedTariffs+;
otherCustSecurityAndRegulatCtrlInfo:	lineIdentifier otherCustSecurityAndRegulatCtrlInfoDet+;
masterAwbIdentification:				airlinePrefix SeparatorHyphen awbSerialNumber;
awbOriginAndDestination:				airportCodeOfOrigin? airportCodeOfDestitation;
houseWaybillOriginAndDestination:		airportCodeOfOrigin? airportCodeOfDestitation;
houseWaybillTotals:						numberOfPieces SeparatorSlant weightCode weight SeparatorSlant slac?;
freeTextDescriptions:					SeparatorSlant freeText SeparatorCrlf;
harmonisedTariffs:						SeparatorSlant harmonisedCommodityCode SeparatorCrlf;
quantityDetail:							SeparatorSlant shipmentDescriptionCode numberOfPieces weightCode weight;
natureOfGoods:							SeparatorSlant manifestDescriptionOfGoods;
shrs:									SeparatorCrlf specialHandlingRequirements+;
name:									NamIdentifier nameDetail+;
nameDetail:								SeparatorSlant nameInner SeparatorCrlf;
location:								LocIdentifier SeparatorSlant placeInner stateProvince? SeparatorCrlf;
stateProvince:							SeparatorSlant stateProvinceInner;
codedLocation:							SeparatorSlant isoCountryCode postCode?;
postCode:								SeparatorSlant postCodeInner;
contactDetail:							SeparatorSlant contactIdentifier SeparatorSlant contactNumber;
streetAddress:							AdrIdentifier streetAddressDetail+;
streetAddressDetail:					SeparatorSlant streetAddressInner SeparatorCrlf;
valueForCarriageDeclaration:			declaredValueForCarriage | noValue;
valueForCustomsDeclaration:				declaredValueForCustoms | noValue;
valueForInsuranceDeclaration:			amountOfInsurance | noValue;
specialHandlingRequirements:			SeparatorSlant specialHandlingCode;
prepaidCollectChargeDeclarations:		pcIndWeightValuation pcIndOtherCharges;
otherCustSecurityAndRegulatCtrlInfoDet:	SeparatorSlant isoCountryCode? SeparatorSlant informationIdentifier? SeparatorSlant custSecurityAndRegulatCtrlInfoId? SeparatorSlant supplemCustSecurityAndRegulatCtrlInfo SeparatorCrlf;



/** Parser bottom*/

standardMessageIdentifier:				A A A;
messageTypeVersionNumber:				N N? N?;
lineIdentifier:							A A A;
hwbSerialNumber:						(A | N)+;
airlinePrefix:							N N N;
awbSerialNumber:						N N N N N N N N;
airportCodeOfOrigin:					A A A;
airportCodeOfDestitation:				A A A;
slac:									N+;
shipmentDescriptionCode:				A;
isoCurrencyCode:						A A A;
pcIndOtherCharges:						A;
contactIdentifier:						(A | N) (A | N)? (A | N)?;
contactNumber:							(A | N)+;
pcIndWeightValuation:					A;
declaredValueForCarriage:				N+ (('.'| ',') N+)?;
declaredValueForCustoms:				N+ (('.'| ',') N+)?;
amountOfInsurance:						N+ (('.'| ',') N+)?;
noValue:								A A A;
weightCode:								A;
weight:									N+ (('.'| ',') N+)?;
numberOfPieces:							N N? N? N?;
specialHandlingCode:					(A | N) (A | N) (A | N);
isoCountryCode:							A A;						
informationIdentifier:					A A A;
custSecurityAndRegulatCtrlInfoId:		A A?;
harmonisedCommodityCode:				(A | N)+;
freeText:								~(SeparatorSlant|SeparatorCrlf)+;
nameInner:								~(SeparatorSlant|SeparatorCrlf)+;
supplemCustSecurityAndRegulatCtrlInfo:	~(SeparatorSlant|SeparatorCrlf)+;
manifestDescriptionOfGoods:				~(SeparatorSlant|SeparatorCrlf)+;
streetAddressInner:						~(SeparatorSlant|SeparatorCrlf)+;
placeInner:								~(SeparatorSlant|SeparatorCrlf)+;
postCodeInner:							~(SeparatorSlant|SeparatorCrlf)+;
stateProvinceInner:						~(SeparatorSlant|SeparatorCrlf)+;


/*Lexer Rules*/

/**lexers*/
LineIdentifierSsr:						'SSR/';
LineIdentifierOsi:						'OSI/';
LineIdentifierUld:						'ULD/';

HbsLineIdentifier:						'HBS/';
ShpLineIdentifier:						'SHP' SeparatorCrlf;
CneLineIdentifier:						'CNE' SeparatorCrlf;
NamIdentifier:							'NAM';
AdrIdentifier:							'ADR';
LocIdentifier:							'LOC';
HarmonisedCommodityCodeIdentifier:		'/NH/';

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
