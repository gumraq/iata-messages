using IataMessageStandard;
using IataMessageStandard.Fbr2Parts;

namespace IataMessageProcessor.Formatters.TextMessages
{
    public partial class TextMessageFormatter :
    #region inherits interfaces
    IVisitor<Fbr2, string>,
    IVisitor<StandardMessageIdentification, string>,
    IVisitor<FlightInformation, string>,
    IVisitor<RequestReference, string>,
    IVisitor<FlightIdentification, string>,
    IVisitor<RequestingOfficeMessageAddress, string>,
    IVisitor<Rofr, string>,
    IVisitor<RequestingOfficeFileReference, string>,
    IVisitor<RequestingParticipantIdentification, string>
    #endregion

    {
        public string Visit(Fbr2 e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.StandardMessageIdentification)}{this.Visit(e.FlightInformation)}{this.Visit(e.RequestReference)}";
        }

        public string Visit(StandardMessageIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.StandardMessageIdentifier}{sSlant}{e.MessageTypeVersionNumber}{sCRLF}";
        }

        public string Visit(FlightInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{sSlant}{this.Visit(e.FlightIdentification)}{sCRLF}";
        }

        public string Visit(RequestReference e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{sSlant}{this.Visit(e.RequestingOfficeMessageAddress)}{this.Visit(e.Rofr)}{sCRLF}";
        }

        public string Visit(FlightIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.CarrierCode}{e.FlightNumber}{sSlant}{e.DayOfScheduledDeparture}{e.MonthOfScheduledDeparture}{sSlant}{e.AirportCodeOfLoading}{e.AirportCodeOfUnloading}";
        }

        public string Visit(RequestingOfficeMessageAddress e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.AirportCityCode}{e.OfficeFunctionDesignator}{e.CompanyDesignator}";
        }

        public string Visit(Rofr e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.RequestingOfficeFileReference)}{this.Visit(e.RequestingParticipantIdentification)}";
        }

        public string Visit(RequestingOfficeFileReference e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.FileReference}";
        }

        public string Visit(RequestingParticipantIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.ParticipantIdentifier}{sSlant}{e.ParticipantCode}{sSlant}{e.AirportCityCode}";
        }
    }
}
