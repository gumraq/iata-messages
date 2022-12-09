using IataMessageStandard;
using IataMessageStandard.Ffa4Parts;

namespace IataMessageProcessor.Formatters.TextMessages
{
    public partial class TextMessageFormatter :
    #region inherits interfaces
    IVisitor<Ffa4, string>,
    IVisitor<StandardMessageIdentification, string>,
    IVisitor<ConsignmentDetail, string>,
    IVisitor<FlightDetails, string>,
    IVisitor<SpecialServiceRequest, string>,
    IVisitor<OtherServiceInformation, string>,
    IVisitor<BookingReference, string>,
    IVisitor<ShipmentReferenceInformation, string>,
    IVisitor<FlightInfoDetails, string>,
    IVisitor<FlightIdentification, string>,
    IVisitor<AirportsOfDepartureAndArrival, string>,
    IVisitor<AwbIdentification, string>,
    IVisitor<AwbOriginAndDestination, string>,
    IVisitor<QuantityDetail, string>,
    IVisitor<VolumeDetail, string>,
    IVisitor<DensityGroup, string>,
    IVisitor<TotalConsignmentPieces, string>,
    IVisitor<Shrs, string>,
    IVisitor<SpecialHandlingRequirements, string>,
    IVisitor<SsrDetails1stLine, string>,
    IVisitor<SsrDetails2stLine, string>,
    IVisitor<OsiDetails1stLine, string>,
    IVisitor<OsiDetails2stLine, string>,
    IVisitor<NatureOfGoods, string>,
    IVisitor<RequestingOfficeMessageAddress, string>,
    IVisitor<Rofr, string>,
    IVisitor<RequestingOfficeFileReference, string>,
    IVisitor<RequestingParticipantIdentification, string>,
    IVisitor<Supplementary1or2, string>,
    IVisitor<SupplementaryShipmentInformation1, string>,
    IVisitor<SupplementaryShipmentInformation2, string>
    #endregion

    {
        public string Visit(Ffa4 e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.StandardMessageIdentification)}{this.Visit(e.ConsignmentDetail)}{this.Visit(e.FlightDetails)}{this.Visit(e.SpecialServiceRequest)}{this.Visit(e.OtherServiceInformation)}{this.Visit(e.BookingReference)}{this.Visit(e.ShipmentReferenceInformation)}";
        }

        public string Visit(StandardMessageIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.StandardMessageIdentifier}{sSlant}{e.MessageTypeVersionNumber}{sCRLF}";
        }

        public string Visit(ConsignmentDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.AwbIdentification)}{this.Visit(e.AwbOriginAndDestination)}{this.Visit(e.QuantityDetail)}{this.Visit(e.VolumeDetail)}{this.Visit(e.DensityGroup)}{this.Visit(e.TotalConsignmentPieces)}{this.Visit(e.NatureOfGoods)}{this.Visit(e.Shrs)}{sCRLF}";
        }

        public string Visit(FlightDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{string.Join(string.Empty, e.FlightInfoDetails?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }

        public string Visit(SpecialServiceRequest e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierSsr}{this.Visit(e.SsrDetails1stLine)}{this.Visit(e.SsrDetails2stLine)}";
        }

        public string Visit(OtherServiceInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierOsi}{this.Visit(e.OsiDetails1stLine)}{this.Visit(e.OsiDetails2stLine)}";
        }

        public string Visit(BookingReference e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{sSlant}{this.Visit(e.RequestingOfficeMessageAddress)}{this.Visit(e.Rofr)}{sCRLF}";
        }

        public string Visit(ShipmentReferenceInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{sSlant}{e.ReferenceNumber}{this.Visit(e.Supplementary1or2)}{sCRLF}";
        }

        public string Visit(FlightInfoDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.FlightIdentification)}{sSlant}{this.Visit(e.AirportsOfDepartureAndArrival)}{sSlant}{e.SpaceAllocationCode}{sCRLF}";
        }

        public string Visit(FlightIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.CarrierCode}{e.FlightNumber}{sSlant}{e.DayOfScheduledDeparture}{e.MonthOfScheduledDeparture}";
        }

        public string Visit(AirportsOfDepartureAndArrival e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.AirportCodeOfDeparture}{e.AirportCodeOfArrival}";
        }

        public string Visit(AwbIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.AirlinePrefix}{sHyphen}{e.AwbSerialNumber}";
        }

        public string Visit(AwbOriginAndDestination e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.AirportCodeOfOrigin}{e.AirportCodeOfDestitation}";
        }

        public string Visit(QuantityDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.ShipmentDescriptionCode}{e.NumberOfPieces}{e.WeightCode}{e.Weight}";
        }

        public string Visit(VolumeDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.VolumeCode}{e.VolumeAmount}";
        }

        public string Visit(DensityGroup e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DensityIndicator}{e.DensityGroupInner}";
        }

        public string Visit(TotalConsignmentPieces e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.ShipmentDescriptionCode}{e.NumberOfPieces}";
        }

        public string Visit(Shrs e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sCRLF}{string.Join(string.Empty, e.SpecialHandlingRequirements?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }

        public string Visit(SpecialHandlingRequirements e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.SpecialHandlingCode}";
        }

        public string Visit(SsrDetails1stLine e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.SsrDescription}{sCRLF}";
        }

        public string Visit(SsrDetails2stLine e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.SsrDescription}{sCRLF}";
        }

        public string Visit(OsiDetails1stLine e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.OsiDescription}{sCRLF}";
        }

        public string Visit(OsiDetails2stLine e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.OsiDescription}{sCRLF}";
        }

        public string Visit(NatureOfGoods e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.ManifestDescriptionOfGoods}";
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

        public string Visit(Supplementary1or2 e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.SupplementaryShipmentInformation1)}{this.Visit(e.SupplementaryShipmentInformation2)}";
        }

        public string Visit(SupplementaryShipmentInformation1 e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.InnerSupplementaryShipmentInformation}";
        }

        public string Visit(SupplementaryShipmentInformation2 e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.InnerSupplementaryShipmentInformation}";
        }
    }
}
