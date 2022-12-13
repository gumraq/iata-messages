namespace IataMessageStandard.Fbr2Parts
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
    public class FlightInformation
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public FlightIdentification FlightIdentification { get; set; }
    }

    [SeparatorCrlf]
    public class RequestReference
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public RequestingOfficeMessageAddress RequestingOfficeMessageAddress { get; set; }

        [Reference(3)]
        public Rofr Rofr { get; set; }
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

        [Reference(5)]
        [SeparatorSlant]
        public string AirportCodeOfLoading { get; set;  }

        [Reference(6)]
        public string AirportCodeOfUnloading { get; set;  }
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
}
