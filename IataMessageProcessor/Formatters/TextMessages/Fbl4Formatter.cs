using IataMessageStandard;
using IataMessageStandard.Fbl4Parts;

namespace IataMessageProcessor.Formatters.TextMessages
{
    public partial class TextMessageFormatter :
    #region inherits interfaces
        IVisitor<Fbl4, string>,
        IVisitor<StandardMessageIdentification, string>,
        IVisitor<FlightIdAndPointOfLoading, string>,
        IVisitor<DestinationHeader, string>,
        IVisitor<ListCompleteIndicator, string>,
        IVisitor<FlightIdentification, string>,
        IVisitor<AircraftIdentification, string>,
        IVisitor<PointOfUnloading, string>,
        IVisitor<BookedCargo, string>,
        IVisitor<ConsignmentDetail, string>,
        IVisitor<DimensionsInformation, string>,
        IVisitor<ConsignmentOriginInformation, string>,
        IVisitor<ConsignmentOriginInfoDetail, string>,
        IVisitor<UldDescription, string>,
        IVisitor<SpecialServiceRequest, string>,
        IVisitor<OtherServiceInformation, string>,
        IVisitor<OtherCustSecurityAndRegulatCtrlInfo, string>,
        IVisitor<NilCargoIndication, string>,
        IVisitor<AwbIdentification, string>,
        IVisitor<AwbOriginAndDestination, string>,
        IVisitor<QuantityDetail, string>,
        IVisitor<VolumeDetail, string>,
        IVisitor<DensityGroup, string>,
        IVisitor<TotalWeightDetails, string>,
        IVisitor<TotalConsignmentPieces, string>,
        IVisitor<Shrs, string>,
        IVisitor<SpecialHandlingRequirements, string>,
        IVisitor<SsrDetails1stLine, string>,
        IVisitor<SsrDetails2stLine, string>,
        IVisitor<OsiDetails1stLine, string>,
        IVisitor<OsiDetails2stLine, string>,
        IVisitor<UldDescriptionItems, string>,
        IVisitor<UldDescriptionInnerItems, string>,
        IVisitor<UldIdentification, string>,
        IVisitor<UldNumber, string>,
        IVisitor<UldPositionInformation, string>,
        IVisitor<WeightOfUldContents, string>,
        IVisitor<ForwardingAgent, string>,
        IVisitor<InwardFlightDetails, string>,
        IVisitor<MovementPriority, string>,
        IVisitor<NatureOfGoods, string>,
        IVisitor<Dimensions, string>,
        IVisitor<DimensionsDetails, string>,
        IVisitor<OtherCustSecurityAndRegulatCtrlInfoDet, string>
    #endregion

    {
        public string Visit(Fbl4 e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.StandardMessageIdentification)}{this.Visit(e.FlightIdAndPointOfLoading)}{string.Join(string.Empty, e.DestinationHeader?.Select(this.Visit) ?? Enumerable.Empty<string>())}{this.Visit(e.ListCompleteIndicator)}";
        }
        public string Visit(StandardMessageIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.StandardMessageIdentifier}{sSlant}{e.MessageTypeVersionNumber}{sCRLF}";
        }
        public string Visit(FlightIdAndPointOfLoading e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.MessageSequenceNumber}{sSlant}{this.Visit(e.FlightIdentification)}{sSlant}{e.AirportCodeOfLoading}{this.Visit(e.AircraftIdentification)}{sCRLF}";
        }
        public string Visit(DestinationHeader e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.PointOfUnloading)}{string.Join(string.Empty, e.BookedCargo?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }
        public string Visit(ListCompleteIndicator e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.EndOfMessageCode}{sCRLF}";
        }
        public string Visit(FlightIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.CarrierCode}{e.FlightNumber}{sSlant}{e.DayOfScheduledDeparture}{e.MonthOfScheduledDeparture}";
        }
        public string Visit(AircraftIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.AircraftRegistration}";
        }
        public string Visit(PointOfUnloading e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.AirportCodeOfUnloading}{this.Visit(e.NilCargoIndication)}{sCRLF}";
        }
        public string Visit(BookedCargo e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.ConsignmentDetail)}{this.Visit(e.DimensionsInformation)}{this.Visit(e.ConsignmentOriginInformation)}{this.Visit(e.UldDescription)}{this.Visit(e.SpecialServiceRequest)}{this.Visit(e.OtherServiceInformation)}{this.Visit(e.OtherCustSecurityAndRegulatCtrlInfo)}";
        }
        public string Visit(ConsignmentDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.AwbIdentification)}{this.Visit(e.AwbOriginAndDestination)}{this.Visit(e.QuantityDetail)}{this.Visit(e.VolumeDetail)}{this.Visit(e.DensityGroup)}{this.Visit(e.TotalConsignmentPieces)}{this.Visit(e.NatureOfGoods)}{this.Visit(e.Shrs)}{sCRLF}";
        }
        public string Visit(DimensionsInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{string.Join(string.Empty, e.Dimensions?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }
        public string Visit(ConsignmentOriginInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.ConsignmentOriginInfoDetail)}{sCRLF}";
        }
        public string Visit(ConsignmentOriginInfoDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.ForwardingAgent)}{this.Visit(e.InwardFlightDetails)}{this.Visit(e.MovementPriority)}";
        }
        public string Visit(UldDescription e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierUld}{e.NumberOfUldsTotal}{string.Join(string.Empty, e.UldDescriptionItems?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
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
        public string Visit(OtherCustSecurityAndRegulatCtrlInfo e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{string.Join(string.Empty, e.OtherCustSecurityAndRegulatCtrlInfoDet?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }
        public string Visit(NilCargoIndication e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.NilCargoCode}";
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
        public string Visit(TotalWeightDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.WeightCode}{e.Weight}";
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
        public string Visit(UldDescriptionItems e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{string.Join(string.Empty, e.UldDescriptionInnerItems?.Select(this.Visit) ?? Enumerable.Empty<string>())}{sCRLF}";
        }
        public string Visit(UldDescriptionInnerItems e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.UldIdentification)}{this.Visit(e.UldPositionInformation)}{this.Visit(e.WeightOfUldContents)}";
        }
        public string Visit(UldIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.UldType}{this.Visit(e.UldNumber)}";
        }
        public string Visit(UldNumber e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.UldSerialNumber}{e.UldOwnerCode}";
        }
        public string Visit(UldPositionInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sHyphen}{e.UldLoadingIndicator}";
        }
        public string Visit(WeightOfUldContents e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.WeightCode}{e.Weight}";
        }
        public string Visit(ForwardingAgent e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.AbbreviatedName}";
        }
        public string Visit(InwardFlightDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.CarrierCode}{e.FlightNumber}{sSlant}{e.DayOfArrival}{e.MonthOfArrival}{sSlant}{e.AirportCodeOfLoading}";
        }
        public string Visit(MovementPriority e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.MovementPriorityCode}";
        }
        public string Visit(NatureOfGoods e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.ManifestDescriptionOfGoods}";
        }
        public string Visit(Dimensions e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.TotalWeightDetails)}{sSlant}{this.Visit(e.DimensionsDetails)}{sSlant}{e.NumberOfPieces}{sCRLF}";
        }
        public string Visit(DimensionsDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.MeasurementUnitCode}{e.LengthDimension}{sHyphen}{e.WidthDimension}{sHyphen}{e.HeightDimension}";
        }
        public string Visit(OtherCustSecurityAndRegulatCtrlInfoDet e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.IsoCountryCode}{sSlant}{e.InformationIdentifier}{sSlant}{e.CustSecurityAndRegulatCtrlInfoId}{sSlant}{e.SupplemCustSecurityAndRegulatCtrlInfo}{sCRLF}";
        }

    }

}
