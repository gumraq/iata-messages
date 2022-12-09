namespace IataMessageStandard.Fwb17Parts
{
    [SeparatorCrlf]
    public class StandardMessageIdentification
    {
        public string StandardMessageIdentifier { get; set; }
        [SeparatorSlant]
        public string MessageTypeVersionNumber { get; set; }
    }

    [SeparatorCrlf]
    public class AwbConsignmentDetail
    {
        public AwbIdentification AwbIdentification { get; set; }
        public AwbOriginAndDestination AwbOriginAndDestination { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public VolumeDetail VolumeDetail { get; set; }
        public DensityGroup DensityGroup { get; set; }
    }

    [SeparatorCrlf]
    public class FlightBookings
    {
        public string LineIdentifier { get; set; }
        public List<FlightIdentification> FlightIdentification { get; set; }
    }

    [SeparatorCrlf]
    public class Routing
    {
        public string LineIdentifier { get; set; }
        public FirstDestinationCarrier FirstDestinationCarrier { get; set; }
        public List<OnwardDestinationCarrier> OnwardDestinationCarrier { get; set; }
    }

    [SeparatorCrlf]
    public class Shipper
    {
        public string LineIdentifier { get; set; }
        public AccountDetail AccountDetail { get; set; }
        [SeparatorCrlf]
        public Name Name { get; set; }
        public StreetAddress StreetAddress { get; set; }
        public Location Location { get; set; }
        public CodedLocation CodedLocation { get; set; }
        public List<ContactDetail> ContactDetail { get; set; }
    }

    [SeparatorCrlf]
    public class Consignee
    {
        public string LineIdentifier { get; set; }
        public AccountDetail AccountDetail { get; set; }
        [SeparatorCrlf]
        public Name Name { get; set; }
        public StreetAddress StreetAddress { get; set; }
        public Location Location { get; set; }
        public CodedLocation CodedLocation { get; set; }
        public List<ContactDetail> ContactDetail { get; set; }
    }

    public class Agent
    {
        public string LineIdentifier { get; set; }
        public AccountDetailAgt AccountDetailAgt { get; set; }
        [SeparatorCrlf]
        public NameDetail NameDetail { get; set; }
        public Place Place { get; set; }
    }

    public class SpecialServiceRequest
    {
        public string LineIdentifier { get; set; }
        public List<SsrDetail> SsrDetail { get; set; }
    }

    [SeparatorCrlf]
    public class AlsoNotify
    {
        public string LineIdentifier { get; set; }
        [SeparatorCrlf]
        public Name Name { get; set; }
        public StreetAddress StreetAddress { get; set; }
        public Location Location { get; set; }
        public CodedLocation CodedLocation { get; set; }
        public List<ContactDetail> ContactDetail { get; set; }
    }

    public class AccountingInformation
    {
        public string LineIdentifier { get; set; }
        public List<AccountDetails> AccountDetails { get; set; }
    }

    [SeparatorCrlf]
    public class ChargeDeclarations
    {
        public string LineIdentifier { get; set; }
        [SeparatorSlant]
        public string IsoCurrencyCode { get; set; }
        [SeparatorSlant]
        public string ChargeCode { get; set; }
        [SeparatorSlant]
        public PrepaidCollectChargeDeclarations PrepaidCollectChargeDeclarations { get; set; }
        [SeparatorSlant]
        public ValueForCarriageDeclaration ValueForCarriageDeclaration { get; set; }
        [SeparatorSlant]
        public ValueForCustomsDeclaration ValueForCustomsDeclaration { get; set; }
        [SeparatorSlant]
        public ValueForInsuranceDeclaration ValueForInsuranceDeclaration { get; set; }
    }

    public class RateDescription
    {
        public string LineIdentifier { get; set; }
        public List<RateDescriptionItems> RateDescriptionItems { get; set; }
    }

    public class OtherCharges
    {
        public string LineIdentifier { get; set; }
        public List<OtherChargeDetails> OtherChargeDetails { get; set; }
    }

    [SeparatorCrlf]
    public class PrepaidChargeSummary
    {
        public string LineIdentifierPpd { get { return "PPD"; } }
        public List<ChargesOrTaxes> ChargesOrTaxes { get; set; }
        [SeparatorCrlf]
        public List<TotalCharges> TotalCharges { get; set; }
    }

    [SeparatorCrlf]
    public class CollectChargeSummary
    {
        public string LineIdentifierCol { get { return "COL"; } }
        public List<ChargesOrTaxes> ChargesOrTaxes { get; set; }
        [SeparatorCrlf]
        public List<TotalCharges> TotalCharges { get; set; }
    }

    [SeparatorCrlf]
    public class ShippersCertification
    {
        public string LineIdentifier { get; set; }
        [SeparatorSlant]
        public string Signature { get; set; }
    }

    [SeparatorCrlf]
    public class CarriersExecution
    {
        public string LineIdentifier { get; set; }
        public AwbIssueDetails AwbIssueDetails { get; set; }
        public Authorisation Authorisation { get; set; }
    }

    public class OtherServiceInformation
    {
        public string LineIdentifier { get; set; }
        public List<OsiItems> OsiItems { get; set; }
    }

    [SeparatorCrlf]
    public class CcChargesInDestinationCurrency
    {
        public string LineIdentifier { get; set; }
        [SeparatorSlant]
        public DestinationCurrency DestinationCurrency { get; set; }
        public CurrencyConversionRate CurrencyConversionRate { get; set; }
        [SeparatorSlant]
        public CcChargesInDestinationCurrencyInner CcChargesInDestinationCurrencyInner { get; set; }
        [SeparatorSlant]
        public ChargesAtDestination ChargesAtDestination { get; set; }
        [SeparatorSlant]
        public TotalCollectCharges TotalCollectCharges { get; set; }
    }

    [SeparatorCrlf]
    public class SenderReference
    {
        public string LineIdentifier { get; set; }
        [SeparatorSlant]
        public SenderOfficeMessageAddress SenderOfficeMessageAddress { get; set; }
        public Sofr Sofr { get; set; }
    }

    [SeparatorCrlf]
    public class CustomsOrigin
    {
        public string LineIdentifier { get; set; }
        [SeparatorSlant]
        public string CustomsOriginCode { get; set; }
    }

    [SeparatorCrlf]
    public class CommissionInformation
    {
        public string LineIdentifier { get; set; }
        [SeparatorSlant]
        public NoCommissionIndication NoCommissionIndication { get; set; }
        public CommissionAmountOrPercentage CommissionAmountOrPercentage { get; set; }
    }

    [SeparatorCrlf]
    public class SalesIncentiveInformation
    {
        public string LineIdentifierSii { get { return "SII"; } }
        [SeparatorSlant]
        public SalesIncentiveDetail SalesIncentiveDetail { get; set; }
        public SalesIncentiveIndication SalesIncentiveIndication { get; set; }
    }

    [SeparatorCrlf]
    public class AgentReferenceData
    {
        public string LineIdentifier { get; set; }
        [SeparatorSlant]
        public AgentReference AgentReference { get; set; }
    }

    [SeparatorCrlf]
    public class SpecialHandlingDetails
    {
        public string LineIdentifier { get; set; }
        public List<SpecialHandlingRequirements> SpecialHandlingRequirements { get; set; }
    }

    [SeparatorCrlf]
    public class NominatedHandlingParty
    {
        public string LineIdentifierNom { get { return "NOM"; } }
        [SeparatorSlant]
        public string NameInner { get; set; }
        [SeparatorSlant]
        public string PlaceInner { get; set; }
    }

    [SeparatorCrlf]
    public class ShipmentReferenceInformation
    {
        public string LineIdentifierSri { get { return "SRI"; } }
        [SeparatorSlant]
        public string ReferenceNumber { get; set; }
        public Supplementary1or2 Supplementary1or2 { get; set; }
    }

    [SeparatorCrlf]
    public class OtherParticipantInformation
    {
        public string LineIdentifier { get; set; }
        [SeparatorSlant]
        public string NameInner { get; set; }
        [SeparatorCrlf]
        [SeparatorSlant]
        public OtherParticipantOfficeMessageAddress OtherParticipantOfficeMessageAddress { get; set; }
        public Opofr Opofr { get; set; }
    }

    public class OtherCustSecurityAndRegulatCtrlInfo
    {
        public string LineIdentifier { get; set; }
        public List<OtherCustSecurityAndRegulatCtrlInfoDet> OtherCustSecurityAndRegulatCtrlInfoDet { get; set; }
    }

    public class RateDescriptionItems
    {
        public ChargeLineCount ChargeLineCount { get; set; }
        public ElementFrom3To10 ElementFrom3To10 { get; set; }
        public ElementFrom11To19 ElementFrom11To19 { get; set; }
    }

    public class ChargeLineCount
    {
        [SeparatorSlant]
        public string HwbRateLineNumber { get; set; }
    }

    [SeparatorCrlf]
    public class ElementFrom3To10
    {
        public NumberOfPiecesRcpDetails NumberOfPiecesRcpDetails { get; set; }
        public GrossWeightDetails GrossWeightDetails { get; set; }
        public RateClassDetails RateClassDetails { get; set; }
        public CommodityItemNumberDetails CommodityItemNumberDetails { get; set; }
        public ChargeableWeightDetails ChargeableWeightDetails { get; set; }
        public RateChargeDetails RateChargeDetails { get; set; }
        public TotalDetails TotalDetails { get; set; }
    }

    [SeparatorCrlf]
    public class ElementFrom11To19
    {
        public GoodsDescription GoodsDescription { get; set; }
        public GoodsConsolidation GoodsConsolidation { get; set; }
        public Dimensions Dimensions { get; set; }
        public Volume Volume { get; set; }
        public UldNumber UldNumber { get; set; }
        public ShippersLoadAndCount ShippersLoadAndCount { get; set; }
        public HarmonisedCommodityCode HarmonisedCommodityCode { get; set; }
        public CountryOfOriginOfGoods CountryOfOriginOfGoods { get; set; }
        public ServiceCodeDetails ServiceCodeDetails { get; set; }
    }

    public class NumberOfPiecesRcpDetails
    {
        [SeparatorSlant]
        public string HwbColumnIdentifier { get; set; }
        public string NumberOfPieces { get; set; }
        public string RateCombinationPoint { get; set; }
    }

    public class GrossWeightDetails
    {
        [SeparatorSlant]
        public WeightInfo WeightInfo { get; set; }
    }

    public class RateClassDetails
    {
        [SeparatorSlant]
        public string HwbColumnIdentifier { get; set; }
        public string RateClassCode { get; set; }
    }

    public class CommodityItemNumberDetails
    {
        [SeparatorSlant]
        public string HwbColumnIdentifier { get; set; }
        public string CommodityItemNumber { get; set; }
        public string UldRateClassType { get; set; }
        public RateClassCodeBasisAndPercentage RateClassCodeBasisAndPercentage { get; set; }
    }

    public class ChargeableWeightDetails
    {
        [SeparatorSlant]
        public string HwbColumnIdentifier { get; set; }
        public string Weight { get; set; }
    }

    public class RateChargeDetails
    {
        [SeparatorSlant]
        public string HwbColumnIdentifier { get; set; }
        public string RateOrCharge { get; set; }
        public string Discount { get; set; }
    }

    public class TotalDetails
    {
        [SeparatorSlant]
        public string HwbColumnIdentifier { get; set; }
        public string ChargeAmount { get; set; }
        public string Discount { get; set; }
    }

    public class GoodsDescription
    {
        public string GoodsDescriptionIdentifier { get { return "/NG/"; } }
        public string NatureAndQuantityOfGoods { get; set; }
    }

    public class GoodsConsolidation
    {
        public string ConsolidationIdentifier { get { return "/NC/"; } }
        public string NatureAndQuantityOfGoods { get; set; }
    }

    public class Dimensions
    {
        public string DimensionsIdentifier { get { return "/ND/"; } }
        public WeightInfo WeightInfo { get; set; }
        [SeparatorSlant]
        public DimentionsDimNda DimentionsDimNda { get; set; }
    }

    public class Volume
    {
        public string VolumeIdentifier { get { return "/NV/"; } }
        public string VolumeCode { get; set; }
        public string VolumeAmount { get; set; }
    }

    public class UldNumber
    {
        public string UldNumberIdentifier { get { return "/NU/"; } }
        public string UldType { get; set; }
        public string UldSerialNumber { get; set; }
        public string UldOwnerCode { get; set; }
    }

    public class ShippersLoadAndCount
    {
        public string ShippersLoadAndCountIdentifier { get { return "/NS/"; } }
        public string Slac { get; set; }
    }

    public class HarmonisedCommodityCode
    {
        public string HarmonisedCommodityCodeIdentifier { get { return "/NH/"; } }
        public string HarmonisedCommodityCodeInner { get; set; }
    }

    public class CountryOfOriginOfGoods
    {
        public string CountryOfOriginOfGoodsIdentifier { get { return "/NO/"; } }
        public string IsoCountryCode { get; set; }
    }

    public class ServiceCodeDetails
    {
        [SeparatorSlant]
        public string ServiceCode { get; set; }
    }

    public class RateClassCodeBasisAndPercentage
    {
        public string RateClassCodeBasis { get; set; }
        public string ClassRatePercentage { get; set; }
    }

    public class WeightInfo
    {
        public string WeightCode { get; set; }
        public string Weight { get; set; }
    }

    public class DimentionsDimNda
    {
        public string MeasurementUnitCode { get; set; }
        public Dimension Dimension { get; set; }
    }

    public class Dimension
    {
        public string LengthDimension { get; set; }
        [SeparatorHyphen]
        public string WidthDimension { get; set; }
        [SeparatorHyphen]
        public string HeightDimension { get; set; }
        [SeparatorSlant]
        public string NumberOfPieces { get; set; }
    }

    public class AwbIdentification
    {
        public string AirlinePrefix { get; set; }
        [SeparatorHyphen]
        public string AwbSerialNumber { get; set; }
    }

    public class AwbOriginAndDestination
    {
        public string AirportCodeOfOrigin { get; set; }
        public string AirportCodeOfDestitation { get; set; }
    }

    public class QuantityDetail
    {
        [SeparatorSlant]
        public string ShipmentDescriptionCode { get; set; }
        public string NumberOfPieces { get; set; }
        public string WeightCode { get; set; }
        public string Weight { get; set; }
    }

    public class VolumeDetail
    {
        public string VolumeCode { get; set; }
        public string VolumeAmount { get; set; }
    }

    public class DensityGroup
    {
        public string DensityIndicator { get; set; }
        public string DensityGroupInner { get; set; }
    }

    public class SpecialHandlingRequirements
    {
        [SeparatorSlant]
        public string SpecialHandlingCode { get; set; }
    }

    public class FlightIdentification
    {
        [SeparatorSlant]
        public string CarrierCode { get; set; }
        public string FlightNumber { get; set; }
        [SeparatorSlant]
        public string Day { get; set; }
    }

    public class FirstDestinationCarrier
    {
        [SeparatorSlant]
        public string AirportCode { get; set; }
        public string CarrierCode { get; set; }
    }

    public class OnwardDestinationCarrier
    {
        [SeparatorSlant]
        public string AirportCode { get; set; }
        public string CarrierCode { get; set; }
    }

    public class PrepaidCollectChargeDeclarations
    {
        public string PcIndWeightValuation { get; set; }
        public string PcIndOtherCharges { get; set; }
    }

    public class ValueForCarriageDeclaration
    {
        public string DeclaredValueForCarriage { get; set; }
        public string NoValue { get; set; }
    }

    public class ValueForCustomsDeclaration
    {
        public string DeclaredValueForCustoms { get; set; }
        public string NoValue { get; set; }
    }

    public class ValueForInsuranceDeclaration
    {
        public string AmountOfInsurance { get; set; }
        public string NoValue { get; set; }
    }

    [SeparatorCrlf]
    public class OtherChargeDetails
    {
        public ChargeLine ChargeLine { get; set; }
        public List<OtherChargeItems> OtherChargeItems { get; set; }
    }

    [SeparatorSlant]
    public class ChargeLine
    {
        [SeparatorSlant]
        public string PcIndOtherCharges { get; set; }
    }

    public class OtherChargeItems
    {
        public string OtherChargeCode { get; set; }
        public string EntitlementCode { get; set; }
        public string ChargeAmount { get; set; }
    }

    public class ChargesOrTaxes
    {
        [SeparatorSlant]
        public string ChargeIdentifier { get; set; }
        public string ChargeAmount { get; set; }
    }

    public class TotalCharges
    {
        [SeparatorSlant]
        public string ChargeIdentifier { get; set; }
        public string ChargeAmount { get; set; }
    }

    public class AwbIssueDetails
    {
        [SeparatorSlant]
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        [SeparatorSlant]
        public string PlaceInner { get; set; }
        public string AirportCityCode { get; set; }
    }

    public class Authorisation
    {
        [SeparatorSlant]
        public string Signature { get; set; }
    }

    public class DestinationCurrency
    {
        public string IsoCurrencyCode { get; set; }
    }

    public class CurrencyConversionRate
    {
        public string RateOfExchange { get; set; }
    }

    public class CcChargesInDestinationCurrencyInner
    {
        public string ChargeAmount { get; set; }
    }

    public class ChargesAtDestination
    {
        public string ChargeAmount { get; set; }
    }

    public class TotalCollectCharges
    {
        public string ChargeAmount { get; set; }
    }

    public class NoCommissionIndication
    {
        public string CassIndicator { get; set; }
    }

    public class CommissionAmountOrPercentage
    {
        [SeparatorSlant]
        public CommissionAmount CommissionAmount { get; set; }
        public CommissionPercentage CommissionPercentage { get; set; }
    }

    public class CommissionAmount
    {
        public string CassSettlementFactor { get; set; }
    }

    public class CommissionPercentage
    {
        [SeparatorSlant]
        public string CassSettlementFactor { get; set; }
    }

    public class SalesIncentiveDetail
    {
        public string ChargeAmount { get; set; }
    }

    public class SalesIncentiveIndication
    {
        [SeparatorSlant]
        public string CassIndicator { get; set; }
    }

    public class AgentReference
    {
        public string FileReference { get; set; }
    }

    [SeparatorCrlf]
    public class OtherCustSecurityAndRegulatCtrlInfoDet
    {
        [SeparatorSlant]
        public string IsoCountryCode { get; set; }
        [SeparatorSlant]
        public string InformationIdentifier { get; set; }
        [SeparatorSlant]
        public string CustSecurityAndRegulatCtrlInfoId { get; set; }
        [SeparatorSlant]
        public string SupplemCustSecurityAndRegulatCtrlInfo { get; set; }
    }

    public class AccountDetail
    {
        [SeparatorSlant]
        public string AccountNumber { get; set; }
    }

    public class Name
    {
        public string NamIdentifier { get { return "NAM"; } }
        public List<NameDetail> NameDetail { get; set; }
    }

    [SeparatorCrlf]
    public class NameDetail
    {
        [SeparatorSlant]
        public string NameInner { get; set; }
    }

    public class StreetAddress
    {
        public string AdrIdentifier { get { return "ADR"; } }
        public List<StreetAddressDetail> StreetAddressDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StreetAddressDetail
    {
        [SeparatorSlant]
        public string StreetAddressInner { get; set; }
    }

    [SeparatorCrlf]
    public class Location
    {
        public string LocIdentifier { get { return "LOC"; } }
        [SeparatorSlant]
        public string PlaceInner { get; set; }
        public StateProvince StateProvince { get; set; }
    }

    public class StateProvince
    {
        [SeparatorSlant]
        public string StateProvinceInner { get; set; }
    }

    public class CodedLocation
    {
        [SeparatorSlant]
        public string IsoCountryCode { get; set; }
        public PostCode PostCode { get; set; }
    }

    public class PostCode
    {
        [SeparatorSlant]
        public string PostCodeInner { get; set; }
    }

    public class ContactDetail
    {
        [SeparatorSlant]
        public string ContactIdentifier { get; set; }
        [SeparatorSlant]
        public string ContactNumber { get; set; }
    }

    public class AccountDetailAgt
    {
        [SeparatorSlant]
        public string AccountNumber { get; set; }
        [SeparatorSlant]
        public string IataCargoAgentNumericCode { get; set; }
        public CargoAgentCassOrParticipantId CargoAgentCassOrParticipantId { get; set; }
    }

    public class CargoAgentCassOrParticipantId
    {
        [SeparatorSlant]
        public CargoAgentCassAddress CargoAgentCassAddress { get; set; }
        public ParticipantId ParticipantId { get; set; }
    }

    public class ParticipantId
    {
        [SeparatorSlant]
        public string ParticipantIdentifier { get; set; }
    }

    public class CargoAgentCassAddress
    {
        public string CargoAgentCassAddressInner { get; set; }
    }

    [SeparatorCrlf]
    public class AccountDetails
    {
        [SeparatorSlant]
        public string AccountingInformationIdentifier { get; set; }
        [SeparatorSlant]
        public string AccountingInformationInner { get; set; }
    }

    [SeparatorCrlf]
    public class Place
    {
        [SeparatorSlant]
        public string PlaceInner { get; set; }
    }

    [SeparatorCrlf]
    public class SsrDetail
    {
        [SeparatorSlant]
        public string SpecialServiceRequestInner { get; set; }
    }

    [SeparatorCrlf]
    public class OsiItems
    {
        [SeparatorSlant]
        public string OtherServiceInformationItem { get; set; }
    }

    public class Sofr
    {
        [SeparatorSlant]
        public SenderOfficeFileReference SenderOfficeFileReference { get; set; }
        public SenderParticipantIdentification SenderParticipantIdentification { get; set; }
    }

    public class SenderOfficeMessageAddress
    {
        public string AirportCityCode { get; set; }
        public string OfficeFunctionDesignator { get; set; }
        public string CompanyDesignator { get; set; }
    }

    public class SenderOfficeFileReference
    {
        public string FileReference { get; set; }
    }

    public class SenderParticipantIdentification
    {
        [SeparatorSlant]
        public string ParticipantIdentifier { get; set; }
        [SeparatorSlant]
        public string ParticipantCode { get; set; }
        [SeparatorSlant]
        public string AirportCode { get; set; }
    }

    public class Supplementary1or2
    {
        [SeparatorSlant]
        public SupplementaryShipmentInformation1 SupplementaryShipmentInformation1 { get; set; }
        public SupplementaryShipmentInformation2 SupplementaryShipmentInformation2 { get; set; }
    }

    public class SupplementaryShipmentInformation1
    {
        public string InnerSupplementaryShipmentInformation { get; set; }
    }

    public class SupplementaryShipmentInformation2
    {
        [SeparatorSlant]
        public string InnerSupplementaryShipmentInformation { get; set; }
    }

    public class OtherParticipantOfficeMessageAddress
    {
        public string AirportCityCode { get; set; }
        public string OfficeFunctionDesignator { get; set; }
        public string CompanyDesignator { get; set; }
    }

    public class Opofr
    {
        [SeparatorSlant]
        public OtherParticipantOfficeFileReference OtherParticipantOfficeFileReference { get; set; }
        public OtherParticipantIdentification OtherParticipantIdentification { get; set; }
    }

    public class OtherParticipantOfficeFileReference
    {
        public string FileReference { get; set; }
    }

    public class OtherParticipantIdentification
    {
        [SeparatorSlant]
        public string ParticipantIdentifier { get; set; }
        [SeparatorSlant]
        public string ParticipantCode { get; set; }
        [SeparatorSlant]
        public string AirportCityCode { get; set; }
    }
}
