//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from fhl5.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="fhl5Parser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public interface Ifhl5Visitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.fhl5"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFhl5([NotNull] fhl5Parser.Fhl5Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.standardMessageIdentification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStandardMessageIdentification([NotNull] fhl5Parser.StandardMessageIdentificationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.masterAwbConsignmentDetail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMasterAwbConsignmentDetail([NotNull] fhl5Parser.MasterAwbConsignmentDetailContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.houseWaybills"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHouseWaybills([NotNull] fhl5Parser.HouseWaybillsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.shipperNameAndAddress"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShipperNameAndAddress([NotNull] fhl5Parser.ShipperNameAndAddressContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.consigneeNameAndAddress"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConsigneeNameAndAddress([NotNull] fhl5Parser.ConsigneeNameAndAddressContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.chargeDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChargeDeclarations([NotNull] fhl5Parser.ChargeDeclarationsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.houseWaybillSummaryDetails"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHouseWaybillSummaryDetails([NotNull] fhl5Parser.HouseWaybillSummaryDetailsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.freeTextDescriptionOfGoods"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFreeTextDescriptionOfGoods([NotNull] fhl5Parser.FreeTextDescriptionOfGoodsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.harmonisedTariffScheduleInformation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHarmonisedTariffScheduleInformation([NotNull] fhl5Parser.HarmonisedTariffScheduleInformationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.otherCustSecurityAndRegulatCtrlInfo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOtherCustSecurityAndRegulatCtrlInfo([NotNull] fhl5Parser.OtherCustSecurityAndRegulatCtrlInfoContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.masterAwbIdentification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMasterAwbIdentification([NotNull] fhl5Parser.MasterAwbIdentificationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.awbOriginAndDestination"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAwbOriginAndDestination([NotNull] fhl5Parser.AwbOriginAndDestinationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.houseWaybillOriginAndDestination"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHouseWaybillOriginAndDestination([NotNull] fhl5Parser.HouseWaybillOriginAndDestinationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.houseWaybillTotals"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHouseWaybillTotals([NotNull] fhl5Parser.HouseWaybillTotalsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.freeTextDescriptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFreeTextDescriptions([NotNull] fhl5Parser.FreeTextDescriptionsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.harmonisedTariffs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHarmonisedTariffs([NotNull] fhl5Parser.HarmonisedTariffsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.quantityDetail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuantityDetail([NotNull] fhl5Parser.QuantityDetailContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.natureOfGoods"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNatureOfGoods([NotNull] fhl5Parser.NatureOfGoodsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.shrs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShrs([NotNull] fhl5Parser.ShrsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitName([NotNull] fhl5Parser.NameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.nameDetail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNameDetail([NotNull] fhl5Parser.NameDetailContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.location"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLocation([NotNull] fhl5Parser.LocationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.stateProvince"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStateProvince([NotNull] fhl5Parser.StateProvinceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.codedLocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCodedLocation([NotNull] fhl5Parser.CodedLocationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.postCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPostCode([NotNull] fhl5Parser.PostCodeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.contactDetail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitContactDetail([NotNull] fhl5Parser.ContactDetailContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.streetAddress"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStreetAddress([NotNull] fhl5Parser.StreetAddressContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.streetAddressDetail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStreetAddressDetail([NotNull] fhl5Parser.StreetAddressDetailContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.valueForCarriageDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValueForCarriageDeclaration([NotNull] fhl5Parser.ValueForCarriageDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.valueForCustomsDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValueForCustomsDeclaration([NotNull] fhl5Parser.ValueForCustomsDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.valueForInsuranceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValueForInsuranceDeclaration([NotNull] fhl5Parser.ValueForInsuranceDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.specialHandlingRequirements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSpecialHandlingRequirements([NotNull] fhl5Parser.SpecialHandlingRequirementsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.prepaidCollectChargeDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrepaidCollectChargeDeclarations([NotNull] fhl5Parser.PrepaidCollectChargeDeclarationsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.otherCustSecurityAndRegulatCtrlInfoDet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOtherCustSecurityAndRegulatCtrlInfoDet([NotNull] fhl5Parser.OtherCustSecurityAndRegulatCtrlInfoDetContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.standardMessageIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStandardMessageIdentifier([NotNull] fhl5Parser.StandardMessageIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.messageTypeVersionNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMessageTypeVersionNumber([NotNull] fhl5Parser.MessageTypeVersionNumberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.lineIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLineIdentifier([NotNull] fhl5Parser.LineIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.hwbSerialNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHwbSerialNumber([NotNull] fhl5Parser.HwbSerialNumberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.airlinePrefix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAirlinePrefix([NotNull] fhl5Parser.AirlinePrefixContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.awbSerialNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAwbSerialNumber([NotNull] fhl5Parser.AwbSerialNumberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.airportCodeOfOrigin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAirportCodeOfOrigin([NotNull] fhl5Parser.AirportCodeOfOriginContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.airportCodeOfDestitation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAirportCodeOfDestitation([NotNull] fhl5Parser.AirportCodeOfDestitationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.slac"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSlac([NotNull] fhl5Parser.SlacContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.shipmentDescriptionCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShipmentDescriptionCode([NotNull] fhl5Parser.ShipmentDescriptionCodeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.isoCurrencyCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsoCurrencyCode([NotNull] fhl5Parser.IsoCurrencyCodeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.pcIndOtherCharges"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPcIndOtherCharges([NotNull] fhl5Parser.PcIndOtherChargesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.contactIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitContactIdentifier([NotNull] fhl5Parser.ContactIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.contactNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitContactNumber([NotNull] fhl5Parser.ContactNumberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.pcIndWeightValuation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPcIndWeightValuation([NotNull] fhl5Parser.PcIndWeightValuationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.declaredValueForCarriage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclaredValueForCarriage([NotNull] fhl5Parser.DeclaredValueForCarriageContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.declaredValueForCustoms"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclaredValueForCustoms([NotNull] fhl5Parser.DeclaredValueForCustomsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.amountOfInsurance"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAmountOfInsurance([NotNull] fhl5Parser.AmountOfInsuranceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.noValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNoValue([NotNull] fhl5Parser.NoValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.weightCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWeightCode([NotNull] fhl5Parser.WeightCodeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.weight"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWeight([NotNull] fhl5Parser.WeightContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.numberOfPieces"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumberOfPieces([NotNull] fhl5Parser.NumberOfPiecesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.specialHandlingCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSpecialHandlingCode([NotNull] fhl5Parser.SpecialHandlingCodeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.isoCountryCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIsoCountryCode([NotNull] fhl5Parser.IsoCountryCodeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.informationIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInformationIdentifier([NotNull] fhl5Parser.InformationIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.custSecurityAndRegulatCtrlInfoId"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCustSecurityAndRegulatCtrlInfoId([NotNull] fhl5Parser.CustSecurityAndRegulatCtrlInfoIdContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.harmonisedCommodityCode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitHarmonisedCommodityCode([NotNull] fhl5Parser.HarmonisedCommodityCodeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.freeText"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFreeText([NotNull] fhl5Parser.FreeTextContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.nameInner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNameInner([NotNull] fhl5Parser.NameInnerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.supplemCustSecurityAndRegulatCtrlInfo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSupplemCustSecurityAndRegulatCtrlInfo([NotNull] fhl5Parser.SupplemCustSecurityAndRegulatCtrlInfoContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.manifestDescriptionOfGoods"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitManifestDescriptionOfGoods([NotNull] fhl5Parser.ManifestDescriptionOfGoodsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.streetAddressInner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStreetAddressInner([NotNull] fhl5Parser.StreetAddressInnerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.placeInner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPlaceInner([NotNull] fhl5Parser.PlaceInnerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.postCodeInner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPostCodeInner([NotNull] fhl5Parser.PostCodeInnerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="fhl5Parser.stateProvinceInner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStateProvinceInner([NotNull] fhl5Parser.StateProvinceInnerContext context);
}