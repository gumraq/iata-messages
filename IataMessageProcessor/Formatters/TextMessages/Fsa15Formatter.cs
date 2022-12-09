using IataMessageStandard;
using IataMessageStandard.Fsa15Parts;

namespace IataMessageProcessor.Formatters.TextMessages
{
    public partial class TextMessageFormatter :
    #region inherits interfaces
    IVisitor<Fsa15, string>,
    IVisitor<StandardMessageIdentification, string>,
    IVisitor<MulticarrierConsignments, string>,
    IVisitor<StatusDetails, string>,
    IVisitor<StatusDetail, string>,
    IVisitor<OtherServiceInformation, string>,
    IVisitor<StatusDetailsRcs, string>,
    IVisitor<StatusDetailsRct, string>,
    IVisitor<StatusDetailsRcf, string>,
    IVisitor<StatusDetailsBkd, string>,
    IVisitor<StatusDetailsMan, string>,
    IVisitor<StatusDetailsDep, string>,
    IVisitor<StatusDetailsPre, string>,
    IVisitor<StatusDetailsTrm, string>,
    IVisitor<StatusDetailsTfd, string>,
    IVisitor<StatusDetailsNfd, string>,
    IVisitor<StatusDetailsAwd, string>,
    IVisitor<StatusDetailsCcd, string>,
    IVisitor<StatusDetailsDlv, string>,
    IVisitor<StatusDetailsDis, string>,
    IVisitor<StatusDetailsCrc, string>,
    IVisitor<StatusDetailsDdl, string>,
    IVisitor<StatusDetailsTgc, string>,
    IVisitor<StatusDetailsArr, string>,
    IVisitor<StatusDetailsAwr, string>,
    IVisitor<StatusDetailsFoh, string>,
    IVisitor<OtherCustSecurityAndRegulatCtrlInfo, string>,
    IVisitor<ConsignmentDetail, string>,
    IVisitor<QuantityDetail, string>,
    IVisitor<MovementDetail, string>,
    IVisitor<MovementDetailRcs, string>,
    IVisitor<MovementDetailRct, string>,
    IVisitor<MovementDetailTrm, string>,
    IVisitor<MovementDetailTfd, string>,
    IVisitor<MovementDetailNfd, string>,
    IVisitor<MovementDetailAwd, string>,
    IVisitor<MovementDetailCcd, string>,
    IVisitor<MovementDetailDlv, string>,
    IVisitor<MovementDetailDdl, string>,
    IVisitor<MovementDetailTgc, string>,
    IVisitor<MovementDetailFoh, string>,
    IVisitor<MovementDetailWithSlant, string>,
    IVisitor<MovementDetailWithFlightId, string>,
    IVisitor<ReportingDetail, string>,
    IVisitor<AwbIdentification, string>,
    IVisitor<AwbOriginAndDestination, string>,
    IVisitor<WeightInformation, string>,
    IVisitor<VolumeDetail, string>,
    IVisitor<DensityGroup, string>,
    IVisitor<VolumeOrDensity, string>,
    IVisitor<VolumeOrDensityWithCrlf, string>,
    IVisitor<VolumeOrDensityDetail, string>,
    IVisitor<TotalConsignmentPieces, string>,
    IVisitor<FlightIdentification, string>,
    IVisitor<TimeInformations, string>,
    IVisitor<TimeAndVolumeInformation, string>,
    IVisitor<TimeOfDepartureInformation, string>,
    IVisitor<TimeOfArrivalInformation, string>,
    IVisitor<TimeInformation, string>,
    IVisitor<TimeOfArrivalAndVolume, string>,
    IVisitor<DayChangeIndicator, string>,
    IVisitor<ReceivedfromDetailSep, string>,
    IVisitor<DiscrepancyDescription, string>,
    IVisitor<TransferReference, string>,
    IVisitor<TransferredFromDetail, string>,
    IVisitor<UldDescriptions, string>,
    IVisitor<UldDescription, string>,
    IVisitor<UldIdentification, string>,
    IVisitor<UldPositionInformation, string>,
    IVisitor<OsiDetails1stLine, string>,
    IVisitor<OsiDetails2stLine, string>,
    IVisitor<ReceivedFromDetail, string>,
    IVisitor<TransferredName, string>,
    IVisitor<ReceivedName, string>,
    IVisitor<NotificationToDetail, string>,
    IVisitor<DeliveryToDetail, string>,
    IVisitor<OtherCustSecurityAndRegulatCtrlInfoDet, string>
    #endregion

    {
        public string Visit(Fsa15 e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.StandardMessageIdentification)}{string.Join(string.Empty, e.MulticarrierConsignments?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }

        public string Visit(StandardMessageIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.StandardMessageIdentifier}{sSlant}{e.MessageTypeVersionNumber}{sCRLF}";
        }

        public string Visit(MulticarrierConsignments e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.ConsignmentDetail)}{string.Join(string.Empty, e.StatusDetails?.Select(this.Visit) ?? Enumerable.Empty<string>())}{this.Visit(e.OtherServiceInformation)}";
        }

        public string Visit(StatusDetails e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.StatusDetail)}{this.Visit(e.UldDescriptions)}{this.Visit(e.OtherServiceInformation)}";
        }

        public string Visit(StatusDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.StatusDetailsRcs)}{this.Visit(e.StatusDetailsRct)}{this.Visit(e.StatusDetailsRcf)}{this.Visit(e.StatusDetailsBkd)}{this.Visit(e.StatusDetailsMan)}{this.Visit(e.StatusDetailsDep)}{this.Visit(e.StatusDetailsPre)}{this.Visit(e.StatusDetailsTrm)}{this.Visit(e.StatusDetailsTfd)}{this.Visit(e.StatusDetailsNfd)}{this.Visit(e.StatusDetailsAwd)}{this.Visit(e.StatusDetailsCcd)}{this.Visit(e.StatusDetailsDlv)}{this.Visit(e.StatusDetailsDis)}{this.Visit(e.StatusDetailsCrc)}{this.Visit(e.StatusDetailsDdl)}{this.Visit(e.StatusDetailsTgc)}{this.Visit(e.StatusDetailsArr)}{this.Visit(e.StatusDetailsAwr)}{this.Visit(e.StatusDetailsFoh)}{this.Visit(e.OtherCustSecurityAndRegulatCtrlInfo)}";
        }

        public string Visit(OtherServiceInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{this.Visit(e.OsiDetails1stLine)}{this.Visit(e.OsiDetails2stLine)}";
        }

        public string Visit(StatusDetailsRcs e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierRcs}{this.Visit(e.MovementDetailRcs)}{this.Visit(e.QuantityDetail)}{this.Visit(e.ReceivedFromDetail)}{sCRLF}{this.Visit(e.VolumeOrDensityWithCrlf)}";
        }

        public string Visit(StatusDetailsRct e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierRct}{this.Visit(e.MovementDetailRct)}{this.Visit(e.QuantityDetail)}{this.Visit(e.ReceivedfromDetailSep)}{sCRLF}";
        }

        public string Visit(StatusDetailsRcf e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierRcf}{this.Visit(e.MovementDetailWithFlightId)}{this.Visit(e.QuantityDetail)}{this.Visit(e.TimeInformations)}{sCRLF}";
        }

        public string Visit(StatusDetailsBkd e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierBkd}{this.Visit(e.MovementDetail)}{this.Visit(e.QuantityDetail)}{this.Visit(e.TimeAndVolumeInformation)}{sCRLF}";
        }

        public string Visit(StatusDetailsMan e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierMan}{this.Visit(e.MovementDetail)}{this.Visit(e.QuantityDetail)}{this.Visit(e.TimeInformations)}{sCRLF}";
        }

        public string Visit(StatusDetailsDep e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierDep}{this.Visit(e.MovementDetail)}{this.Visit(e.QuantityDetail)}{this.Visit(e.TimeInformations)}{sCRLF}";
        }

        public string Visit(StatusDetailsPre e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierPre}{this.Visit(e.MovementDetail)}{this.Visit(e.QuantityDetail)}{this.Visit(e.TimeInformations)}{sCRLF}";
        }

        public string Visit(StatusDetailsTrm e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierTrm}{this.Visit(e.MovementDetailTrm)}{this.Visit(e.QuantityDetail)}{sCRLF}";
        }

        public string Visit(StatusDetailsTfd e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierTfd}{this.Visit(e.MovementDetailTfd)}{this.Visit(e.QuantityDetail)}{this.Visit(e.TransferReference)}{this.Visit(e.TransferredFromDetail)}{sCRLF}";
        }

        public string Visit(StatusDetailsNfd e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierNfd}{this.Visit(e.MovementDetailNfd)}{this.Visit(e.QuantityDetail)}{this.Visit(e.NotificationToDetail)}{sCRLF}";
        }

        public string Visit(StatusDetailsAwd e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierAwd}{this.Visit(e.MovementDetailAwd)}{this.Visit(e.QuantityDetail)}{this.Visit(e.DeliveryToDetail)}{sCRLF}";
        }

        public string Visit(StatusDetailsCcd e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierCcd}{this.Visit(e.MovementDetailCcd)}{this.Visit(e.QuantityDetail)}{sCRLF}";
        }

        public string Visit(StatusDetailsDlv e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierDlv}{this.Visit(e.MovementDetailDlv)}{this.Visit(e.QuantityDetail)}{this.Visit(e.DeliveryToDetail)}{sCRLF}";
        }

        public string Visit(StatusDetailsDis e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierDis}{this.Visit(e.MovementDetailWithFlightId)}{this.Visit(e.DiscrepancyDescription)}{this.Visit(e.QuantityDetail)}{sCRLF}";
        }

        public string Visit(StatusDetailsCrc e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierCrc}{this.Visit(e.ReportingDetail)}{this.Visit(e.QuantityDetail)}{this.Visit(e.MovementDetailWithSlant)}{sCRLF}";
        }

        public string Visit(StatusDetailsDdl e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierDdl}{this.Visit(e.MovementDetailDdl)}{this.Visit(e.QuantityDetail)}{this.Visit(e.DeliveryToDetail)}{sCRLF}";
        }

        public string Visit(StatusDetailsTgc e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierTgc}{this.Visit(e.MovementDetailTgc)}{this.Visit(e.QuantityDetail)}{sCRLF}";
        }

        public string Visit(StatusDetailsArr e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierArr}{this.Visit(e.MovementDetailWithFlightId)}{this.Visit(e.QuantityDetail)}{this.Visit(e.TimeInformations)}{sCRLF}";
        }

        public string Visit(StatusDetailsAwr e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierAwr}{this.Visit(e.MovementDetailWithFlightId)}{this.Visit(e.QuantityDetail)}{this.Visit(e.TimeInformations)}{sCRLF}";
        }

        public string Visit(StatusDetailsFoh e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierFoh}{this.Visit(e.MovementDetailFoh)}{this.Visit(e.QuantityDetail)}{this.Visit(e.ReceivedFromDetail)}{sCRLF}{this.Visit(e.VolumeOrDensityWithCrlf)}";
        }

        public string Visit(OtherCustSecurityAndRegulatCtrlInfo e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifier}{string.Join(string.Empty, e.OtherCustSecurityAndRegulatCtrlInfoDet?.Select(this.Visit) ?? Enumerable.Empty<string>())}";
        }

        public string Visit(ConsignmentDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.AwbIdentification)}{this.Visit(e.AwbOriginAndDestination)}{this.Visit(e.QuantityDetail)}{this.Visit(e.TotalConsignmentPieces)}{sCRLF}";
        }

        public string Visit(QuantityDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.ShipmentDescriptionCode}{e.NumberOfPieces}{this.Visit(e.WeightInformation)}";
        }

        public string Visit(MovementDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.CarrierCode}{e.FlightNumber}{sSlant}{e.DayOfScheduledDeparture}{e.MonthOfScheduledDeparture}{sSlant}{e.AirportCodeOfDeparture}{e.AirportCodeOfArrival}";
        }

        public string Visit(MovementDetailRcs e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DayOfReceipt}{e.MonthOfReceipt}{e.ActualTimeOfGivenStatusEvent}{sSlant}{e.AirportCodeOfReceipt}";
        }

        public string Visit(MovementDetailRct e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.TransferringCarrier}{sSlant}{e.DayOfTransfer}{e.MonthOfTransfer}{e.ActualTimeOfGivenStatusEvent}{sSlant}{e.AirportCodeOfTransfer}";
        }

        public string Visit(MovementDetailTrm e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.ReceivingCarrier}{sSlant}{e.AirportCodeOfTransfer}";
        }

        public string Visit(MovementDetailTfd e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.ReceivingCarrier}{sSlant}{e.DayOfTransfer}{e.MonthOfTransfer}{e.ActualTimeOfGivenStatusEvent}{sSlant}{e.AirportCodeOfTransfer}";
        }

        public string Visit(MovementDetailNfd e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DayOfNotification}{e.MonthOfNotification}{e.ActualTimeOfGivenStatusEvent}{sSlant}{e.AirportCodeOfNotification}";
        }

        public string Visit(MovementDetailAwd e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DayOfDelivery}{e.MonthOfDelivery}{e.ActualTimeOfGivenStatusEvent}{sSlant}{e.AirportCodeOfDelivery}";
        }

        public string Visit(MovementDetailCcd e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DayOfClearance}{e.MonthOfClearance}{e.ActualTimeOfGivenStatusEvent}{sSlant}{e.AirportCodeOfClearance}";
        }

        public string Visit(MovementDetailDlv e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DayOfDelivery}{e.MonthOfDelivery}{e.ActualTimeOfGivenStatusEvent}{sSlant}{e.AirportCodeOfDelivery}";
        }

        public string Visit(MovementDetailDdl e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DayOfDeliveryToConsigneesDoor}{e.MonthOfDeliveryToConsigneesDoor}{e.ActualTimeOfGivenStatusEvent}{sSlant}{e.AirportCodeOfDeliveryToConsigneesDoor}";
        }

        public string Visit(MovementDetailTgc e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DayOfTransfer}{e.MonthOfTransfer}{e.ActualTimeOfGivenStatusEvent}{sSlant}{e.AirportCodeOfTransfer}";
        }

        public string Visit(MovementDetailFoh e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DayOfReceipt}{e.MonthOfReceipt}{e.ActualTimeOfGivenStatusEvent}{sSlant}{e.AirportCodeOfReceipt}";
        }

        public string Visit(MovementDetailWithSlant e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.MovementDetail)}";
        }

        public string Visit(MovementDetailWithFlightId e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.FlightIdentification)}{sSlant}{e.DayOfScheduledArrival}{e.MonthOfScheduledArrival}{e.ActualTimeOfGivenStatusEvent}{this.Visit(e.DayChangeIndicator)}{sSlant}{e.AirportCodeOfArrival}";
        }

        public string Visit(ReportingDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.DayOfReporting}{e.MonthOfReporting}{e.ActualTimeOfGivenStatusEvent}{sSlant}{e.AirportCodeOfReporting}";
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

        public string Visit(WeightInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.WeightCode}{e.Weight}";
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

        public string Visit(VolumeOrDensity e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.VolumeOrDensityDetail)}";
        }

        public string Visit(VolumeOrDensityWithCrlf e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.VolumeOrDensityDetail)}{sCRLF}";
        }

        public string Visit(VolumeOrDensityDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.VolumeDetail)}{this.Visit(e.DensityGroup)}";
        }

        public string Visit(TotalConsignmentPieces e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.ShipmentDescriptionCode}{e.NumberOfPieces}";
        }

        public string Visit(FlightIdentification e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.CarrierCode}{e.FlightNumber}";
        }

        public string Visit(TimeInformations e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.TimeOfDepartureInformation)}{this.Visit(e.TimeOfArrivalInformation)}";
        }

        public string Visit(TimeAndVolumeInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.TimeOfDepartureInformation)}{this.Visit(e.TimeOfArrivalAndVolume)}";
        }

        public string Visit(TimeOfDepartureInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{this.Visit(e.TimeInformation)}";
        }

        public string Visit(TimeOfArrivalInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.TimeInformation)}";
        }

        public string Visit(TimeInformation e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.TypeOfTimeIndicator}{e.Time}{this.Visit(e.DayChangeIndicator)}";
        }

        public string Visit(TimeOfArrivalAndVolume e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.TimeInformation)}{this.Visit(e.VolumeOrDensity)}";
        }

        public string Visit(DayChangeIndicator e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sHyphen}{e.DayChangeIndicatorCode}";
        }

        public string Visit(ReceivedfromDetailSep e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.ReceivingCarrier}{this.Visit(e.ReceivedName)}";
        }

        public string Visit(DiscrepancyDescription e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.DiscrepancyCode}";
        }

        public string Visit(TransferReference e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.TransferManifestNumber}";
        }

        public string Visit(TransferredFromDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.TransferringCarrier}{this.Visit(e.TransferredName)}";
        }

        public string Visit(UldDescriptions e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{e.LineIdentifierUld}{string.Join(string.Empty, e.UldDescription?.Select(this.Visit) ?? Enumerable.Empty<string>())}{sCRLF}";
        }

        public string Visit(UldDescription e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{this.Visit(e.UldIdentification)}{this.Visit(e.UldPositionInformation)}";
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

        public string Visit(ReceivedFromDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.Name}";
        }

        public string Visit(TransferredName e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.Name}";
        }

        public string Visit(ReceivedName e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.Name}";
        }

        public string Visit(NotificationToDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.Name}";
        }

        public string Visit(DeliveryToDetail e)
        {
            if (e == null)
            {
                return string.Empty;
            }

            return $"{sSlant}{e.Name}";
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
