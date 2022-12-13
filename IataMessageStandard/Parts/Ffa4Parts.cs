namespace IataMessageStandard.Ffa4Parts
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

    public class FlightDetails
    {
        public List<FlightInfoDetails> FlightInfoDetails { get; set; }
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

    [SeparatorCrlf]
    public class BookingReference
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public RequestingOfficeMessageAddress RequestingOfficeMessageAddress { get; set; }

        [Reference(3)]
        public Rofr Rofr { get; set; }
    }

    [SeparatorCrlf]
    public class ShipmentReferenceInformation
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string ReferenceNumber { get; set;  }

        [Reference(3)]
        public Supplementary1or2 Supplementary1or2 { get; set; }
    }

    [SeparatorCrlf]
    public class FlightInfoDetails
    {
        [Reference(1)]
        public FlightIdentification FlightIdentification { get; set; }

        [Reference(2)]
        [SeparatorSlant]
        public AirportsOfDepartureAndArrival AirportsOfDepartureAndArrival { get; set; }

        [Reference(3)]
        [SeparatorSlant]
        public string SpaceAllocationCode { get; set;  }
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

    public class AirportsOfDepartureAndArrival
    {
        [Reference(1)]
        public string AirportCodeOfDeparture { get; set;  }

        [Reference(2)]
        public string AirportCodeOfArrival { get; set;  }
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

    public class NatureOfGoods
    {
        [SeparatorSlant]
        public string ManifestDescriptionOfGoods { get; set;  }
    }

    public class RequestingOfficeMessageAddress
    {
        [Reference(1)]
        public string AirportCityCode { get; set;  }

        [Reference(2)]
        public string OfficeFunctionDesignator { get; set;  }

        [Reference(3)]
        public string CompanyDesignator { get; set;  }
    }

    public class Rofr
    {
        [Reference(1)]
        [SeparatorSlant]
        public RequestingOfficeFileReference RequestingOfficeFileReference { get; set; }

        [Reference(2)]
        public RequestingParticipantIdentification RequestingParticipantIdentification { get; set; }
    }

    public class RequestingOfficeFileReference
    {
        public string FileReference { get; set;  }
    }

    public class RequestingParticipantIdentification
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
}
