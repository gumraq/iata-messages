namespace IataMessageStandard.Ffa4Parts
{
    [SeparatorCrlf]
    public class StandardMessageIdentification
    {
        public string StandardMessageIdentifier { get ; set;  }
        [SeparatorSlant]
        public string MessageTypeVersionNumber { get ; set;  }
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

    public class FlightDetails
    {
        public List<FlightInfoDetails> FlightInfoDetails { get; set; }
    }

    public class SpecialServiceRequest
    {
        public string LineIdentifierSsr { get {return "SSR/";} }
        public SsrDetails1stLine SsrDetails1stLine { get; set; }
        public SsrDetails2stLine SsrDetails2stLine { get; set; }
    }

    public class OtherServiceInformation
    {
        public string LineIdentifierOsi { get {return "OSI/";} }
        public OsiDetails1stLine OsiDetails1stLine { get; set; }
        public OsiDetails2stLine OsiDetails2stLine { get; set; }
    }

    [SeparatorCrlf]
    public class BookingReference
    {
        public string LineIdentifier { get ; set;  }
        [SeparatorSlant]
        public RequestingOfficeMessageAddress RequestingOfficeMessageAddress { get; set; }
        public Rofr Rofr { get; set; }
    }

    [SeparatorCrlf]
    public class ShipmentReferenceInformation
    {
        public string LineIdentifier { get ; set;  }
        [SeparatorSlant]
        public string ReferenceNumber { get ; set;  }
        public Supplementary1or2 Supplementary1or2 { get; set; }
    }

    [SeparatorCrlf]
    public class FlightInfoDetails
    {
        public FlightIdentification FlightIdentification { get; set; }
        [SeparatorSlant]
        public AirportsOfDepartureAndArrival AirportsOfDepartureAndArrival { get; set; }
        [SeparatorSlant]
        public string SpaceAllocationCode { get ; set;  }
    }

    public class FlightIdentification
    {
        public string CarrierCode { get ; set;  }
        public string FlightNumber { get ; set;  }
        [SeparatorSlant]
        public string DayOfScheduledDeparture { get ; set;  }
        public string MonthOfScheduledDeparture { get ; set;  }
    }

    public class AirportsOfDepartureAndArrival
    {
        public string AirportCodeOfDeparture { get ; set;  }
        public string AirportCodeOfArrival { get ; set;  }
    }

    public class AwbIdentification
    {
        public string AirlinePrefix { get ; set;  }
        [SeparatorHyphen]
        public string AwbSerialNumber { get ; set;  }
    }

    public class AwbOriginAndDestination
    {
        public string AirportCodeOfOrigin { get ; set;  }
        public string AirportCodeOfDestitation { get ; set;  }
    }

    public class QuantityDetail
    {
        [SeparatorSlant]
        public string ShipmentDescriptionCode { get ; set;  }
        public string NumberOfPieces { get ; set;  }
        public string WeightCode { get ; set;  }
        public string Weight { get ; set;  }
    }

    public class VolumeDetail
    {
        public string VolumeCode { get ; set;  }
        public string VolumeAmount { get ; set;  }
    }

    public class DensityGroup
    {
        public string DensityIndicator { get ; set;  }
        public string DensityGroupInner { get ; set;  }
    }

    public class TotalConsignmentPieces
    {
        public string ShipmentDescriptionCode { get ; set;  }
        public string NumberOfPieces { get ; set;  }
    }

    public class Shrs
    {
        [SeparatorCrlf]
        public List<SpecialHandlingRequirements> SpecialHandlingRequirements { get; set; }
    }

    public class SpecialHandlingRequirements
    {
        [SeparatorSlant]
        public string SpecialHandlingCode { get ; set;  }
    }

    [SeparatorCrlf]
    public class SsrDetails1stLine
    {
        public string SsrDescription { get ; set;  }
    }

    [SeparatorCrlf]
    public class SsrDetails2stLine
    {
        [SeparatorSlant]
        public string SsrDescription { get ; set;  }
    }

    [SeparatorCrlf]
    public class OsiDetails1stLine
    {
        public string OsiDescription { get ; set;  }
    }

    [SeparatorCrlf]
    public class OsiDetails2stLine
    {
        [SeparatorSlant]
        public string OsiDescription { get ; set;  }
    }

    public class NatureOfGoods
    {
        [SeparatorSlant]
        public string ManifestDescriptionOfGoods { get ; set;  }
    }

    public class RequestingOfficeMessageAddress
    {
        public string AirportCityCode { get ; set;  }
        public string OfficeFunctionDesignator { get ; set;  }
        public string CompanyDesignator { get ; set;  }
    }

    public class Rofr
    {
        [SeparatorSlant]
        public RequestingOfficeFileReference RequestingOfficeFileReference { get; set; }
        public RequestingParticipantIdentification RequestingParticipantIdentification { get; set; }
    }

    public class RequestingOfficeFileReference
    {
        public string FileReference { get ; set;  }
    }

    public class RequestingParticipantIdentification
    {
        [SeparatorSlant]
        public string ParticipantIdentifier { get ; set;  }
        [SeparatorSlant]
        public string ParticipantCode { get ; set;  }
        [SeparatorSlant]
        public string AirportCityCode { get ; set;  }
    }

    public class Supplementary1or2
    {
        [SeparatorSlant]
        public SupplementaryShipmentInformation1 SupplementaryShipmentInformation1 { get; set; }
        public SupplementaryShipmentInformation2 SupplementaryShipmentInformation2 { get; set; }
    }

    public class SupplementaryShipmentInformation1
    {
        public string InnerSupplementaryShipmentInformation { get ; set;  }
    }

    public class SupplementaryShipmentInformation2
    {
        [SeparatorSlant]
        public string InnerSupplementaryShipmentInformation { get ; set;  }
    }
}
