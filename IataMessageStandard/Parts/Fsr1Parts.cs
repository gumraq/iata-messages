namespace IataMessageStandard.Fsr1Parts
{
    [SeparatorCrlf]
    public class StandardMessageIdentification
    {
        public string StandardMessageIdentifier { get; set;  }
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
        public TotalConsignmentPieces TotalConsignmentPieces { get; set; }

        [Reference(5)]
        public NatureOfGoods NatureOfGoods { get; set; }
    }

    [SeparatorCrlf]
    public class FlightDetails
    {
        [Reference(1)]
        public FlightIdentification FlightIdentification { get; set; }

        [Reference(2)]
        [SeparatorSlant]
        public AirportsOfDepartureAndArrival AirportsOfDepartureAndArrival { get; set; }
    }

    public class OtherServiceInformation
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public OsiDetails1stLine OsiDetails1stLine { get; set; }

        [Reference(3)]
        public OsiDetails2stLine OsiDetails2stLine { get; set; }
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
        public WeightDetails WeightDetails { get; set; }
    }

    public class TotalConsignmentPieces
    {
        [Reference(1)]
        public string ShipmentDescriptionCode { get; set;  }

        [Reference(2)]
        public string NumberOfPieces { get; set;  }
    }

    public class WeightDetails
    {
        [Reference(1)]
        public string WeightCode { get; set;  }

        [Reference(2)]
        public string Weight { get; set;  }
    }

    public class NatureOfGoods
    {
        [SeparatorSlant]
        public string ManifestDescriptionOfGoods { get; set;  }
    }

    public class FlightIdentification
    {
        [Reference(1)]
        public string CarrierCode { get; set;  }

        [Reference(2)]
        public string FlightNumber { get; set;  }

        [Reference(3)]
        [SeparatorSlant]
        public FlightDate FlightDate { get; set; }
    }

    public class AirportsOfDepartureAndArrival
    {
        [Reference(1)]
        public string AirportCodeOfDeparture { get; set;  }

        [Reference(2)]
        public string AirportCodeOfArrival { get; set;  }
    }

    [SeparatorCrlf]
    public class OsiDetails1stLine
    {
        [SeparatorSlant]
        public string OsiDescription { get; set;  }
    }

    [SeparatorCrlf]
    public class OsiDetails2stLine
    {
        [SeparatorSlant]
        public string OsiDescription { get; set;  }
    }

    public class FlightDate
    {
        [Reference(1)]
        public string DayOfScheduledDeparture { get; set;  }

        [Reference(2)]
        public string MonthOfScheduledDeparture { get; set;  }
    }
}
