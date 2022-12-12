using IataMessageStandard;
using IataMessageStandard.Fwb17Parts;

namespace IataMessageProcessor.Formatters.TextMessages
{
    public partial class TextMessageFormatter :
    #region inherits interfaces
    IVisitor<Fwb17, string>,
    IVisitor<StandardMessageIdentification, string>,
    IVisitor<AwbConsignmentDetail, string>,
    IVisitor<FlightBookings, string>,
    IVisitor<Routing, string>,
    IVisitor<Shipper, string>,
    IVisitor<Consignee, string>,
    IVisitor<Agent, string>,
    IVisitor<SpecialServiceRequest, string>,
    IVisitor<AlsoNotify, string>,
    IVisitor<AccountingInformation, string>,
    IVisitor<ChargeDeclarations, string>,
    IVisitor<RateDescription, string>,
    IVisitor<OtherCharges, string>,
    IVisitor<PrepaidChargeSummary, string>,
    IVisitor<CollectChargeSummary, string>,
    IVisitor<ShippersCertification, string>,
    IVisitor<CarriersExecution, string>,
    IVisitor<OtherServiceInformation, string>,
    IVisitor<CcChargesInDestinationCurrency, string>,
    IVisitor<SenderReference, string>,
    IVisitor<CustomsOrigin, string>,
    IVisitor<CommissionInformation, string>,
    IVisitor<SalesIncentiveInformation, string>,
    IVisitor<AgentReferenceData, string>,
    IVisitor<SpecialHandlingDetails, string>,
    IVisitor<NominatedHandlingParty, string>,
    IVisitor<ShipmentReferenceInformation, string>,
    IVisitor<OtherParticipantInformation, string>,
    IVisitor<OtherCustSecurityAndRegulatCtrlInfo, string>,
    IVisitor<RateDescriptionItems, string>,
    IVisitor<ChargeLineCount, string>,
    IVisitor<ElementFrom3To10, string>,
    IVisitor<ElementFrom11To19, string>,
    IVisitor<NumberOfPiecesRcpDetails, string>,
    IVisitor<GrossWeightDetails, string>,
    IVisitor<RateClassDetails, string>,
    IVisitor<CommodityItemNumberDetails, string>,
    IVisitor<ChargeableWeightDetails, string>,
    IVisitor<RateChargeDetails, string>,
    IVisitor<TotalDetails, string>,
    IVisitor<GoodsDescription, string>,
    IVisitor<GoodsConsolidation, string>,
    IVisitor<Dimensions, string>,
    IVisitor<Volume, string>,
    IVisitor<UldNumber, string>,
    IVisitor<ShippersLoadAndCount, string>,
    IVisitor<HarmonisedCommodityCode, string>,
    IVisitor<CountryOfOriginOfGoods, string>,
    IVisitor<ServiceCodeDetails, string>,
    IVisitor<RateClassCodeBasisAndPercentage, string>,
    IVisitor<WeightInfo, string>,
    IVisitor<DimentionsDimNda, string>,
    IVisitor<Dimension, string>,
    IVisitor<AwbIdentification, string>,
    IVisitor<AwbOriginAndDestination, string>,
    IVisitor<QuantityDetail, string>,
    IVisitor<VolumeDetail, string>,
    IVisitor<DensityGroup, string>,
    IVisitor<SpecialHandlingRequirements, string>,
    IVisitor<FlightIdentification, string>,
    IVisitor<FirstDestinationCarrier, string>,
    IVisitor<OnwardDestinationCarrier, string>,
    IVisitor<PrepaidCollectChargeDeclarations, string>,
    IVisitor<ValueForCarriageDeclaration, string>,
    IVisitor<ValueForCustomsDeclaration, string>,
    IVisitor<ValueForInsuranceDeclaration, string>,
    IVisitor<OtherChargeDetails, string>,
    IVisitor<ChargeLine, string>,
    IVisitor<OtherChargeItems, string>,
    IVisitor<ChargesOrTaxes, string>,
    IVisitor<TotalCharges, string>,
    IVisitor<AwbIssueDetails, string>,
    IVisitor<Authorisation, string>,
    IVisitor<DestinationCurrency, string>,
    IVisitor<CurrencyConversionRate, string>,
    IVisitor<CcChargesInDestinationCurrencyInner, string>,
    IVisitor<ChargesAtDestination, string>,
    IVisitor<TotalCollectCharges, string>,
    IVisitor<NoCommissionIndication, string>,
    IVisitor<CommissionAmountOrPercentage, string>,
    IVisitor<CommissionAmount, string>,
    IVisitor<CommissionPercentage, string>,
    IVisitor<SalesIncentiveDetail, string>,
    IVisitor<SalesIncentiveIndication, string>,
    IVisitor<AgentReference, string>,
    IVisitor<OtherCustSecurityAndRegulatCtrlInfoDet, string>,
    IVisitor<AccountDetail, string>,
    IVisitor<Name, string>,
    IVisitor<NameDetail, string>,
    IVisitor<StreetAddress, string>,
    IVisitor<StreetAddressDetail, string>,
    IVisitor<Location, string>,
    IVisitor<StateProvince, string>,
    IVisitor<CodedLocation, string>,
    IVisitor<PostCode, string>,
    IVisitor<ContactDetail, string>,
    IVisitor<AccountDetailAgt, string>,
    IVisitor<CargoAgentCassOrParticipantId, string>,
    IVisitor<ParticipantId, string>,
    IVisitor<CargoAgentCassAddress, string>,
    IVisitor<AccountDetails, string>,
    IVisitor<Place, string>,
    IVisitor<SsrDetail, string>,
    IVisitor<OsiItems, string>,
    IVisitor<Sofr, string>,
    IVisitor<SenderOfficeMessageAddress, string>,
    IVisitor<SenderOfficeFileReference, string>,
    IVisitor<SenderParticipantIdentification, string>,
    IVisitor<Supplementary1or2, string>,
    IVisitor<SupplementaryShipmentInformation1, string>,
    IVisitor<SupplementaryShipmentInformation2, string>,
    IVisitor<OtherParticipantOfficeMessageAddress, string>,
    IVisitor<Opofr, string>,
    IVisitor<OtherParticipantOfficeFileReference, string>,
    IVisitor<OtherParticipantIdentification, string>
    #endregion

    {
        public string Visit(Fwb17 e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.StandardMessageIdentification)}{this.Visit(e.AwbConsignmentDetail)}{this.Visit(e.FlightBookings)}{this.Visit(e.Routing)}{this.Visit(e.Shipper)}{this.Visit(e.Consignee)}{this.Visit(e.Agent)}{this.Visit(e.SpecialServiceRequest)}{this.Visit(e.AlsoNotify)}{this.Visit(e.AccountingInformation)}{this.Visit(e.ChargeDeclarations)}{this.Visit(e.RateDescription)}{this.Visit(e.OtherCharges)}{this.Visit(e.PrepaidChargeSummary)}{this.Visit(e.CollectChargeSummary)}{this.Visit(e.ShippersCertification)}{this.Visit(e.CarriersExecution)}{this.Visit(e.OtherServiceInformation)}{this.Visit(e.CcChargesInDestinationCurrency)}{this.Visit(e.SenderReference)}{this.Visit(e.CustomsOrigin)}{this.Visit(e.CommissionInformation)}{this.Visit(e.SalesIncentiveInformation)}{this.Visit(e.AgentReferenceData)}{this.Visit(e.SpecialHandlingDetails)}{this.Visit(e.NominatedHandlingParty)}{this.Visit(e.ShipmentReferenceInformation)}{string.Join(string.Empty, e.OtherParticipantInformation?.Select(this.Visit) ?? Enumerable.Empty<string>())}{this.Visit(e.OtherCustSecurityAndRegulatCtrlInfo)}";
        }

        public string Visit(StandardMessageIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.StandardMessageIdentifier}{sSlant}{e.MessageTypeVersionNumber}{sCRLF}";
        }

        public string Visit(AwbConsignmentDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.AwbIdentification)}{this.Visit(e.AwbOriginAndDestination)}{this.Visit(e.QuantityDetail)}{this.Visit(e.VolumeDetail)}{this.Visit(e.DensityGroup)}{sCRLF}";
        }

        public string Visit(FlightBookings e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{string.Join(string.Empty, e.FlightIdentification?.Select(this.Visit) ?? Enumerable.Empty<string>())}{sCRLF}";
        }

        public string Visit(Routing e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{this.Visit(e.FirstDestinationCarrier)}{string.Join(string.Empty, e.OnwardDestinationCarrier?.Select(this.Visit) ?? Enumerable.Empty<string>())}{sCRLF}";
        }

        public string Visit(Shipper e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{this.Visit(e.AccountDetail)}{sCRLF}{this.Visit(e.Name)}{this.Visit(e.StreetAddress)}{this.Visit(e.Location)}{this.Visit(e.CodedLocation)}{string.Join(string.Empty, e.ContactDetail?.Select(this.Visit) ?? Enumerable.Empty<string>())}{sCRLF}";
        }

        public string Visit(Consignee e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{this.Visit(e.AccountDetail)}{sCRLF}{this.Visit(e.Name)}{this.Visit(e.StreetAddress)}{this.Visit(e.Location)}{this.Visit(e.CodedLocation)}{string.Join(string.Empty, e.ContactDetail?.Select(this.Visit) ?? Enumerable.Empty<string>())}{sCRLF}";
        }

        public string Visit(Agent e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{this.Visit(e.AccountDetailAgt)}{sCRLF}{this.Visit(e.NameDetail)}{this.Visit(e.Place)}";
        }

        public string Visit(SpecialServiceRequest e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{string.Join(string.Empty, e.SsrDetail?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }

        public string Visit(AlsoNotify e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{sCRLF}{this.Visit(e.Name)}{this.Visit(e.StreetAddress)}{this.Visit(e.Location)}{this.Visit(e.CodedLocation)}{string.Join(string.Empty, e.ContactDetail?.Select(this.Visit) ?? Enumerable.Empty<string>())}{sCRLF}";
        }

        public string Visit(AccountingInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{string.Join(string.Empty, e.AccountDetails?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }

        public string Visit(ChargeDeclarations e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{sSlant}{e.IsoCurrencyCode}{sSlant}{e.ChargeCode}{sSlant}{this.Visit(e.PrepaidCollectChargeDeclarations)}{sSlant}{this.Visit(e.ValueForCarriageDeclaration)}{sSlant}{this.Visit(e.ValueForCustomsDeclaration)}{sSlant}{this.Visit(e.ValueForInsuranceDeclaration)}{sCRLF}";
        }

        public string Visit(RateDescription e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{string.Join(string.Empty, e.RateDescriptionItems?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }

        public string Visit(OtherCharges e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{string.Join(string.Empty, e.OtherChargeDetails?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }

        public string Visit(PrepaidChargeSummary e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierPpd}{string.Join(string.Empty, e.ChargesOrTaxes?.Select(this.Visit) ?? Enumerable.Empty<string>())}{sCRLF}{string.Join(string.Empty, e.TotalCharges?.Select(this.Visit) ?? Enumerable.Empty<string>())}{sCRLF}";
        }

        public string Visit(CollectChargeSummary e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierCol}{string.Join(string.Empty, e.ChargesOrTaxes?.Select(this.Visit) ?? Enumerable.Empty<string>())}{sCRLF}{string.Join(string.Empty, e.TotalCharges?.Select(this.Visit) ?? Enumerable.Empty<string>())}{sCRLF}";
        }

        public string Visit(ShippersCertification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{sSlant}{e.Signature}{sCRLF}";
        }

        public string Visit(CarriersExecution e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{this.Visit(e.AwbIssueDetails)}{this.Visit(e.Authorisation)}{sCRLF}";
        }

        public string Visit(OtherServiceInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{string.Join(string.Empty, e.OsiItems?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }

        public string Visit(CcChargesInDestinationCurrency e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{sSlant}{this.Visit(e.DestinationCurrency)}{this.Visit(e.CurrencyConversionRate)}{sSlant}{this.Visit(e.CcChargesInDestinationCurrencyInner)}{sSlant}{this.Visit(e.ChargesAtDestination)}{sSlant}{this.Visit(e.TotalCollectCharges)}{sCRLF}";
        }

        public string Visit(SenderReference e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{sSlant}{this.Visit(e.SenderOfficeMessageAddress)}{this.Visit(e.Sofr)}{sCRLF}";
        }

        public string Visit(CustomsOrigin e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{sSlant}{e.CustomsOriginCode}{sCRLF}";
        }

        public string Visit(CommissionInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{sSlant}{this.Visit(e.NoCommissionIndication)}{this.Visit(e.CommissionAmountOrPercentage)}{sCRLF}";
        }

        public string Visit(SalesIncentiveInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierSii}{sSlant}{this.Visit(e.SalesIncentiveDetail)}{this.Visit(e.SalesIncentiveIndication)}{sCRLF}";
        }

        public string Visit(AgentReferenceData e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{sSlant}{this.Visit(e.AgentReference)}{sCRLF}";
        }

        public string Visit(SpecialHandlingDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{string.Join(string.Empty, e.SpecialHandlingRequirements?.Select(this.Visit) ?? Enumerable.Empty<string>())}{sCRLF}";
        }

        public string Visit(NominatedHandlingParty e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierNom}{sSlant}{e.NameInner}{sSlant}{e.PlaceInner}{sCRLF}";
        }

        public string Visit(ShipmentReferenceInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierSri}{sSlant}{e.ReferenceNumber}{this.Visit(e.Supplementary1or2)}{sCRLF}";
        }

        public string Visit(OtherParticipantInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{sSlant}{e.NameInner}{sCRLF}{sSlant}{this.Visit(e.OtherParticipantOfficeMessageAddress)}{this.Visit(e.Opofr)}{sCRLF}";
        }

        public string Visit(OtherCustSecurityAndRegulatCtrlInfo e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{string.Join(string.Empty, e.OtherCustSecurityAndRegulatCtrlInfoDet?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }

        public string Visit(RateDescriptionItems e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.ChargeLineCount)}{this.Visit(e.ElementFrom3To10)}{this.Visit(e.ElementFrom11To19)}";
        }

        public string Visit(ChargeLineCount e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.HwbRateLineNumber}";
        }

        public string Visit(ElementFrom3To10 e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.NumberOfPiecesRcpDetails)}{this.Visit(e.GrossWeightDetails)}{this.Visit(e.RateClassDetails)}{this.Visit(e.CommodityItemNumberDetails)}{this.Visit(e.ChargeableWeightDetails)}{this.Visit(e.RateChargeDetails)}{this.Visit(e.TotalDetails)}{sCRLF}";
        }

        public string Visit(ElementFrom11To19 e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.GoodsDescription)}{this.Visit(e.GoodsConsolidation)}{this.Visit(e.Dimensions)}{this.Visit(e.Volume)}{this.Visit(e.UldNumber)}{this.Visit(e.ShippersLoadAndCount)}{this.Visit(e.HarmonisedCommodityCode)}{this.Visit(e.CountryOfOriginOfGoods)}{this.Visit(e.ServiceCodeDetails)}{sCRLF}";
        }

        public string Visit(NumberOfPiecesRcpDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.HwbColumnIdentifier}{e.NumberOfPieces}{e.RateCombinationPoint}";
        }

        public string Visit(GrossWeightDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.WeightInfo)}";
        }

        public string Visit(RateClassDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.HwbColumnIdentifier}{e.RateClassCode}";
        }

        public string Visit(CommodityItemNumberDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.HwbColumnIdentifier}{e.CommodityItemNumber}{e.UldRateClassType}{this.Visit(e.RateClassCodeBasisAndPercentage)}";
        }

        public string Visit(ChargeableWeightDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.HwbColumnIdentifier}{e.Weight}";
        }

        public string Visit(RateChargeDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.HwbColumnIdentifier}{e.RateOrCharge}{e.Discount}";
        }

        public string Visit(TotalDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.HwbColumnIdentifier}{e.ChargeAmount}{e.Discount}";
        }

        public string Visit(GoodsDescription e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.GoodsDescriptionIdentifier}{e.NatureAndQuantityOfGoods}";
        }

        public string Visit(GoodsConsolidation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.ConsolidationIdentifier}{e.NatureAndQuantityOfGoods}";
        }

        public string Visit(Dimensions e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DimensionsIdentifier}{this.Visit(e.WeightInfo)}{sSlant}{this.Visit(e.DimentionsDimNda)}";
        }

        public string Visit(Volume e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.VolumeIdentifier}{e.VolumeCode}{e.VolumeAmount}";
        }

        public string Visit(UldNumber e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.UldNumberIdentifier}{e.UldType}{e.UldSerialNumber}{e.UldOwnerCode}";
        }

        public string Visit(ShippersLoadAndCount e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.ShippersLoadAndCountIdentifier}{e.Slac}";
        }

        public string Visit(HarmonisedCommodityCode e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.HarmonisedCommodityCodeIdentifier}{e.HarmonisedCommodityCodeInner}";
        }

        public string Visit(CountryOfOriginOfGoods e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.CountryOfOriginOfGoodsIdentifier}{e.IsoCountryCode}";
        }

        public string Visit(ServiceCodeDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.ServiceCode}";
        }

        public string Visit(RateClassCodeBasisAndPercentage e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.RateClassCodeBasis}{e.ClassRatePercentage}";
        }

        public string Visit(WeightInfo e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.WeightCode}{e.Weight}";
        }

        public string Visit(DimentionsDimNda e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.MeasurementUnitCode}{this.Visit(e.Dimension)}";
        }

        public string Visit(Dimension e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LengthDimension}{sHyphen}{e.WidthDimension}{sHyphen}{e.HeightDimension}{sSlant}{e.NumberOfPieces}";
        }

        public string Visit(AwbIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.AirlinePrefix}{sHyphen}{e.AwbSerialNumber}";
        }

        public string Visit(AwbOriginAndDestination e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.AirportCodeOfOrigin}{e.AirportCodeOfDestitation}";
        }

        public string Visit(QuantityDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.ShipmentDescriptionCode}{e.NumberOfPieces}{e.WeightCode}{e.Weight}";
        }

        public string Visit(VolumeDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.VolumeCode}{e.VolumeAmount}";
        }

        public string Visit(DensityGroup e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DensityIndicator}{e.DensityGroupInner}";
        }

        public string Visit(SpecialHandlingRequirements e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.SpecialHandlingCode}";
        }

        public string Visit(FlightIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.CarrierCode}{e.FlightNumber}{sSlant}{e.Day}";
        }

        public string Visit(FirstDestinationCarrier e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.AirportCode}{e.CarrierCode}";
        }

        public string Visit(OnwardDestinationCarrier e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.AirportCode}{e.CarrierCode}";
        }

        public string Visit(PrepaidCollectChargeDeclarations e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.PcIndWeightValuation}{e.PcIndOtherCharges}";
        }

        public string Visit(ValueForCarriageDeclaration e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DeclaredValueForCarriage}{e.NoValue}";
        }

        public string Visit(ValueForCustomsDeclaration e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DeclaredValueForCustoms}{e.NoValue}";
        }

        public string Visit(ValueForInsuranceDeclaration e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.AmountOfInsurance}{e.NoValue}";
        }

        public string Visit(OtherChargeDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.ChargeLine)}{string.Join(string.Empty, e.OtherChargeItems?.Select(this.Visit) ?? Enumerable.Empty<string>())}{sCRLF}";
        }

        public string Visit(ChargeLine e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.PcIndOtherCharges}{sSlant}";
        }

        public string Visit(OtherChargeItems e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.OtherChargeCode}{e.EntitlementCode}{e.ChargeAmount}";
        }

        public string Visit(ChargesOrTaxes e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.ChargeIdentifier}{e.ChargeAmount}";
        }

        public string Visit(TotalCharges e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.ChargeIdentifier}{e.ChargeAmount}";
        }

        public string Visit(AwbIssueDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.Day}{e.Month}{e.Year}{sSlant}{e.PlaceInner}{e.AirportCityCode}";
        }

        public string Visit(Authorisation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.Signature}";
        }

        public string Visit(DestinationCurrency e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.IsoCurrencyCode}";
        }

        public string Visit(CurrencyConversionRate e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.RateOfExchange}";
        }

        public string Visit(CcChargesInDestinationCurrencyInner e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.ChargeAmount}";
        }

        public string Visit(ChargesAtDestination e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.ChargeAmount}";
        }

        public string Visit(TotalCollectCharges e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.ChargeAmount}";
        }

        public string Visit(NoCommissionIndication e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.CassIndicator}";
        }

        public string Visit(CommissionAmountOrPercentage e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.CommissionAmount)}{this.Visit(e.CommissionPercentage)}";
        }

        public string Visit(CommissionAmount e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.CassSettlementFactor}";
        }

        public string Visit(CommissionPercentage e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.CassSettlementFactor}";
        }

        public string Visit(SalesIncentiveDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.ChargeAmount}";
        }

        public string Visit(SalesIncentiveIndication e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.CassIndicator}";
        }

        public string Visit(AgentReference e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.FileReference}";
        }

        public string Visit(OtherCustSecurityAndRegulatCtrlInfoDet e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.IsoCountryCode}{sSlant}{e.InformationIdentifier}{sSlant}{e.CustSecurityAndRegulatCtrlInfoId}{sSlant}{e.SupplemCustSecurityAndRegulatCtrlInfo}{sCRLF}";
        }

        public string Visit(AccountDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.AccountNumber}";
        }

        public string Visit(Name e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.NamIdentifier}{string.Join(string.Empty, e.NameDetail?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }

        public string Visit(NameDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.NameInner}{sCRLF}";
        }

        public string Visit(StreetAddress e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.AdrIdentifier}{string.Join(string.Empty, e.StreetAddressDetail?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }

        public string Visit(StreetAddressDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.StreetAddressInner}{sCRLF}";
        }

        public string Visit(Location e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LocIdentifier}{sSlant}{e.PlaceInner}{this.Visit(e.StateProvince)}{sCRLF}";
        }

        public string Visit(StateProvince e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.StateProvinceInner}";
        }

        public string Visit(CodedLocation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.IsoCountryCode}{this.Visit(e.PostCode)}";
        }

        public string Visit(PostCode e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.PostCodeInner}";
        }

        public string Visit(ContactDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.ContactIdentifier}{sSlant}{e.ContactNumber}";
        }

        public string Visit(AccountDetailAgt e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.AccountNumber}{sSlant}{e.IataCargoAgentNumericCode}{this.Visit(e.CargoAgentCassOrParticipantId)}";
        }

        public string Visit(CargoAgentCassOrParticipantId e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.CargoAgentCassAddress)}{this.Visit(e.ParticipantId)}";
        }

        public string Visit(ParticipantId e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.ParticipantIdentifier}";
        }

        public string Visit(CargoAgentCassAddress e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.CargoAgentCassAddressInner}";
        }

        public string Visit(AccountDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.AccountingInformationIdentifier}{sSlant}{e.AccountingInformationInner}{sCRLF}";
        }

        public string Visit(Place e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.PlaceInner}{sCRLF}";
        }

        public string Visit(SsrDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.SpecialServiceRequestInner}{sCRLF}";
        }

        public string Visit(OsiItems e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.OtherServiceInformationItem}{sCRLF}";
        }

        public string Visit(Sofr e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.SenderOfficeFileReference)}{this.Visit(e.SenderParticipantIdentification)}";
        }

        public string Visit(SenderOfficeMessageAddress e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.AirportCityCode}{e.OfficeFunctionDesignator}{e.CompanyDesignator}";
        }

        public string Visit(SenderOfficeFileReference e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.FileReference}";
        }

        public string Visit(SenderParticipantIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.ParticipantIdentifier}{sSlant}{e.ParticipantCode}{sSlant}{e.AirportCode}";
        }

        public string Visit(Supplementary1or2 e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.SupplementaryShipmentInformation1)}{this.Visit(e.SupplementaryShipmentInformation2)}";
        }

        public string Visit(SupplementaryShipmentInformation1 e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.InnerSupplementaryShipmentInformation}";
        }

        public string Visit(SupplementaryShipmentInformation2 e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.InnerSupplementaryShipmentInformation}";
        }

        public string Visit(OtherParticipantOfficeMessageAddress e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.AirportCityCode}{e.OfficeFunctionDesignator}{e.CompanyDesignator}";
        }

        public string Visit(Opofr e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.OtherParticipantOfficeFileReference)}{this.Visit(e.OtherParticipantIdentification)}";
        }

        public string Visit(OtherParticipantOfficeFileReference e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.FileReference}";
        }

        public string Visit(OtherParticipantIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.ParticipantIdentifier}{sSlant}{e.ParticipantCode}{sSlant}{e.AirportCityCode}";
        }
    }
}
