namespace IataMessageStandard.Fbr2Parts
{
    [SeparatorCrlf]
    public class StandardMessageIdentification
    {
        public string StandardMessageIdentifier { get ; set;  }
        [SeparatorSlant]
        public string MessageTypeVersionNumber { get ; set;  }
    }

    [SeparatorCrlf]
    public class FlightInformation
    {
        public string LineIdentifier { get ; set;  }
        [SeparatorSlant]
        public FlightIdentification FlightIdentification { get; set; }
    }

    [SeparatorCrlf]
    public class RequestReference
    {
        public string LineIdentifier { get ; set;  }
        [SeparatorSlant]
        public RequestingOfficeMessageAddress RequestingOfficeMessageAddress { get; set; }
        public Rofr Rofr { get; set; }
    }

    public class FlightIdentification
    {
        public string CarrierCode { get ; set;  }
        public string FlightNumber { get ; set;  }
        [SeparatorSlant]
        public string DayOfScheduledDeparture { get ; set;  }
        public string MonthOfScheduledDeparture { get ; set;  }
        [SeparatorSlant]
        public string AirportCodeOfLoading { get ; set;  }
        public string AirportCodeOfUnloading { get ; set;  }
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
}
