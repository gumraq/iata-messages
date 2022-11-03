using System.Linq;

using IataMessagesProcessor.Messages;
using IataMessagesProcessor.Messages.Ffm8Parts;

namespace IataMessagesProcessor.Formatters.TextMessages
{
    public partial class TextMessageFormatter :
    #region inherits interfaces
        IVisitor<Ffm8, string>,
        IVisitor<StandardMessageIdentification, string>,
        IVisitor<FlightIdAndPointOfLoading, string>,
        IVisitor<DestinationHeader, string>,
        IVisitor<ManifestCompleteIndicator, string>,
        IVisitor<PointOfUnloading, string>,
        IVisitor<BulkLoadedCargo, string>,
        IVisitor<UldLoadedCargo, string>,
        IVisitor<Consignments, string>,
        IVisitor<UldDescription, string>,
        IVisitor<UldMovementInformation, string>,
        IVisitor<UldUtilisationDetail, string>,
        IVisitor<OtherServiceInformation, string>,
        IVisitor<CustomsOrigin, string>,
        IVisitor<OtherCustSecurityAndRegulatCtrlInfo, string>,
        IVisitor<FlightIdentification, string>,
        IVisitor<FirstPointOfArrivalInformation, string>,
        IVisitor<NilCargoIndication, string>,
        IVisitor<AircraftIdentification, string>,
        IVisitor<ArrivalInformation, string>,
        IVisitor<DepartureInformation, string>,
        IVisitor<ArrivalInformationDetail, string>,
        IVisitor<DepartureInformationDetail, string>,
        IVisitor<AwbIdentification, string>,
        IVisitor<AwbOriginAndDestination, string>,
        IVisitor<QuantityDetail, string>,
        IVisitor<VolumeDetail, string>,
        IVisitor<DensityGroup, string>,
        IVisitor<TotalWeightDetails, string>,
        IVisitor<TotalConsignmentPieces, string>,
        IVisitor<Shrs, string>,
        IVisitor<SpecialHandlingRequirements, string>,
        IVisitor<ConsignmentDetail, string>,
        IVisitor<DimensionsInformation, string>,
        IVisitor<ConsignmentOnwardMovementInfo, string>,
        IVisitor<ConsignmentOnward, string>,
        IVisitor<OnwardRoutingDetail, string>,
        IVisitor<OnwardBookingDetail, string>,
        IVisitor<OsiDetails1stLine, string>,
        IVisitor<OsiDetails2stLine, string>,
        IVisitor<UldOnwardRoutingDetail, string>,
        IVisitor<UldOnwardBookingDetail, string>,
        IVisitor<UldIdentification, string>,
        IVisitor<UldPositionInformation, string>,
        IVisitor<UldRemarks, string>,
        IVisitor<MovementPriority, string>,
        IVisitor<NatureOfGoods, string>,
        IVisitor<Dimensions, string>,
        IVisitor<DimensionsDetails, string>,
        IVisitor<OtherCustSecurityAndRegulatCtrlInfoDet, string>
    #endregion

    {
        public string Visit(Ffm8 e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.StandardMessageIdentification)}{this.Visit(e.FlightIdAndPointOfLoading)}{string.Join(string.Empty, e.DestinationHeader?.Select(this.Visit) ?? Enumerable.Empty<string>())}{this.Visit(e.ManifestCompleteIndicator)}";
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

            return $"{e.MessageSequenceNumber}{sSlant}{this.Visit(e.FlightIdentification)}{sSlant}{e.AirportCodeOfLoading}{this.Visit(e.AircraftIdentification)}{this.Visit(e.FirstPointOfArrivalInformation)}{sCRLF}";
        }
        public string Visit(DestinationHeader e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.PointOfUnloading)}{this.Visit(e.BulkLoadedCargo)}{string.Join(string.Empty, e.UldLoadedCargo?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }
        public string Visit(ManifestCompleteIndicator e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.EndOfMessageCode}{sCRLF}";
        }
        public string Visit(PointOfUnloading e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.AirportCodeOfUnloading}{this.Visit(e.NilCargoIndication)}{this.Visit(e.ArrivalInformation)}{this.Visit(e.DepartureInformation)}{sCRLF}";
        }
        public string Visit(BulkLoadedCargo e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{string.Join(string.Empty, e.Consignments?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }
        public string Visit(UldLoadedCargo e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.UldDescription)}{string.Join(string.Empty, e.UldMovementInformation?.Select(this.Visit) ?? Enumerable.Empty<string>())}{this.Visit(e.UldUtilisationDetail)}{string.Join(string.Empty, e.Consignments?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }
        public string Visit(Consignments e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.ConsignmentDetail)}{this.Visit(e.DimensionsInformation)}{this.Visit(e.ConsignmentOnwardMovementInfo)}{this.Visit(e.OtherServiceInformation)}{this.Visit(e.CustomsOrigin)}{this.Visit(e.OtherCustSecurityAndRegulatCtrlInfo)}";
        }
        public string Visit(UldDescription e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierUld}{this.Visit(e.UldIdentification)}{this.Visit(e.UldPositionInformation)}{this.Visit(e.UldRemarks)}{sCRLF}";
        }
        public string Visit(UldMovementInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.UldOnwardRoutingDetail)}{this.Visit(e.UldOnwardBookingDetail)}{sCRLF}";
        }
        public string Visit(UldUtilisationDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.UldVolumeAvailableCode}{sCRLF}";
        }
        public string Visit(OtherServiceInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{this.Visit(e.OsiDetails1stLine)}{this.Visit(e.OsiDetails2stLine)}";
        }
        public string Visit(CustomsOrigin e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{sSlant}{e.CustomsOriginCode}{sCRLF}";
        }
        public string Visit(OtherCustSecurityAndRegulatCtrlInfo e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{string.Join(string.Empty, e.OtherCustSecurityAndRegulatCtrlInfoDet?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }
        public string Visit(FlightIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.CarrierCode}{e.FlightNumber}{sSlant}{e.DayOfScheduledDeparture}{e.MonthOfScheduledDeparture}{e.TimeOfScheduledDeparture}";
        }
        public string Visit(FirstPointOfArrivalInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.IsoCountryCode}{sSlant}{e.DayOfScheduledArrival}{e.MonthOfScheduledArrival}{e.TimeOfScheduledArrival}{sSlant}{e.AirportCodeOfArrival}";
        }
        public string Visit(NilCargoIndication e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.NilCargoCode}";
        }
        public string Visit(AircraftIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.AircraftRegistration}";
        }
        public string Visit(ArrivalInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.ArrivalInformationDetail)}";
        }
        public string Visit(DepartureInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.DepartureInformationDetail)}";
        }
        public string Visit(ArrivalInformationDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DayOfScheduledArrival}{e.MonthOfScheduledArrival}{e.TimeOfScheduledArrival}";
        }
        public string Visit(DepartureInformationDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DayOfScheduledDeparture}{e.MonthOfScheduledDeparture}{e.TimeOfScheduledDeparture}";
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
        public string Visit(ConsignmentOnwardMovementInfo e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{string.Join(string.Empty, e.ConsignmentOnward?.Select(this.Visit) ?? Enumerable.Empty<string>())}{this.Visit(e.MovementPriority)}";
        }
        public string Visit(ConsignmentOnward e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.OnwardRoutingDetail)}{this.Visit(e.OnwardBookingDetail)}{sCRLF}";
        }
        public string Visit(OnwardRoutingDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.AirportCodeOfNextDestination}{e.CarrierCode}";
        }
        public string Visit(OnwardBookingDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.FlightNumber}{sSlant}{e.DayOfScheduledDeparture}{e.MonthOfScheduledDeparture}";
        }
        public string Visit(OsiDetails1stLine e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.OsiDescription}{sCRLF}";
        }
        public string Visit(OsiDetails2stLine e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.OsiDescription}{sCRLF}";
        }
        public string Visit(UldOnwardRoutingDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.AirportCodeOfNextDestination}{e.CarrierCode}";
        }
        public string Visit(UldOnwardBookingDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.FlightNumber}{sSlant}{e.DayOfScheduledDeparture}{e.MonthOfScheduledDeparture}";
        }
        public string Visit(UldIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.UldType}{e.UldSerialNumber}{e.UldOwnerCode}";
        }
        public string Visit(UldPositionInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sHyphen}{e.UldLoadingIndicator}";
        }
        public string Visit(UldRemarks e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.UldRemarksDescription}";
        }
        public string Visit(MovementPriority e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.MovementPriorityCode}{sCRLF}";
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
