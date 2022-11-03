using System.Collections.Generic;

namespace IataMessagesProcessor.Messages.Fbl4Parts
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
    }


    public class DestinationHeader
    {
        public PointOfUnloading PointOfUnloading { get; set; }
        public List<BookedCargo> BookedCargo { get; set; }
    }


    [SeparatorCrlf]
    public class ListCompleteIndicator
    {
        public string EndOfMessageCode { get; set; }
    }


    public class FlightIdentification
    {
        public string CarrierCode { get; set; }
        public string FlightNumber { get; set; }
        [SeparatorSlant]
        public string DayOfScheduledDeparture { get; set; }
        public string MonthOfScheduledDeparture { get; set; }
    }


    public class AircraftIdentification
    {
        [SeparatorSlant]
        public string AircraftRegistration { get; set; }
    }


    [SeparatorCrlf]
    public class PointOfUnloading
    {
        public string AirportCodeOfUnloading { get; set; }
        public NilCargoIndication NilCargoIndication { get; set; }
    }


    public class BookedCargo
    {
        public ConsignmentDetail ConsignmentDetail { get; set; }
        public DimensionsInformation DimensionsInformation { get; set; }
        public ConsignmentOriginInformation ConsignmentOriginInformation { get; set; }
        public UldDescription UldDescription { get; set; }
        public SpecialServiceRequest SpecialServiceRequest { get; set; }
        public OtherServiceInformation OtherServiceInformation { get; set; }
        public OtherCustSecurityAndRegulatCtrlInfo OtherCustSecurityAndRegulatCtrlInfo { get; set; }
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


    [SeparatorCrlf]
    public class ConsignmentOriginInformation
    {
        [SeparatorSlant]
        public ConsignmentOriginInfoDetail ConsignmentOriginInfoDetail { get; set; }
    }


    public class ConsignmentOriginInfoDetail
    {
        public ForwardingAgent ForwardingAgent { get; set; }
        public InwardFlightDetails InwardFlightDetails { get; set; }
        public MovementPriority MovementPriority { get; set; }
    }


    public class UldDescription
    {
        public string LineIdentifierUld { get { return "ULD/"; } }
        public string NumberOfUldsTotal { get; set; }
        public List<UldDescriptionItems> UldDescriptionItems { get; set; }
    }


    public class SpecialServiceRequest
    {
        public string LineIdentifierSsr { get { return "SSR/"; } }
        public SsrDetails1stLine SsrDetails1stLine { get; set; }
        public SsrDetails2stLine SsrDetails2stLine { get; set; }
    }


    public class OtherServiceInformation
    {
        public string LineIdentifierOsi { get { return "OSI/"; } }
        public OsiDetails1stLine OsiDetails1stLine { get; set; }
        public OsiDetails2stLine OsiDetails2stLine { get; set; }
    }


    public class OtherCustSecurityAndRegulatCtrlInfo
    {
        public string LineIdentifier { get; set; }
        public List<OtherCustSecurityAndRegulatCtrlInfoDet> OtherCustSecurityAndRegulatCtrlInfoDet { get; set; }
    }


    public class NilCargoIndication
    {
        [SeparatorSlant]
        public string NilCargoCode { get; set; }
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
    public class SsrDetails1stLine
    {
        public string SsrDescription { get; set; }
    }


    [SeparatorCrlf]
    public class SsrDetails2stLine
    {
        [SeparatorSlant]
        public string SsrDescription { get; set; }
    }


    [SeparatorCrlf]
    public class OsiDetails1stLine
    {
        public string OsiDescription { get; set; }
    }


    [SeparatorCrlf]
    public class OsiDetails2stLine
    {
        [SeparatorSlant]
        public string OsiDescription { get; set; }
    }


    [SeparatorCrlf]
    public class UldDescriptionItems
    {
        public List<UldDescriptionInnerItems> UldDescriptionInnerItems { get; set; }
    }


    public class UldDescriptionInnerItems
    {
        [SeparatorSlant]
        public UldIdentification UldIdentification { get; set; }
        public UldPositionInformation UldPositionInformation { get; set; }
        public WeightOfUldContents WeightOfUldContents { get; set; }
    }


    public class UldIdentification
    {
        public string UldType { get; set; }
        public UldNumber UldNumber { get; set; }
    }


    public class UldNumber
    {
        public string UldSerialNumber { get; set; }
        public string UldOwnerCode { get; set; }
    }


    public class UldPositionInformation
    {
        [SeparatorHyphen]
        public string UldLoadingIndicator { get; set; }
    }


    public class WeightOfUldContents
    {
        [SeparatorSlant]
        public string WeightCode { get; set; }
        public string Weight { get; set; }
    }


    public class ForwardingAgent
    {
        public string AbbreviatedName { get; set; }
    }


    public class InwardFlightDetails
    {
        [SeparatorSlant]
        public string CarrierCode { get; set; }
        public string FlightNumber { get; set; }
        [SeparatorSlant]
        public string DayOfArrival { get; set; }
        public string MonthOfArrival { get; set; }
        [SeparatorSlant]
        public string AirportCodeOfLoading { get; set; }
    }


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
