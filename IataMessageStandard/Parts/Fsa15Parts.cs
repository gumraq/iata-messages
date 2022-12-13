namespace IataMessageStandard.Fsa15Parts
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

    public class MulticarrierConsignments
    {
        [Reference(1)]
        public ConsignmentDetail ConsignmentDetail { get; set; }

        [Reference(2)]
        public List<StatusDetails> StatusDetails { get; set; }

        [Reference(3)]
        public OtherServiceInformation OtherServiceInformation { get; set; }
    }

    public class StatusDetails
    {
        [Reference(1)]
        public StatusDetail StatusDetail { get; set; }

        [Reference(2)]
        public UldDescriptions UldDescriptions { get; set; }

        [Reference(3)]
        public OtherServiceInformation OtherServiceInformation { get; set; }
    }

    public class StatusDetail
    {
        [Reference(1)]
        public StatusDetailsRcs StatusDetailsRcs { get; set; }

        [Reference(2)]
        public StatusDetailsRct StatusDetailsRct { get; set; }

        [Reference(3)]
        public StatusDetailsRcf StatusDetailsRcf { get; set; }

        [Reference(4)]
        public StatusDetailsBkd StatusDetailsBkd { get; set; }

        [Reference(5)]
        public StatusDetailsMan StatusDetailsMan { get; set; }

        [Reference(6)]
        public StatusDetailsDep StatusDetailsDep { get; set; }

        [Reference(7)]
        public StatusDetailsPre StatusDetailsPre { get; set; }

        [Reference(8)]
        public StatusDetailsTrm StatusDetailsTrm { get; set; }

        [Reference(9)]
        public StatusDetailsTfd StatusDetailsTfd { get; set; }

        [Reference(10)]
        public StatusDetailsNfd StatusDetailsNfd { get; set; }

        [Reference(11)]
        public StatusDetailsAwd StatusDetailsAwd { get; set; }

        [Reference(12)]
        public StatusDetailsCcd StatusDetailsCcd { get; set; }

        [Reference(13)]
        public StatusDetailsDlv StatusDetailsDlv { get; set; }

        [Reference(14)]
        public StatusDetailsDis StatusDetailsDis { get; set; }

        [Reference(15)]
        public StatusDetailsCrc StatusDetailsCrc { get; set; }

        [Reference(16)]
        public StatusDetailsDdl StatusDetailsDdl { get; set; }

        [Reference(17)]
        public StatusDetailsTgc StatusDetailsTgc { get; set; }

        [Reference(18)]
        public StatusDetailsArr StatusDetailsArr { get; set; }

        [Reference(19)]
        public StatusDetailsAwr StatusDetailsAwr { get; set; }

        [Reference(20)]
        public StatusDetailsFoh StatusDetailsFoh { get; set; }

        [Reference(21)]
        public OtherCustSecurityAndRegulatCtrlInfo OtherCustSecurityAndRegulatCtrlInfo { get; set; }
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

    public class StatusDetailsRcs
    {
        [Reference(1)]
        public string LineIdentifierRcs { get {return "RCS/";} }

        [Reference(2)]
        public MovementDetailRcs MovementDetailRcs { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public ReceivedFromDetail ReceivedFromDetail { get; set; }

        [Reference(5)]
        [SeparatorCrlf]
        public VolumeOrDensityWithCrlf VolumeOrDensityWithCrlf { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsRct
    {
        [Reference(1)]
        public string LineIdentifierRct { get {return "RCT/";} }

        [Reference(2)]
        public MovementDetailRct MovementDetailRct { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public ReceivedfromDetailSep ReceivedfromDetailSep { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsRcf
    {
        [Reference(1)]
        public string LineIdentifierRcf { get {return "RCF/";} }

        [Reference(2)]
        public MovementDetailWithFlightId MovementDetailWithFlightId { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public TimeInformations TimeInformations { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsBkd
    {
        [Reference(1)]
        public string LineIdentifierBkd { get {return "BKD/";} }

        [Reference(2)]
        public MovementDetail MovementDetail { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public TimeAndVolumeInformation TimeAndVolumeInformation { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsMan
    {
        [Reference(1)]
        public string LineIdentifierMan { get {return "MAN/";} }

        [Reference(2)]
        public MovementDetail MovementDetail { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public TimeInformations TimeInformations { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsDep
    {
        [Reference(1)]
        public string LineIdentifierDep { get {return "DEP/";} }

        [Reference(2)]
        public MovementDetail MovementDetail { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public TimeInformations TimeInformations { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsPre
    {
        [Reference(1)]
        public string LineIdentifierPre { get {return "PRE/";} }

        [Reference(2)]
        public MovementDetail MovementDetail { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public TimeInformations TimeInformations { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsTrm
    {
        [Reference(1)]
        public string LineIdentifierTrm { get {return "TRM/";} }

        [Reference(2)]
        public MovementDetailTrm MovementDetailTrm { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsTfd
    {
        [Reference(1)]
        public string LineIdentifierTfd { get {return "TFD/";} }

        [Reference(2)]
        public MovementDetailTfd MovementDetailTfd { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public TransferReference TransferReference { get; set; }

        [Reference(5)]
        public TransferredFromDetail TransferredFromDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsNfd
    {
        [Reference(1)]
        public string LineIdentifierNfd { get {return "NFD/";} }

        [Reference(2)]
        public MovementDetailNfd MovementDetailNfd { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public NotificationToDetail NotificationToDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsAwd
    {
        [Reference(1)]
        public string LineIdentifierAwd { get {return "AWD/";} }

        [Reference(2)]
        public MovementDetailAwd MovementDetailAwd { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public DeliveryToDetail DeliveryToDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsCcd
    {
        [Reference(1)]
        public string LineIdentifierCcd { get {return "CCD/";} }

        [Reference(2)]
        public MovementDetailCcd MovementDetailCcd { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsDlv
    {
        [Reference(1)]
        public string LineIdentifierDlv { get {return "DLV/";} }

        [Reference(2)]
        public MovementDetailDlv MovementDetailDlv { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public DeliveryToDetail DeliveryToDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsDis
    {
        [Reference(1)]
        public string LineIdentifierDis { get {return "DIS/";} }

        [Reference(2)]
        public MovementDetailWithFlightId MovementDetailWithFlightId { get; set; }

        [Reference(3)]
        public DiscrepancyDescription DiscrepancyDescription { get; set; }

        [Reference(4)]
        public QuantityDetail QuantityDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsCrc
    {
        [Reference(1)]
        public string LineIdentifierCrc { get {return "CRC/";} }

        [Reference(2)]
        public ReportingDetail ReportingDetail { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public MovementDetailWithSlant MovementDetailWithSlant { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsDdl
    {
        [Reference(1)]
        public string LineIdentifierDdl { get {return "DDL/";} }

        [Reference(2)]
        public MovementDetailDdl MovementDetailDdl { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public DeliveryToDetail DeliveryToDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsTgc
    {
        [Reference(1)]
        public string LineIdentifierTgc { get {return "TGC/";} }

        [Reference(2)]
        public MovementDetailTgc MovementDetailTgc { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsArr
    {
        [Reference(1)]
        public string LineIdentifierArr { get {return "ARR/";} }

        [Reference(2)]
        public MovementDetailWithFlightId MovementDetailWithFlightId { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public TimeInformations TimeInformations { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsAwr
    {
        [Reference(1)]
        public string LineIdentifierAwr { get {return "AWR/";} }

        [Reference(2)]
        public MovementDetailWithFlightId MovementDetailWithFlightId { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public TimeInformations TimeInformations { get; set; }
    }

    public class StatusDetailsFoh
    {
        [Reference(1)]
        public string LineIdentifierFoh { get {return "FOH/";} }

        [Reference(2)]
        public MovementDetailFoh MovementDetailFoh { get; set; }

        [Reference(3)]
        public QuantityDetail QuantityDetail { get; set; }

        [Reference(4)]
        public ReceivedFromDetail ReceivedFromDetail { get; set; }

        [Reference(5)]
        [SeparatorCrlf]
        public VolumeOrDensityWithCrlf VolumeOrDensityWithCrlf { get; set; }
    }

    public class OtherCustSecurityAndRegulatCtrlInfo
    {
        [Reference(1)]
        public string LineIdentifier { get; set;  }

        [Reference(2)]
        public List<OtherCustSecurityAndRegulatCtrlInfoDet> OtherCustSecurityAndRegulatCtrlInfoDet { get; set; }
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
    }

    public class QuantityDetail
    {
        [Reference(1)]
        [SeparatorSlant]
        public string ShipmentDescriptionCode { get; set;  }

        [Reference(2)]
        public string NumberOfPieces { get; set;  }

        [Reference(3)]
        public WeightInformation WeightInformation { get; set; }
    }

    public class MovementDetail
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
        public string AirportCodeOfDeparture { get; set;  }

        [Reference(6)]
        public string AirportCodeOfArrival { get; set;  }
    }

    public class MovementDetailRcs
    {
        [Reference(1)]
        public string DayOfReceipt { get; set;  }

        [Reference(2)]
        public string MonthOfReceipt { get; set;  }

        [Reference(3)]
        public string ActualTimeOfGivenStatusEvent { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public string AirportCodeOfReceipt { get; set;  }
    }

    public class MovementDetailRct
    {
        [Reference(1)]
        public string TransferringCarrier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string DayOfTransfer { get; set;  }

        [Reference(3)]
        public string MonthOfTransfer { get; set;  }

        [Reference(4)]
        public string ActualTimeOfGivenStatusEvent { get; set;  }

        [Reference(5)]
        [SeparatorSlant]
        public string AirportCodeOfTransfer { get; set;  }
    }

    public class MovementDetailTrm
    {
        [Reference(1)]
        public string ReceivingCarrier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string AirportCodeOfTransfer { get; set;  }
    }

    public class MovementDetailTfd
    {
        [Reference(1)]
        public string ReceivingCarrier { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string DayOfTransfer { get; set;  }

        [Reference(3)]
        public string MonthOfTransfer { get; set;  }

        [Reference(4)]
        public string ActualTimeOfGivenStatusEvent { get; set;  }

        [Reference(5)]
        [SeparatorSlant]
        public string AirportCodeOfTransfer { get; set;  }
    }

    public class MovementDetailNfd
    {
        [Reference(1)]
        public string DayOfNotification { get; set;  }

        [Reference(2)]
        public string MonthOfNotification { get; set;  }

        [Reference(3)]
        public string ActualTimeOfGivenStatusEvent { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public string AirportCodeOfNotification { get; set;  }
    }

    public class MovementDetailAwd
    {
        [Reference(1)]
        public string DayOfDelivery { get; set;  }

        [Reference(2)]
        public string MonthOfDelivery { get; set;  }

        [Reference(3)]
        public string ActualTimeOfGivenStatusEvent { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public string AirportCodeOfDelivery { get; set;  }
    }

    public class MovementDetailCcd
    {
        [Reference(1)]
        public string DayOfClearance { get; set;  }

        [Reference(2)]
        public string MonthOfClearance { get; set;  }

        [Reference(3)]
        public string ActualTimeOfGivenStatusEvent { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public string AirportCodeOfClearance { get; set;  }
    }

    public class MovementDetailDlv
    {
        [Reference(1)]
        public string DayOfDelivery { get; set;  }

        [Reference(2)]
        public string MonthOfDelivery { get; set;  }

        [Reference(3)]
        public string ActualTimeOfGivenStatusEvent { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public string AirportCodeOfDelivery { get; set;  }
    }

    public class MovementDetailDdl
    {
        [Reference(1)]
        public string DayOfDeliveryToConsigneesDoor { get; set;  }

        [Reference(2)]
        public string MonthOfDeliveryToConsigneesDoor { get; set;  }

        [Reference(3)]
        public string ActualTimeOfGivenStatusEvent { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public string AirportCodeOfDeliveryToConsigneesDoor { get; set;  }
    }

    public class MovementDetailTgc
    {
        [Reference(1)]
        public string DayOfTransfer { get; set;  }

        [Reference(2)]
        public string MonthOfTransfer { get; set;  }

        [Reference(3)]
        public string ActualTimeOfGivenStatusEvent { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public string AirportCodeOfTransfer { get; set;  }
    }

    public class MovementDetailFoh
    {
        [Reference(1)]
        public string DayOfReceipt { get; set;  }

        [Reference(2)]
        public string MonthOfReceipt { get; set;  }

        [Reference(3)]
        public string ActualTimeOfGivenStatusEvent { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public string AirportCodeOfReceipt { get; set;  }
    }

    public class MovementDetailWithSlant
    {
        [SeparatorSlant]
        public MovementDetail MovementDetail { get; set; }
    }

    public class MovementDetailWithFlightId
    {
        [Reference(1)]
        public FlightIdentification FlightIdentification { get; set; }

        [Reference(2)]
        [SeparatorSlant]
        public string DayOfScheduledArrival { get; set;  }

        [Reference(3)]
        public string MonthOfScheduledArrival { get; set;  }

        [Reference(4)]
        public string ActualTimeOfGivenStatusEvent { get; set;  }

        [Reference(5)]
        public DayChangeIndicator DayChangeIndicator { get; set; }

        [Reference(6)]
        [SeparatorSlant]
        public string AirportCodeOfArrival { get; set;  }
    }

    public class ReportingDetail
    {
        [Reference(1)]
        public string DayOfReporting { get; set;  }

        [Reference(2)]
        public string MonthOfReporting { get; set;  }

        [Reference(3)]
        public string ActualTimeOfGivenStatusEvent { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public string AirportCodeOfReporting { get; set;  }
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

    public class WeightInformation
    {
        [Reference(1)]
        public string WeightCode { get; set;  }

        [Reference(2)]
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

    public class VolumeOrDensity
    {
        [SeparatorSlant]
        public VolumeOrDensityDetail VolumeOrDensityDetail { get; set; }
    }

    [SeparatorCrlf]
    public class VolumeOrDensityWithCrlf
    {
        [SeparatorSlant]
        public VolumeOrDensityDetail VolumeOrDensityDetail { get; set; }
    }

    public class VolumeOrDensityDetail
    {
        [Reference(1)]
        public VolumeDetail VolumeDetail { get; set; }

        [Reference(2)]
        public DensityGroup DensityGroup { get; set; }
    }

    public class TotalConsignmentPieces
    {
        [Reference(1)]
        public string ShipmentDescriptionCode { get; set;  }

        [Reference(2)]
        public string NumberOfPieces { get; set;  }
    }

    public class FlightIdentification
    {
        [Reference(1)]
        public string CarrierCode { get; set;  }

        [Reference(2)]
        public string FlightNumber { get; set;  }
    }

    public class TimeInformations
    {
        [Reference(1)]
        [SeparatorSlant]
        public TimeOfDepartureInformation TimeOfDepartureInformation { get; set; }

        [Reference(2)]
        public TimeOfArrivalInformation TimeOfArrivalInformation { get; set; }
    }

    public class TimeAndVolumeInformation
    {
        [Reference(1)]
        [SeparatorSlant]
        public TimeOfDepartureInformation TimeOfDepartureInformation { get; set; }

        [Reference(2)]
        public TimeOfArrivalAndVolume TimeOfArrivalAndVolume { get; set; }
    }

    public class TimeOfDepartureInformation
    {
        public TimeInformation TimeInformation { get; set; }
    }

    public class TimeOfArrivalInformation
    {
        [SeparatorSlant]
        public TimeInformation TimeInformation { get; set; }
    }

    public class TimeInformation
    {
        [Reference(1)]
        public string TypeOfTimeIndicator { get; set;  }

        [Reference(2)]
        public string Time { get; set;  }

        [Reference(3)]
        public DayChangeIndicator DayChangeIndicator { get; set; }
    }

    public class TimeOfArrivalAndVolume
    {
        [Reference(1)]
        [SeparatorSlant]
        public TimeInformation TimeInformation { get; set; }

        [Reference(2)]
        public VolumeOrDensity VolumeOrDensity { get; set; }
    }

    public class DayChangeIndicator
    {
        [SeparatorHyphen]
        public string DayChangeIndicatorCode { get; set;  }
    }

    public class ReceivedfromDetailSep
    {
        [Reference(1)]
        [SeparatorCrlf]
        [SeparatorSlant]
        public string ReceivingCarrier { get; set;  }

        [Reference(2)]
        public ReceivedName ReceivedName { get; set; }
    }

    public class DiscrepancyDescription
    {
        [SeparatorSlant]
        public string DiscrepancyCode { get; set;  }
    }

    public class TransferReference
    {
        [SeparatorSlant]
        public string TransferManifestNumber { get; set;  }
    }

    public class TransferredFromDetail
    {
        [Reference(1)]
        [SeparatorCrlf]
        [SeparatorSlant]
        public string TransferringCarrier { get; set;  }

        [Reference(2)]
        public TransferredName TransferredName { get; set; }
    }

    [SeparatorCrlf]
    public class UldDescriptions
    {
        [Reference(1)]
        public string LineIdentifierUld { get {return "ULD";} }

        [Reference(2)]
        public List<UldDescription> UldDescription { get; set; }
    }

    public class UldDescription
    {
        [Reference(1)]
        [SeparatorSlant]
        public UldIdentification UldIdentification { get; set; }

        [Reference(2)]
        public UldPositionInformation UldPositionInformation { get; set; }
    }

    public class UldIdentification
    {
        [Reference(1)]
        public string UldType { get; set;  }

        [Reference(2)]
        public string UldSerialNumber { get; set;  }

        [Reference(3)]
        public string UldOwnerCode { get; set;  }
    }

    public class UldPositionInformation
    {
        [SeparatorHyphen]
        public string UldLoadingIndicator { get; set;  }
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

    public class ReceivedFromDetail
    {
        [SeparatorSlant]
        public string Name { get; set;  }
    }

    public class TransferredName
    {
        [SeparatorSlant]
        public string Name { get; set;  }
    }

    public class ReceivedName
    {
        [SeparatorSlant]
        public string Name { get; set;  }
    }

    public class NotificationToDetail
    {
        [SeparatorSlant]
        public string Name { get; set;  }
    }

    public class DeliveryToDetail
    {
        [SeparatorSlant]
        public string Name { get; set;  }
    }

    [SeparatorCrlf]
    public class OtherCustSecurityAndRegulatCtrlInfoDet
    {
        [Reference(1)]
        [SeparatorSlant]
        public string IsoCountryCode { get; set;  }

        [Reference(2)]
        [SeparatorSlant]
        public string InformationIdentifier { get; set;  }

        [Reference(3)]
        [SeparatorSlant]
        public string CustSecurityAndRegulatCtrlInfoId { get; set;  }

        [Reference(4)]
        [SeparatorSlant]
        public string SupplemCustSecurityAndRegulatCtrlInfo { get; set;  }
    }
}
