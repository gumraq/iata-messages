namespace IataMessageStandard.Fsa15Parts
{
    [SeparatorCrlf]
    public class StandardMessageIdentification
    {
        public string StandardMessageIdentifier { get ; set;  }
        [SeparatorSlant]
        public string MessageTypeVersionNumber { get ; set;  }
    }

    public class MulticarrierConsignments
    {
        public ConsignmentDetail ConsignmentDetail { get; set; }
        public List<StatusDetails> StatusDetails { get; set; }
        public OtherServiceInformation OtherServiceInformation { get; set; }
    }

    public class StatusDetails
    {
        public StatusDetail StatusDetail { get; set; }
        public UldDescriptions UldDescriptions { get; set; }
        public OtherServiceInformation OtherServiceInformation { get; set; }
    }

    public class StatusDetail
    {
        public StatusDetailsRcs StatusDetailsRcs { get; set; }
        public StatusDetailsRct StatusDetailsRct { get; set; }
        public StatusDetailsRcf StatusDetailsRcf { get; set; }
        public StatusDetailsBkd StatusDetailsBkd { get; set; }
        public StatusDetailsMan StatusDetailsMan { get; set; }
        public StatusDetailsDep StatusDetailsDep { get; set; }
        public StatusDetailsPre StatusDetailsPre { get; set; }
        public StatusDetailsTrm StatusDetailsTrm { get; set; }
        public StatusDetailsTfd StatusDetailsTfd { get; set; }
        public StatusDetailsNfd StatusDetailsNfd { get; set; }
        public StatusDetailsAwd StatusDetailsAwd { get; set; }
        public StatusDetailsCcd StatusDetailsCcd { get; set; }
        public StatusDetailsDlv StatusDetailsDlv { get; set; }
        public StatusDetailsDis StatusDetailsDis { get; set; }
        public StatusDetailsCrc StatusDetailsCrc { get; set; }
        public StatusDetailsDdl StatusDetailsDdl { get; set; }
        public StatusDetailsTgc StatusDetailsTgc { get; set; }
        public StatusDetailsArr StatusDetailsArr { get; set; }
        public StatusDetailsAwr StatusDetailsAwr { get; set; }
        public StatusDetailsFoh StatusDetailsFoh { get; set; }
        public OtherCustSecurityAndRegulatCtrlInfo OtherCustSecurityAndRegulatCtrlInfo { get; set; }
    }

    public class OtherServiceInformation
    {
        public string LineIdentifier { get ; set;  }
        public OsiDetails1stLine OsiDetails1stLine { get; set; }
        public OsiDetails2stLine OsiDetails2stLine { get; set; }
    }

    public class StatusDetailsRcs
    {
        public string LineIdentifierRcs { get {return "RCS/";} }
        public MovementDetailRcs MovementDetailRcs { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public ReceivedFromDetail ReceivedFromDetail { get; set; }
        [SeparatorCrlf]
        public VolumeOrDensityWithCrlf VolumeOrDensityWithCrlf { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsRct
    {
        public string LineIdentifierRct { get {return "RCT/";} }
        public MovementDetailRct MovementDetailRct { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public ReceivedfromDetailSep ReceivedfromDetailSep { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsRcf
    {
        public string LineIdentifierRcf { get {return "RCF/";} }
        public MovementDetailWithFlightId MovementDetailWithFlightId { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public TimeInformations TimeInformations { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsBkd
    {
        public string LineIdentifierBkd { get {return "BKD/";} }
        public MovementDetail MovementDetail { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public TimeAndVolumeInformation TimeAndVolumeInformation { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsMan
    {
        public string LineIdentifierMan { get {return "MAN/";} }
        public MovementDetail MovementDetail { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public TimeInformations TimeInformations { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsDep
    {
        public string LineIdentifierDep { get {return "DEP/";} }
        public MovementDetail MovementDetail { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public TimeInformations TimeInformations { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsPre
    {
        public string LineIdentifierPre { get {return "PRE/";} }
        public MovementDetail MovementDetail { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public TimeInformations TimeInformations { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsTrm
    {
        public string LineIdentifierTrm { get {return "TRM/";} }
        public MovementDetailTrm MovementDetailTrm { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsTfd
    {
        public string LineIdentifierTfd { get {return "TFD/";} }
        public MovementDetailTfd MovementDetailTfd { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public TransferReference TransferReference { get; set; }
        public TransferredFromDetail TransferredFromDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsNfd
    {
        public string LineIdentifierNfd { get {return "NFD/";} }
        public MovementDetailNfd MovementDetailNfd { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public NotificationToDetail NotificationToDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsAwd
    {
        public string LineIdentifierAwd { get {return "AWD/";} }
        public MovementDetailAwd MovementDetailAwd { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public DeliveryToDetail DeliveryToDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsCcd
    {
        public string LineIdentifierCcd { get {return "CCD/";} }
        public MovementDetailCcd MovementDetailCcd { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsDlv
    {
        public string LineIdentifierDlv { get {return "DLV/";} }
        public MovementDetailDlv MovementDetailDlv { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public DeliveryToDetail DeliveryToDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsDis
    {
        public string LineIdentifierDis { get {return "DIS/";} }
        public MovementDetailWithFlightId MovementDetailWithFlightId { get; set; }
        public DiscrepancyDescription DiscrepancyDescription { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsCrc
    {
        public string LineIdentifierCrc { get {return "CRC/";} }
        public ReportingDetail ReportingDetail { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public MovementDetailWithSlant MovementDetailWithSlant { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsDdl
    {
        public string LineIdentifierDdl { get {return "DDL/";} }
        public MovementDetailDdl MovementDetailDdl { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public DeliveryToDetail DeliveryToDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsTgc
    {
        public string LineIdentifierTgc { get {return "TGC/";} }
        public MovementDetailTgc MovementDetailTgc { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsArr
    {
        public string LineIdentifierArr { get {return "ARR/";} }
        public MovementDetailWithFlightId MovementDetailWithFlightId { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public TimeInformations TimeInformations { get; set; }
    }

    [SeparatorCrlf]
    public class StatusDetailsAwr
    {
        public string LineIdentifierAwr { get {return "AWR/";} }
        public MovementDetailWithFlightId MovementDetailWithFlightId { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public TimeInformations TimeInformations { get; set; }
    }

    public class StatusDetailsFoh
    {
        public string LineIdentifierFoh { get {return "FOH/";} }
        public MovementDetailFoh MovementDetailFoh { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public ReceivedFromDetail ReceivedFromDetail { get; set; }
        [SeparatorCrlf]
        public VolumeOrDensityWithCrlf VolumeOrDensityWithCrlf { get; set; }
    }

    public class OtherCustSecurityAndRegulatCtrlInfo
    {
        public string LineIdentifier { get ; set;  }
        public List<OtherCustSecurityAndRegulatCtrlInfoDet> OtherCustSecurityAndRegulatCtrlInfoDet { get; set; }
    }

    [SeparatorCrlf]
    public class ConsignmentDetail
    {
        public AwbIdentification AwbIdentification { get; set; }
        public AwbOriginAndDestination AwbOriginAndDestination { get; set; }
        public QuantityDetail QuantityDetail { get; set; }
        public TotalConsignmentPieces TotalConsignmentPieces { get; set; }
    }

    public class QuantityDetail
    {
        [SeparatorSlant]
        public string ShipmentDescriptionCode { get ; set;  }
        public string NumberOfPieces { get ; set;  }
        public WeightInformation WeightInformation { get; set; }
    }

    public class MovementDetail
    {
        public string CarrierCode { get ; set;  }
        public string FlightNumber { get ; set;  }
        [SeparatorSlant]
        public string DayOfScheduledDeparture { get ; set;  }
        public string MonthOfScheduledDeparture { get ; set;  }
        [SeparatorSlant]
        public string AirportCodeOfDeparture { get ; set;  }
        public string AirportCodeOfArrival { get ; set;  }
    }

    public class MovementDetailRcs
    {
        public string DayOfReceipt { get ; set;  }
        public string MonthOfReceipt { get ; set;  }
        public string ActualTimeOfGivenStatusEvent { get ; set;  }
        [SeparatorSlant]
        public string AirportCodeOfReceipt { get ; set;  }
    }

    public class MovementDetailRct
    {
        public string TransferringCarrier { get ; set;  }
        [SeparatorSlant]
        public string DayOfTransfer { get ; set;  }
        public string MonthOfTransfer { get ; set;  }
        public string ActualTimeOfGivenStatusEvent { get ; set;  }
        [SeparatorSlant]
        public string AirportCodeOfTransfer { get ; set;  }
    }

    public class MovementDetailTrm
    {
        public string ReceivingCarrier { get ; set;  }
        [SeparatorSlant]
        public string AirportCodeOfTransfer { get ; set;  }
    }

    public class MovementDetailTfd
    {
        public string ReceivingCarrier { get ; set;  }
        [SeparatorSlant]
        public string DayOfTransfer { get ; set;  }
        public string MonthOfTransfer { get ; set;  }
        public string ActualTimeOfGivenStatusEvent { get ; set;  }
        [SeparatorSlant]
        public string AirportCodeOfTransfer { get ; set;  }
    }

    public class MovementDetailNfd
    {
        public string DayOfNotification { get ; set;  }
        public string MonthOfNotification { get ; set;  }
        public string ActualTimeOfGivenStatusEvent { get ; set;  }
        [SeparatorSlant]
        public string AirportCodeOfNotification { get ; set;  }
    }

    public class MovementDetailAwd
    {
        public string DayOfDelivery { get ; set;  }
        public string MonthOfDelivery { get ; set;  }
        public string ActualTimeOfGivenStatusEvent { get ; set;  }
        [SeparatorSlant]
        public string AirportCodeOfDelivery { get ; set;  }
    }

    public class MovementDetailCcd
    {
        public string DayOfClearance { get ; set;  }
        public string MonthOfClearance { get ; set;  }
        public string ActualTimeOfGivenStatusEvent { get ; set;  }
        [SeparatorSlant]
        public string AirportCodeOfClearance { get ; set;  }
    }

    public class MovementDetailDlv
    {
        public string DayOfDelivery { get ; set;  }
        public string MonthOfDelivery { get ; set;  }
        public string ActualTimeOfGivenStatusEvent { get ; set;  }
        [SeparatorSlant]
        public string AirportCodeOfDelivery { get ; set;  }
    }

    public class MovementDetailDdl
    {
        public string DayOfDeliveryToConsigneesDoor { get ; set;  }
        public string MonthOfDeliveryToConsigneesDoor { get ; set;  }
        public string ActualTimeOfGivenStatusEvent { get ; set;  }
        [SeparatorSlant]
        public string AirportCodeOfDeliveryToConsigneesDoor { get ; set;  }
    }

    public class MovementDetailTgc
    {
        public string DayOfTransfer { get ; set;  }
        public string MonthOfTransfer { get ; set;  }
        public string ActualTimeOfGivenStatusEvent { get ; set;  }
        [SeparatorSlant]
        public string AirportCodeOfTransfer { get ; set;  }
    }

    public class MovementDetailFoh
    {
        public string DayOfReceipt { get ; set;  }
        public string MonthOfReceipt { get ; set;  }
        public string ActualTimeOfGivenStatusEvent { get ; set;  }
        [SeparatorSlant]
        public string AirportCodeOfReceipt { get ; set;  }
    }

    public class MovementDetailWithSlant
    {
        [SeparatorSlant]
        public MovementDetail MovementDetail { get; set; }
    }

    public class MovementDetailWithFlightId
    {
        public FlightIdentification FlightIdentification { get; set; }
        [SeparatorSlant]
        public string DayOfScheduledArrival { get ; set;  }
        public string MonthOfScheduledArrival { get ; set;  }
        public string ActualTimeOfGivenStatusEvent { get ; set;  }
        public DayChangeIndicator DayChangeIndicator { get; set; }
        [SeparatorSlant]
        public string AirportCodeOfArrival { get ; set;  }
    }

    public class ReportingDetail
    {
        public string DayOfReporting { get ; set;  }
        public string MonthOfReporting { get ; set;  }
        public string ActualTimeOfGivenStatusEvent { get ; set;  }
        [SeparatorSlant]
        public string AirportCodeOfReporting { get ; set;  }
    }

    public class AwbIdentification
    {
        public string AirlinePrefix { get ; set;  }
        [SeparatorHyphen]
        public string AwbSerialNumber { get ; set;  }
    }

    public class AwbOriginAndDestination
    {
        public string AirportCodeOfOrigin { get ; set;  }
        public string AirportCodeOfDestitation { get ; set;  }
    }

    public class WeightInformation
    {
        public string WeightCode { get ; set;  }
        public string Weight { get ; set;  }
    }

    public class VolumeDetail
    {
        public string VolumeCode { get ; set;  }
        public string VolumeAmount { get ; set;  }
    }

    public class DensityGroup
    {
        public string DensityIndicator { get ; set;  }
        public string DensityGroupInner { get ; set;  }
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
        public VolumeDetail VolumeDetail { get; set; }
        public DensityGroup DensityGroup { get; set; }
    }

    public class TotalConsignmentPieces
    {
        public string ShipmentDescriptionCode { get ; set;  }
        public string NumberOfPieces { get ; set;  }
    }

    public class FlightIdentification
    {
        public string CarrierCode { get ; set;  }
        public string FlightNumber { get ; set;  }
    }

    public class TimeInformations
    {
        [SeparatorSlant]
        public TimeOfDepartureInformation TimeOfDepartureInformation { get; set; }
        public TimeOfArrivalInformation TimeOfArrivalInformation { get; set; }
    }

    public class TimeAndVolumeInformation
    {
        [SeparatorSlant]
        public TimeOfDepartureInformation TimeOfDepartureInformation { get; set; }
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
        public string TypeOfTimeIndicator { get ; set;  }
        public string Time { get ; set;  }
        public DayChangeIndicator DayChangeIndicator { get; set; }
    }

    public class TimeOfArrivalAndVolume
    {
        [SeparatorSlant]
        public TimeInformation TimeInformation { get; set; }
        public VolumeOrDensity VolumeOrDensity { get; set; }
    }

    public class DayChangeIndicator
    {
        [SeparatorHyphen]
        public string DayChangeIndicatorCode { get ; set;  }
    }

    public class ReceivedfromDetailSep
    {
        [SeparatorSlant]
        public string ReceivingCarrier { get ; set;  }
        public ReceivedName ReceivedName { get; set; }
    }

    public class DiscrepancyDescription
    {
        [SeparatorSlant]
        public string DiscrepancyCode { get ; set;  }
    }

    public class TransferReference
    {
        [SeparatorSlant]
        public string TransferManifestNumber { get ; set;  }
    }

    public class TransferredFromDetail
    {
        [SeparatorSlant]
        public string TransferringCarrier { get ; set;  }
        public TransferredName TransferredName { get; set; }
    }

    [SeparatorCrlf]
    public class UldDescriptions
    {
        public string LineIdentifierUld { get {return "ULD";} }
        public List<UldDescription> UldDescription { get; set; }
    }

    public class UldDescription
    {
        [SeparatorSlant]
        public UldIdentification UldIdentification { get; set; }
        public UldPositionInformation UldPositionInformation { get; set; }
    }

    public class UldIdentification
    {
        public string UldType { get ; set;  }
        public string UldSerialNumber { get ; set;  }
        public string UldOwnerCode { get ; set;  }
    }

    public class UldPositionInformation
    {
        [SeparatorHyphen]
        public string UldLoadingIndicator { get ; set;  }
    }

    [SeparatorCrlf]
    public class OsiDetails1stLine
    {
        [SeparatorSlant]
        public string OsiDescription { get ; set;  }
    }

    [SeparatorCrlf]
    public class OsiDetails2stLine
    {
        [SeparatorSlant]
        public string OsiDescription { get ; set;  }
    }

    public class ReceivedFromDetail
    {
        [SeparatorSlant]
        public string Name { get ; set;  }
    }

    public class TransferredName
    {
        [SeparatorSlant]
        public string Name { get ; set;  }
    }

    public class ReceivedName
    {
        [SeparatorSlant]
        public string Name { get ; set;  }
    }

    public class NotificationToDetail
    {
        [SeparatorSlant]
        public string Name { get ; set;  }
    }

    public class DeliveryToDetail
    {
        [SeparatorSlant]
        public string Name { get ; set;  }
    }

    [SeparatorCrlf]
    public class OtherCustSecurityAndRegulatCtrlInfoDet
    {
        [SeparatorSlant]
        public string IsoCountryCode { get ; set;  }
        [SeparatorSlant]
        public string InformationIdentifier { get ; set;  }
        [SeparatorSlant]
        public string CustSecurityAndRegulatCtrlInfoId { get ; set;  }
        [SeparatorSlant]
        public string SupplemCustSecurityAndRegulatCtrlInfo { get ; set;  }
    }
}
