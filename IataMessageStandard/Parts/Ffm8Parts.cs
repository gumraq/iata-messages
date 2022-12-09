namespace IataMessageStandard.Ffm8Parts
{
    [SeparatorCrlf]
    public class StandardMessageIdentification
    {
        public string StandardMessageIdentifier { get; set; }
        [SeparatorSlant]
        public string MessageTypeVersionNumber { get; set; }
    }

    [SeparatorCrlf]
    public class FlightIdAndPointOfLoading
    {
        public string MessageSequenceNumber { get; set; }
        [SeparatorSlant]
        public FlightIdentification FlightIdentification { get; set; }
        [SeparatorSlant]
        public string AirportCodeOfLoading { get; set; }
        public AircraftIdentification AircraftIdentification { get; set; }
        public FirstPointOfArrivalInformation FirstPointOfArrivalInformation { get; set; }
    }

    public class DestinationHeader
    {
        public PointOfUnloading PointOfUnloading { get; set; }
        public BulkLoadedCargo BulkLoadedCargo { get; set; }
        public List<UldLoadedCargo> UldLoadedCargo { get; set; }
    }

    [SeparatorCrlf]
    public class ManifestCompleteIndicator
    {
        public string EndOfMessageCode { get; set; }
    }

    [SeparatorCrlf]
    public class PointOfUnloading
    {
        public string AirportCodeOfUnloading { get; set; }
        public NilCargoIndication NilCargoIndication { get; set; }
        public ArrivalInformation ArrivalInformation { get; set; }
        public DepartureInformation DepartureInformation { get; set; }
    }

    public class BulkLoadedCargo
    {
        public List<Consignments> Consignments { get; set; }
    }

    public class UldLoadedCargo
    {
        public UldDescription UldDescription { get; set; }
        public List<UldMovementInformation> UldMovementInformation { get; set; }
        public UldUtilisationDetail UldUtilisationDetail { get; set; }
        public List<Consignments> Consignments { get; set; }
    }

    public class Consignments
    {
        public ConsignmentDetail ConsignmentDetail { get; set; }
        public DimensionsInformation DimensionsInformation { get; set; }
        public ConsignmentOnwardMovementInfo ConsignmentOnwardMovementInfo { get; set; }
        public OtherServiceInformation OtherServiceInformation { get; set; }
        public CustomsOrigin CustomsOrigin { get; set; }
        public OtherCustSecurityAndRegulatCtrlInfo OtherCustSecurityAndRegulatCtrlInfo { get; set; }
    }

    [SeparatorCrlf]
    public class UldDescription
    {
        public string LineIdentifierUld { get { return "ULD/"; } }
        public UldIdentification UldIdentification { get; set; }
        public UldPositionInformation UldPositionInformation { get; set; }
        public UldRemarks UldRemarks { get; set; }
    }

    [SeparatorCrlf]
    public class UldMovementInformation
    {
        public UldOnwardRoutingDetail UldOnwardRoutingDetail { get; set; }
        public UldOnwardBookingDetail UldOnwardBookingDetail { get; set; }
    }

    [SeparatorCrlf]
    public class UldUtilisationDetail
    {
        [SeparatorSlant]
        public string UldVolumeAvailableCode { get; set; }
    }

    public class OtherServiceInformation
    {
        public string LineIdentifier { get; set; }
        public OsiDetails1stLine OsiDetails1stLine { get; set; }
        public OsiDetails2stLine OsiDetails2stLine { get; set; }
    }

    [SeparatorCrlf]
    public class CustomsOrigin
    {
        public string LineIdentifier { get; set; }
        [SeparatorSlant]
        public string CustomsOriginCode { get; set; }
    }

    public class OtherCustSecurityAndRegulatCtrlInfo
    {
        public string LineIdentifier { get; set; }
        public List<OtherCustSecurityAndRegulatCtrlInfoDet> OtherCustSecurityAndRegulatCtrlInfoDet { get; set; }
    }

    public class FlightIdentification
    {
        public string CarrierCode { get; set; }
        public string FlightNumber { get; set; }
        [SeparatorSlant]
        public string DayOfScheduledDeparture { get; set; }
        public string MonthOfScheduledDeparture { get; set; }
        public string TimeOfScheduledDeparture { get; set; }
    }

    public class FirstPointOfArrivalInformation
    {
        [SeparatorSlant]
        public string IsoCountryCode { get; set; }
        [SeparatorSlant]
        public string DayOfScheduledArrival { get; set; }
        public string MonthOfScheduledArrival { get; set; }
        public string TimeOfScheduledArrival { get; set; }
        [SeparatorSlant]
        public string AirportCodeOfArrival { get; set; }
    }

    public class NilCargoIndication
    {
        [SeparatorSlant]
        public string NilCargoCode { get; set; }
    }

    public class AircraftIdentification
    {
        [SeparatorSlant]
        public string AircraftRegistration { get; set; }
    }

    public class ArrivalInformation
    {
        [SeparatorSlant]
        public ArrivalInformationDetail ArrivalInformationDetail { get; set; }
    }

    public class DepartureInformation
    {
        [SeparatorSlant]
        public DepartureInformationDetail DepartureInformationDetail { get; set; }
    }

    public class ArrivalInformationDetail
    {
        public string DayOfScheduledArrival { get; set; }
        public string MonthOfScheduledArrival { get; set; }
        public string TimeOfScheduledArrival { get; set; }
    }

    public class DepartureInformationDetail
    {
        public string DayOfScheduledDeparture { get; set; }
        public string MonthOfScheduledDeparture { get; set; }
        public string TimeOfScheduledDeparture { get; set; }
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

    public class TotalWeightDetails
    {
        public string WeightCode { get; set; }
        public string Weight { get; set; }
    }

    public class TotalConsignmentPieces
    {
        public string ShipmentDescriptionCode { get; set; }
        public string NumberOfPieces { get; set; }
    }

    public class Shrs
    {
        [SeparatorCrlf]
        public List<SpecialHandlingRequirements> SpecialHandlingRequirements { get; set; }
    }

    public class SpecialHandlingRequirements
    {
        [SeparatorSlant]
        public string SpecialHandlingCode { get; set; }
    }

    [SeparatorCrlf]
    public class ConsignmentDetail
    {
        public AwbIdentification AwbIdentification { get; set; }
        public AwbOriginAndDestination AwbOriginAndDestination { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public VolumeDetail VolumeDetail { get; set; }
        public DensityGroup DensityGroup { get; set; }
        public TotalConsignmentPieces TotalConsignmentPieces { get; set; }
        public NatureOfGoods NatureOfGoods { get; set; }
        public Shrs Shrs { get; set; }
    }

    public class DimensionsInformation
    {
        public string LineIdentifier { get; set; }
        public List<Dimensions> Dimensions { get; set; }
    }

    public class ConsignmentOnwardMovementInfo
    {
        public List<ConsignmentOnward> ConsignmentOnward { get; set; }
        public MovementPriority MovementPriority { get; set; }
    }

    [SeparatorCrlf]
    public class ConsignmentOnward
    {
        public OnwardRoutingDetail OnwardRoutingDetail { get; set; }
        public OnwardBookingDetail OnwardBookingDetail { get; set; }
    }

    public class OnwardRoutingDetail
    {
        [SeparatorSlant]
        public string AirportCodeOfNextDestination { get; set; }
        public string CarrierCode { get; set; }
    }

    public class OnwardBookingDetail
    {
        public string FlightNumber { get; set; }
        [SeparatorSlant]
        public string DayOfScheduledDeparture { get; set; }
        public string MonthOfScheduledDeparture { get; set; }
    }

    [SeparatorCrlf]
    public class OsiDetails1stLine
    {
        [SeparatorSlant]
        public string OsiDescription { get; set; }
    }

    [SeparatorCrlf]
    public class OsiDetails2stLine
    {
        [SeparatorSlant]
        public string OsiDescription { get; set; }
    }

    public class UldOnwardRoutingDetail
    {
        [SeparatorSlant]
        public string AirportCodeOfNextDestination { get; set; }
        public string CarrierCode { get; set; }
    }

    public class UldOnwardBookingDetail
    {
        public string FlightNumber { get; set; }
        [SeparatorSlant]
        public string DayOfScheduledDeparture { get; set; }
        public string MonthOfScheduledDeparture { get; set; }
    }

    public class UldIdentification
    {
        public string UldType { get; set; }
        public string UldSerialNumber { get; set; }
        public string UldOwnerCode { get; set; }
    }

    public class UldPositionInformation
    {
        [SeparatorHyphen]
        public string UldLoadingIndicator { get; set; }
    }

    public class UldRemarks
    {
        [SeparatorSlant]
        public string UldRemarksDescription { get; set; }
    }

    [SeparatorCrlf]
    public class MovementPriority
    {
        [SeparatorSlant]
        public string MovementPriorityCode { get; set; }
    }

    public class NatureOfGoods
    {
        [SeparatorSlant]
        public string ManifestDescriptionOfGoods { get; set; }
    }

    [SeparatorCrlf]
    public class Dimensions
    {
        [SeparatorSlant]
        public TotalWeightDetails TotalWeightDetails { get; set; }
        [SeparatorSlant]
        public DimensionsDetails DimensionsDetails { get; set; }
        [SeparatorSlant]
        public string NumberOfPieces { get; set; }
    }

    public class DimensionsDetails
    {
        public string MeasurementUnitCode { get; set; }
        public string LengthDimension { get; set; }
        [SeparatorHyphen]
        public string WidthDimension { get; set; }
        [SeparatorHyphen]
        public string HeightDimension { get; set; }
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
}
