namespace IataMessageStandard.Fbl4Parts
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
    public class FlightIdAndPointOfLoading
    {
        [Reference(1)]
        public string MessageSequenceNumber { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public FlightIdentification FlightIdentification { get; set; }

        [Reference(3)]
        [SeparatorSlant]
        public string AirportCodeOfLoading { get; set;  }

        [Reference(4)]
        public AircraftIdentification AircraftIdentification { get; set; }
    }

    public class DestinationHeader
    {
        [Reference(1)]
        public PointOfUnloading PointOfUnloading { get; set; }

        [Reference(2)]
        public List<BookedCargo> BookedCargo { get; set; }
    }

    [SeparatorCrlf]
    public class ListCompleteIndicator
    {
        public string EndOfMessageCode { get; set;  }
    }

    public class FlightIdentification
    {
        [Reference(1)]
        public string CarrierCode { get; set;  }

        [Reference(2)]
        public string FlightNumber { get; set;  }

        [Reference(3)]
        [SeparatorSlant]
        public string DayOfScheduledDeparture { get; set;  }

        [Reference(4)]
        public string MonthOfScheduledDeparture { get; set;  }
    }

    public class AircraftIdentification
    {
        [SeparatorSlant]
        public string AircraftRegistration { get; set;  }
    }

    [SeparatorCrlf]
    public class PointOfUnloading
    {
        [Reference(1)]
        public string AirportCodeOfUnloading { get; set;  }

        [Reference(2)]
        public NilCargoIndication NilCargoIndication { get; set; }
    }

    public class BookedCargo
    {
        [Reference(1)]
        public ConsignmentDetail ConsignmentDetail { get; set; }

        [Reference(2)]
        public DimensionsInformation DimensionsInformation { get; set; }

        [Reference(3)]
        public ConsignmentOriginInformation ConsignmentOriginInformation { get; set; }

        [Reference(4)]
        public UldDescription UldDescription { get; set; }

        [Reference(5)]
        public SpecialServiceRequest SpecialServiceRequest { get; set; }

        [Reference(6)]
        public OtherServiceInformation OtherServiceInformation { get; set; }

        [Reference(7)]
        public OtherCustSecurityAndRegulatCtrlInfo OtherCustSecurityAndRegulatCtrlInfo { get; set; }
    }

    [SeparatorCrlf]
    public class ConsignmentDetail
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

        [Reference(6)]
        public TotalConsignmentPieces TotalConsignmentPieces { get; set; }

        [Reference(7)]
        public NatureOfGoods NatureOfGoods { get; set; }

        [Reference(8)]
        public Shrs Shrs { get; set; }
    }

    public class DimensionsInformation
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
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
        [Reference(1)]
        public ForwardingAgent ForwardingAgent { get; set; }

        [Reference(2)]
        public InwardFlightDetails InwardFlightDetails { get; set; }

        [Reference(3)]
        public MovementPriority MovementPriority { get; set; }
    }

    public class UldDescription
    {
        [Reference(1)]
        public string LineIdentifierUld { get {return "ULD/";} }

        [Reference(2)]
        public string NumberOfUldsTotal { get; set;  }

        [Reference(3)]
        public List<UldDescriptionItems> UldDescriptionItems { get; set; }
    }

    public class SpecialServiceRequest
    {
        [Reference(1)]
        public string LineIdentifierSsr { get {return "SSR/";} }

        [Reference(2)]
        public SsrDetails1stLine SsrDetails1stLine { get; set; }

        [Reference(3)]
        public SsrDetails2stLine SsrDetails2stLine { get; set; }
    }

    public class OtherServiceInformation
    {
        [Reference(1)]
        public string LineIdentifierOsi { get {return "OSI/";} }

        [Reference(2)]
        public OsiDetails1stLine OsiDetails1stLine { get; set; }

        [Reference(3)]
        public OsiDetails2stLine OsiDetails2stLine { get; set; }
    }

    public class OtherCustSecurityAndRegulatCtrlInfo
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public List<OtherCustSecurityAndRegulatCtrlInfoDet> OtherCustSecurityAndRegulatCtrlInfoDet { get; set; }
    }

    public class NilCargoIndication
    {
        [SeparatorSlant]
        public string NilCargoCode { get; set;  }
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

    public class TotalWeightDetails
    {
        [Reference(1)]
        public string WeightCode { get; set;  }

        [Reference(2)]
        public string Weight { get; set;  }
    }

    public class TotalConsignmentPieces
    {
        [Reference(1)]
        public string ShipmentDescriptionCode { get; set;  }

        [Reference(2)]
        public string NumberOfPieces { get; set;  }
    }

    public class Shrs
    {
        [SeparatorCrlf]
        public List<SpecialHandlingRequirements> SpecialHandlingRequirements { get; set; }
    }

    public class SpecialHandlingRequirements
    {
        [SeparatorSlant]
        public string SpecialHandlingCode { get; set;  }
    }

    [SeparatorCrlf]
    public class SsrDetails1stLine
    {
        public string SsrDescription { get; set;  }
    }

    [SeparatorCrlf]
    public class SsrDetails2stLine
    {
        [SeparatorSlant]
        public string SsrDescription { get; set;  }
    }

    [SeparatorCrlf]
    public class OsiDetails1stLine
    {
        public string OsiDescription { get; set;  }
    }

    [SeparatorCrlf]
    public class OsiDetails2stLine
    {
        [SeparatorSlant]
        public string OsiDescription { get; set;  }
    }

    [SeparatorCrlf]
    public class UldDescriptionItems
    {
        public List<UldDescriptionInnerItems> UldDescriptionInnerItems { get; set; }
    }

    public class UldDescriptionInnerItems
    {
        [Reference(1)]
        [SeparatorSlant]
        public UldIdentification UldIdentification { get; set; }

        [Reference(2)]
        public UldPositionInformation UldPositionInformation { get; set; }

        [Reference(3)]
        public WeightOfUldContents WeightOfUldContents { get; set; }
    }

    public class UldIdentification
    {
        [Reference(1)]
        public string UldType { get; set;  }

        [Reference(2)]
        public UldNumber UldNumber { get; set; }
    }

    public class UldNumber
    {
        [Reference(1)]
        public string UldSerialNumber { get; set;  }

        [Reference(2)]
        public string UldOwnerCode { get; set;  }
    }

    public class UldPositionInformation
    {
        [SeparatorHyphen]
        public string UldLoadingIndicator { get; set;  }
    }

    public class WeightOfUldContents
    {
        [Reference(1)]
        [SeparatorSlant]
        public string WeightCode { get; set;  }

        [Reference(2)]
        public string Weight { get; set;  }
    }

    public class ForwardingAgent
    {
        public string AbbreviatedName { get; set;  }
    }

    public class InwardFlightDetails
    {
        [Reference(1)]
        [SeparatorSlant]
        public string CarrierCode { get; set;  }

        [Reference(2)]
        public string FlightNumber { get; set;  }

        [Reference(3)]
        [SeparatorSlant]
        public string DayOfArrival { get; set;  }

        [Reference(4)]
        public string MonthOfArrival { get; set;  }

        [Reference(5)]
        [SeparatorSlant]
        public string AirportCodeOfLoading { get; set;  }
    }

    public class MovementPriority
    {
        [SeparatorSlant]
        public string MovementPriorityCode { get; set;  }
    }

    public class NatureOfGoods
    {
        [SeparatorSlant]
        public string ManifestDescriptionOfGoods { get; set;  }
    }

    [SeparatorCrlf]
    public class Dimensions
    {
        [Reference(1)]
        [SeparatorSlant]
        public TotalWeightDetails TotalWeightDetails { get; set; }

        [Reference(2)]
        [SeparatorSlant]
        public DimensionsDetails DimensionsDetails { get; set; }

        [Reference(3)]
        [SeparatorSlant]
        public string NumberOfPieces { get; set;  }
    }

    public class DimensionsDetails
    {
        [Reference(1)]
        public string MeasurementUnitCode { get; set;  }

        [Reference(2)]
        public string LengthDimension { get; set;  }

        [Reference(3)]
        [SeparatorHyphen]
        public string WidthDimension { get; set;  }

        [Reference(4)]
        [SeparatorHyphen]
        public string HeightDimension { get; set;  }
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
}
