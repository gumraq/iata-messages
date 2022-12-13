namespace IataMessageStandard.Fwb17Parts
{
    [SeparatorCrlf]
    public class StandardMessageIdentification
    {
        [Reference(1)]
        public string StandardMessageIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string MessageTypeVersionNumber { get; set;  }
    }

    [SeparatorCrlf]
    public class AwbConsignmentDetail
    {
        [Reference(1)]
        public AwbIdentification AwbIdentification { get; set; }

        [Reference(2)]
        public AwbOriginAndDestination AwbOriginAndDestination { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public VolumeDetail VolumeDetail { get; set; }

        [Reference(5)]
        public DensityGroup DensityGroup { get; set; }
    }

    [SeparatorCrlf]
    public class FlightBookings
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public List<FlightIdentification> FlightIdentification { get; set; }
    }

    [SeparatorCrlf]
    public class Routing
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public FirstDestinationCarrier FirstDestinationCarrier { get; set; }

        [Reference(3)]
        public List<OnwardDestinationCarrier> OnwardDestinationCarrier { get; set; }
    }

    [SeparatorCrlf]
    public class Shipper
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public AccountDetail AccountDetail { get; set; }

        [Reference(3)]
        [SeparatorCrlf]
        public Name Name { get; set; }

        [Reference(4)]
        public StreetAddress StreetAddress { get; set; }

        [Reference(5)]
        public Location Location { get; set; }

        [Reference(6)]
        public CodedLocation CodedLocation { get; set; }

        [Reference(7)]
        public List<ContactDetail> ContactDetail { get; set; }
    }

    [SeparatorCrlf]
    public class Consignee
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public AccountDetail AccountDetail { get; set; }

        [Reference(3)]
        [SeparatorCrlf]
        public Name Name { get; set; }

        [Reference(4)]
        public StreetAddress StreetAddress { get; set; }

        [Reference(5)]
        public Location Location { get; set; }

        [Reference(6)]
        public CodedLocation CodedLocation { get; set; }

        [Reference(7)]
        public List<ContactDetail> ContactDetail { get; set; }
    }

    public class Agent
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public AccountDetailAgt AccountDetailAgt { get; set; }

        [Reference(3)]
        [SeparatorCrlf]
        public NameDetail NameDetail { get; set; }

        [Reference(4)]
        public Place Place { get; set; }
    }

    public class SpecialServiceRequest
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public List<SsrDetail> SsrDetail { get; set; }
    }

    [SeparatorCrlf]
    public class AlsoNotify
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorCrlf]
        public Name Name { get; set; }

        [Reference(3)]
        public StreetAddress StreetAddress { get; set; }

        [Reference(4)]
        public Location Location { get; set; }

        [Reference(5)]
        public CodedLocation CodedLocation { get; set; }

        [Reference(6)]
        public List<ContactDetail> ContactDetail { get; set; }
    }

    public class AccountingInformation
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public List<AccountDetails> AccountDetails { get; set; }
    }

    [SeparatorCrlf]
    public class ChargeDeclarations
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string IsoCurrencyCode { get; set;  }

        [Reference(3)]
        [SeparatorSlant]
        public string ChargeCode { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public PrepaidCollectChargeDeclarations PrepaidCollectChargeDeclarations { get; set; }

        [Reference(5)]
        [SeparatorSlant]
        public ValueForCarriageDeclaration ValueForCarriageDeclaration { get; set; }

        [Reference(6)]
        [SeparatorSlant]
        public ValueForCustomsDeclaration ValueForCustomsDeclaration { get; set; }

        [Reference(7)]
        [SeparatorSlant]
        public ValueForInsuranceDeclaration ValueForInsuranceDeclaration { get; set; }
    }

    public class RateDescription
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public List<RateDescriptionItems> RateDescriptionItems { get; set; }
    }

    public class OtherCharges
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public List<OtherChargeDetails> OtherChargeDetails { get; set; }
    }

    [SeparatorCrlf]
    public class PrepaidChargeSummary
    {
        [Reference(1)]
        public string LineIdentifierPpd { get {return "PPD";} }

        [Reference(2)]
        public List<ChargesOrTaxes> ChargesOrTaxes { get; set; }

        [Reference(3)]
        [SeparatorCrlf]
        public List<TotalCharges> TotalCharges { get; set; }
    }

    [SeparatorCrlf]
    public class CollectChargeSummary
    {
        [Reference(1)]
        public string LineIdentifierCol { get {return "COL";} }

        [Reference(2)]
        public List<ChargesOrTaxes> ChargesOrTaxes { get; set; }

        [Reference(3)]
        [SeparatorCrlf]
        public List<TotalCharges> TotalCharges { get; set; }
    }

    [SeparatorCrlf]
    public class ShippersCertification
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string Signature { get; set;  }
    }

    [SeparatorCrlf]
    public class CarriersExecution
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public AwbIssueDetails AwbIssueDetails { get; set; }

        [Reference(3)]
        public Authorisation Authorisation { get; set; }
    }

    public class OtherServiceInformation
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public List<OsiItems> OsiItems { get; set; }
    }

    [SeparatorCrlf]
    public class CcChargesInDestinationCurrency
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public DestinationCurrency DestinationCurrency { get; set; }

        [Reference(3)]
        public CurrencyConversionRate CurrencyConversionRate { get; set; }

        [Reference(4)]
        [SeparatorSlant]
        public CcChargesInDestinationCurrencyInner CcChargesInDestinationCurrencyInner { get; set; }

        [Reference(5)]
        [SeparatorSlant]
        public ChargesAtDestination ChargesAtDestination { get; set; }

        [Reference(6)]
        [SeparatorSlant]
        public TotalCollectCharges TotalCollectCharges { get; set; }
    }

    [SeparatorCrlf]
    public class SenderReference
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public SenderOfficeMessageAddress SenderOfficeMessageAddress { get; set; }

        [Reference(3)]
        public Sofr Sofr { get; set; }
    }

    [SeparatorCrlf]
    public class CustomsOrigin
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string CustomsOriginCode { get; set;  }
    }

    [SeparatorCrlf]
    public class CommissionInformation
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public NoCommissionIndication NoCommissionIndication { get; set; }

        [Reference(3)]
        public CommissionAmountOrPercentage CommissionAmountOrPercentage { get; set; }
    }

    [SeparatorCrlf]
    public class SalesIncentiveInformation
    {
        [Reference(1)]
        public string LineIdentifierSii { get {return "SII";} }

        [Reference(2)]
        [SeparatorSlant]
        public SalesIncentiveDetail SalesIncentiveDetail { get; set; }

        [Reference(3)]
        public SalesIncentiveIndication SalesIncentiveIndication { get; set; }
    }

    [SeparatorCrlf]
    public class AgentReferenceData
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public AgentReference AgentReference { get; set; }
    }

    [SeparatorCrlf]
    public class SpecialHandlingDetails
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public List<SpecialHandlingRequirements> SpecialHandlingRequirements { get; set; }
    }

    [SeparatorCrlf]
    public class NominatedHandlingParty
    {
        [Reference(1)]
        public string LineIdentifierNom { get {return "NOM";} }

        [Reference(2)]
        [SeparatorSlant]
        public string NameInner { get; set;  }

        [Reference(3)]
        [SeparatorSlant]
        public string PlaceInner { get; set;  }
    }

    [SeparatorCrlf]
    public class ShipmentReferenceInformation
    {
        [Reference(1)]
        public string LineIdentifierSri { get {return "SRI";} }

        [Reference(2)]
        [SeparatorSlant]
        public string ReferenceNumber { get; set;  }

        [Reference(3)]
        public Supplementary1or2 Supplementary1or2 { get; set; }
    }

    [SeparatorCrlf]
    public class OtherParticipantInformation
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string NameInner { get; set;  }

        [Reference(3)]
        [SeparatorCrlf]
        [SeparatorSlant]
        public OtherParticipantOfficeMessageAddress OtherParticipantOfficeMessageAddress { get; set; }

        [Reference(4)]
        public Opofr Opofr { get; set; }
    }

    public class OtherCustSecurityAndRegulatCtrlInfo
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public List<OtherCustSecurityAndRegulatCtrlInfoDet> OtherCustSecurityAndRegulatCtrlInfoDet { get; set; }
    }

    public class RateDescriptionItems
    {
        [Reference(1)]
        public ChargeLineCount ChargeLineCount { get; set; }

        [Reference(2)]
        public ElementFrom3To10 ElementFrom3To10 { get; set; }

        [Reference(3)]
        public ElementFrom11To19 ElementFrom11To19 { get; set; }
    }

    public class ChargeLineCount
    {
        [SeparatorSlant]
        public string HwbRateLineNumber { get; set;  }
    }

    [SeparatorCrlf]
    public class ElementFrom3To10
    {
        [Reference(1)]
        public NumberOfPiecesRcpDetails NumberOfPiecesRcpDetails { get; set; }

        [Reference(2)]
        public GrossWeightDetails GrossWeightDetails { get; set; }

        [Reference(3)]
        public RateClassDetails RateClassDetails { get; set; }

        [Reference(4)]
        public CommodityItemNumberDetails CommodityItemNumberDetails { get; set; }

        [Reference(5)]
        public ChargeableWeightDetails ChargeableWeightDetails { get; set; }

        [Reference(6)]
        public RateChargeDetails RateChargeDetails { get; set; }

        [Reference(7)]
        public TotalDetails TotalDetails { get; set; }
    }

    [SeparatorCrlf]
    public class ElementFrom11To19
    {
        [Reference(1)]
        public GoodsDescription GoodsDescription { get; set; }

        [Reference(2)]
        public GoodsConsolidation GoodsConsolidation { get; set; }

        [Reference(3)]
        public Dimensions Dimensions { get; set; }

        [Reference(4)]
        public Volume Volume { get; set; }

        [Reference(5)]
        public UldNumber UldNumber { get; set; }

        [Reference(6)]
        public ShippersLoadAndCount ShippersLoadAndCount { get; set; }

        [Reference(7)]
        public HarmonisedCommodityCode HarmonisedCommodityCode { get; set; }

        [Reference(8)]
        public CountryOfOriginOfGoods CountryOfOriginOfGoods { get; set; }

        [Reference(9)]
        public ServiceCodeDetails ServiceCodeDetails { get; set; }
    }

    public class NumberOfPiecesRcpDetails
    {
        [Reference(1)]
        [SeparatorSlant]
        public string HwbColumnIdentifier { get; set;  }

        [Reference(2)]
        public string NumberOfPieces { get; set;  }

        [Reference(3)]
        public string RateCombinationPoint { get; set;  }
    }

    public class GrossWeightDetails
    {
        [SeparatorSlant]
        public WeightInfo WeightInfo { get; set; }
    }

    public class RateClassDetails
    {
        [Reference(1)]
        [SeparatorSlant]
        public string HwbColumnIdentifier { get; set;  }

        [Reference(2)]
        public string RateClassCode { get; set;  }
    }

    public class CommodityItemNumberDetails
    {
        [Reference(1)]
        [SeparatorSlant]
        public string HwbColumnIdentifier { get; set;  }

        [Reference(2)]
        public string CommodityItemNumber { get; set;  }

        [Reference(3)]
        public string UldRateClassType { get; set;  }

        [Reference(4)]
        public RateClassCodeBasisAndPercentage RateClassCodeBasisAndPercentage { get; set; }
    }

    public class ChargeableWeightDetails
    {
        [Reference(1)]
        [SeparatorSlant]
        public string HwbColumnIdentifier { get; set;  }

        [Reference(2)]
        public string Weight { get; set;  }
    }

    public class RateChargeDetails
    {
        [Reference(1)]
        [SeparatorSlant]
        public string HwbColumnIdentifier { get; set;  }

        [Reference(2)]
        public string RateOrCharge { get; set;  }

        [Reference(3)]
        public string Discount { get; set;  }
    }

    public class TotalDetails
    {
        [Reference(1)]
        [SeparatorSlant]
        public string HwbColumnIdentifier { get; set;  }

        [Reference(2)]
        public string ChargeAmount { get; set;  }

        [Reference(3)]
        public string Discount { get; set;  }
    }

    public class GoodsDescription
    {
        [Reference(1)]
        public string GoodsDescriptionIdentifier { get {return "/NG/";} }

        [Reference(2)]
        public string NatureAndQuantityOfGoods { get; set;  }
    }

    public class GoodsConsolidation
    {
        [Reference(1)]
        public string ConsolidationIdentifier { get {return "/NC/";} }

        [Reference(2)]
        public string NatureAndQuantityOfGoods { get; set;  }
    }

    public class Dimensions
    {
        [Reference(1)]
        public string DimensionsIdentifier { get {return "/ND/";} }

        [Reference(2)]
        public WeightInfo WeightInfo { get; set; }

        [Reference(3)]
        [SeparatorSlant]
        public DimentionsDimNda DimentionsDimNda { get; set; }
    }

    public class Volume
    {
        [Reference(1)]
        public string VolumeIdentifier { get {return "/NV/";} }

        [Reference(2)]
        public string VolumeCode { get; set;  }

        [Reference(3)]
        public string VolumeAmount { get; set;  }
    }

    public class UldNumber
    {
        [Reference(1)]
        public string UldNumberIdentifier { get {return "/NU/";} }

        [Reference(2)]
        public string UldType { get; set;  }

        [Reference(3)]
        public string UldSerialNumber { get; set;  }

        [Reference(4)]
        public string UldOwnerCode { get; set;  }
    }

    public class ShippersLoadAndCount
    {
        [Reference(1)]
        public string ShippersLoadAndCountIdentifier { get {return "/NS/";} }

        [Reference(2)]
        public string Slac { get; set;  }
    }

    public class HarmonisedCommodityCode
    {
        [Reference(1)]
        public string HarmonisedCommodityCodeIdentifier { get {return "/NH/";} }

        [Reference(2)]
        public string HarmonisedCommodityCodeInner { get; set;  }
    }

    public class CountryOfOriginOfGoods
    {
        [Reference(1)]
        public string CountryOfOriginOfGoodsIdentifier { get {return "/NO/";} }

        [Reference(2)]
        public string IsoCountryCode { get; set;  }
    }

    public class ServiceCodeDetails
    {
        [SeparatorSlant]
        public string ServiceCode { get; set;  }
    }

    public class RateClassCodeBasisAndPercentage
    {
        [Reference(1)]
        public string RateClassCodeBasis { get; set;  }

        [Reference(2)]
        public string ClassRatePercentage { get; set;  }
    }

    public class WeightInfo
    {
        [Reference(1)]
        public string WeightCode { get; set;  }

        [Reference(2)]
        public string Weight { get; set;  }
    }

    public class DimentionsDimNda
    {
        [Reference(1)]
        public string MeasurementUnitCode { get; set;  }

        [Reference(2)]
        public Dimension Dimension { get; set; }
    }

    public class Dimension
    {
        [Reference(1)]
        public string LengthDimension { get; set;  }

        [Reference(2)]
        [SeparatorHyphen]
        public string WidthDimension { get; set;  }

        [Reference(3)]
        [SeparatorHyphen]
        public string HeightDimension { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public string NumberOfPieces { get; set;  }
    }

    public class AwbIdentification
    {
        [Reference(1)]
        public string AirlinePrefix { get; set;  }

        [Reference(2)]
        [SeparatorHyphen]
        public string AwbSerialNumber { get; set;  }
    }

    public class AwbOriginAndDestination
    {
        [Reference(1)]
        public string AirportCodeOfOrigin { get; set;  }

        [Reference(2)]
        public string AirportCodeOfDestitation { get; set;  }
    }

    public class QuantityDetail
    {
        [Reference(1)]
        [SeparatorSlant]
        public string ShipmentDescriptionCode { get; set;  }

        [Reference(2)]
        public string NumberOfPieces { get; set;  }

        [Reference(3)]
        public string WeightCode { get; set;  }

        [Reference(4)]
        public string Weight { get; set;  }
    }

    public class VolumeDetail
    {
        [Reference(1)]
        public string VolumeCode { get; set;  }

        [Reference(2)]
        public string VolumeAmount { get; set;  }
    }

    public class DensityGroup
    {
        [Reference(1)]
        public string DensityIndicator { get; set;  }

        [Reference(2)]
        public string DensityGroupInner { get; set;  }
    }

    public class SpecialHandlingRequirements
    {
        [SeparatorSlant]
        public string SpecialHandlingCode { get; set;  }
    }

    public class FlightIdentification
    {
        [Reference(1)]
        [SeparatorSlant]
        public string CarrierCode { get; set;  }

        [Reference(2)]
        public string FlightNumber { get; set;  }

        [Reference(3)]
        [SeparatorSlant]
        public string Day { get; set;  }
    }

    public class FirstDestinationCarrier
    {
        [Reference(1)]
        [SeparatorSlant]
        public string AirportCode { get; set;  }

        [Reference(2)]
        public string CarrierCode { get; set;  }
    }

    public class OnwardDestinationCarrier
    {
        [Reference(1)]
        [SeparatorSlant]
        public string AirportCode { get; set;  }

        [Reference(2)]
        public string CarrierCode { get; set;  }
    }

    public class PrepaidCollectChargeDeclarations
    {
        [Reference(1)]
        public string PcIndWeightValuation { get; set;  }

        [Reference(2)]
        public string PcIndOtherCharges { get; set;  }
    }

    public class ValueForCarriageDeclaration
    {
        [Reference(1)]
        public string DeclaredValueForCarriage { get; set;  }

        [Reference(2)]
        public string NoValue { get; set;  }
    }

    public class ValueForCustomsDeclaration
    {
        [Reference(1)]
        public string DeclaredValueForCustoms { get; set;  }

        [Reference(2)]
        public string NoValue { get; set;  }
    }

    public class ValueForInsuranceDeclaration
    {
        [Reference(1)]
        public string AmountOfInsurance { get; set;  }

        [Reference(2)]
        public string NoValue { get; set;  }
    }

    [SeparatorCrlf]
    public class OtherChargeDetails
    {
        [Reference(1)]
        public ChargeLine ChargeLine { get; set; }

        [Reference(2)]
        public List<OtherChargeItems> OtherChargeItems { get; set; }
    }

    [SeparatorSlant]
    public class ChargeLine
    {
        [SeparatorSlant]
        public string PcIndOtherCharges { get; set;  }
    }

    public class OtherChargeItems
    {
        [Reference(1)]
        public string OtherChargeCode { get; set;  }

        [Reference(2)]
        public string EntitlementCode { get; set;  }

        [Reference(3)]
        public string ChargeAmount { get; set;  }
    }

    public class ChargesOrTaxes
    {
        [Reference(1)]
        [SeparatorSlant]
        public string ChargeIdentifier { get; set;  }

        [Reference(2)]
        public string ChargeAmount { get; set;  }
    }

    public class TotalCharges
    {
        [Reference(1)]
        [SeparatorSlant]
        public string ChargeIdentifier { get; set;  }

        [Reference(2)]
        public string ChargeAmount { get; set;  }
    }

    public class AwbIssueDetails
    {
        [Reference(1)]
        [SeparatorSlant]
        public string Day { get; set;  }

        [Reference(2)]
        public string Month { get; set;  }

        [Reference(3)]
        public string Year { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public string PlaceInner { get; set;  }

        [Reference(5)]
        public string AirportCityCode { get; set;  }
    }

    public class Authorisation
    {
        [SeparatorSlant]
        public string Signature { get; set;  }
    }

    public class DestinationCurrency
    {
        public string IsoCurrencyCode { get; set;  }
    }

    public class CurrencyConversionRate
    {
        public string RateOfExchange { get; set;  }
    }

    public class CcChargesInDestinationCurrencyInner
    {
        public string ChargeAmount { get; set;  }
    }

    public class ChargesAtDestination
    {
        public string ChargeAmount { get; set;  }
    }

    public class TotalCollectCharges
    {
        public string ChargeAmount { get; set;  }
    }

    public class NoCommissionIndication
    {
        public string CassIndicator { get; set;  }
    }

    public class CommissionAmountOrPercentage
    {
        [Reference(1)]
        [SeparatorSlant]
        public CommissionAmount CommissionAmount { get; set; }

        [Reference(2)]
        public CommissionPercentage CommissionPercentage { get; set; }
    }

    public class CommissionAmount
    {
        public string CassSettlementFactor { get; set;  }
    }

    public class CommissionPercentage
    {
        [SeparatorSlant]
        public string CassSettlementFactor { get; set;  }
    }

    public class SalesIncentiveDetail
    {
        public string ChargeAmount { get; set;  }
    }

    public class SalesIncentiveIndication
    {
        [SeparatorSlant]
        public string CassIndicator { get; set;  }
    }

    public class AgentReference
    {
        public string FileReference { get; set;  }
    }

    [SeparatorCrlf]
    public class OtherCustSecurityAndRegulatCtrlInfoDet
    {
        [Reference(1)]
        [SeparatorSlant]
        public string IsoCountryCode { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string InformationIdentifier { get; set;  }

        [Reference(3)]
        [SeparatorSlant]
        public string CustSecurityAndRegulatCtrlInfoId { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public string SupplemCustSecurityAndRegulatCtrlInfo { get; set;  }
    }

    public class AccountDetail
    {
        [SeparatorSlant]
        public string AccountNumber { get; set;  }
    }

    public class Name
    {
        [Reference(1)]
        public string NamIdentifier { get {return "NAM";} }

        [Reference(2)]
        public List<NameDetail> NameDetail { get; set; }
    }

    [SeparatorCrlf]
    public class NameDetail
    {
        [SeparatorSlant]
        public string NameInner { get; set;  }
    }

    public class StreetAddress
    {
        [Reference(1)]
        public string AdrIdentifier { get {return "ADR";} }

        [Reference(2)]
        public List<StreetAddressDetail> StreetAddressDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StreetAddressDetail
    {
        [SeparatorSlant]
        public string StreetAddressInner { get; set;  }
    }

    [SeparatorCrlf]
    public class Location
    {
        [Reference(1)]
        public string LocIdentifier { get {return "LOC";} }

        [Reference(2)]
        [SeparatorSlant]
        public string PlaceInner { get; set;  }

        [Reference(3)]
        public StateProvince StateProvince { get; set; }
    }

    public class StateProvince
    {
        [SeparatorSlant]
        public string StateProvinceInner { get; set;  }
    }

    public class CodedLocation
    {
        [Reference(1)]
        [SeparatorSlant]
        public string IsoCountryCode { get; set;  }

        [Reference(2)]
        public PostCode PostCode { get; set; }
    }

    public class PostCode
    {
        [SeparatorSlant]
        public string PostCodeInner { get; set;  }
    }

    public class ContactDetail
    {
        [Reference(1)]
        [SeparatorSlant]
        public string ContactIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string ContactNumber { get; set;  }
    }

    public class AccountDetailAgt
    {
        [Reference(1)]
        [SeparatorSlant]
        public string AccountNumber { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string IataCargoAgentNumericCode { get; set;  }

        [Reference(3)]
        public CargoAgentCassOrParticipantId CargoAgentCassOrParticipantId { get; set; }
    }

    public class CargoAgentCassOrParticipantId
    {
        [Reference(1)]
        [SeparatorSlant]
        public CargoAgentCassAddress CargoAgentCassAddress { get; set; }

        [Reference(2)]
        public ParticipantId ParticipantId { get; set; }
    }

    public class ParticipantId
    {
        [SeparatorSlant]
        public string ParticipantIdentifier { get; set;  }
    }

    public class CargoAgentCassAddress
    {
        public string CargoAgentCassAddressInner { get; set;  }
    }

    [SeparatorCrlf]
    public class AccountDetails
    {
        [Reference(1)]
        [SeparatorSlant]
        public string AccountingInformationIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string AccountingInformationInner { get; set;  }
    }

    [SeparatorCrlf]
    public class Place
    {
        [SeparatorSlant]
        public string PlaceInner { get; set;  }
    }

    [SeparatorCrlf]
    public class SsrDetail
    {
        [SeparatorSlant]
        public string SpecialServiceRequestInner { get; set;  }
    }

    [SeparatorCrlf]
    public class OsiItems
    {
        [SeparatorSlant]
        public string OtherServiceInformationItem { get; set;  }
    }

    public class Sofr
    {
        [Reference(1)]
        [SeparatorSlant]
        public SenderOfficeFileReference SenderOfficeFileReference { get; set; }

        [Reference(2)]
        public SenderParticipantIdentification SenderParticipantIdentification { get; set; }
    }

    public class SenderOfficeMessageAddress
    {
        [Reference(1)]
        public string AirportCityCode { get; set;  }

        [Reference(2)]
        public string OfficeFunctionDesignator { get; set;  }

        [Reference(3)]
        public string CompanyDesignator { get; set;  }
    }

    public class SenderOfficeFileReference
    {
        public string FileReference { get; set;  }
    }

    public class SenderParticipantIdentification
    {
        [Reference(1)]
        [SeparatorSlant]
        public string ParticipantIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string ParticipantCode { get; set;  }

        [Reference(3)]
        [SeparatorSlant]
        public string AirportCode { get; set;  }
    }

    public class Supplementary1or2
    {
        [Reference(1)]
        [SeparatorSlant]
        public SupplementaryShipmentInformation1 SupplementaryShipmentInformation1 { get; set; }

        [Reference(2)]
        public SupplementaryShipmentInformation2 SupplementaryShipmentInformation2 { get; set; }
    }

    public class SupplementaryShipmentInformation1
    {
        public string InnerSupplementaryShipmentInformation { get; set;  }
    }

    public class SupplementaryShipmentInformation2
    {
        [SeparatorSlant]
        public string InnerSupplementaryShipmentInformation { get; set;  }
    }

    public class OtherParticipantOfficeMessageAddress
    {
        [Reference(1)]
        public string AirportCityCode { get; set;  }

        [Reference(2)]
        public string OfficeFunctionDesignator { get; set;  }

        [Reference(3)]
        public string CompanyDesignator { get; set;  }
    }

    public class Opofr
    {
        [Reference(1)]
        [SeparatorSlant]
        public OtherParticipantOfficeFileReference OtherParticipantOfficeFileReference { get; set; }

        [Reference(2)]
        public OtherParticipantIdentification OtherParticipantIdentification { get; set; }
    }

    public class OtherParticipantOfficeFileReference
    {
        public string FileReference { get; set;  }
    }

    public class OtherParticipantIdentification
    {
        [Reference(1)]
        [SeparatorSlant]
        public string ParticipantIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string ParticipantCode { get; set;  }

        [Reference(3)]
        [SeparatorSlant]
        public string AirportCityCode { get; set;  }
    }
}
