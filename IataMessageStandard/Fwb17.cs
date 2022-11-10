namespace IataMessageStandard
{
    public class Fwb17
    {
        public Fwb17Parts.StandardMessageIdentification StandardMessageIdentification { get; set; }
        public Fwb17Parts.AwbConsignmentDetail AwbConsignmentDetail { get; set; }
        public Fwb17Parts.FlightBookings FlightBookings { get; set; }
        public Fwb17Parts.Routing Routing { get; set; }
        public Fwb17Parts.Shipper Shipper { get; set; }
        public Fwb17Parts.Consignee Consignee { get; set; }
        public Fwb17Parts.Agent Agent { get; set; }
        public Fwb17Parts.SpecialServiceRequest SpecialServiceRequest { get; set; }
        public Fwb17Parts.AlsoNotify AlsoNotify { get; set; }
        public Fwb17Parts.AccountingInformation AccountingInformation { get; set; }
        public Fwb17Parts.ChargeDeclarations ChargeDeclarations { get; set; }
        public Fwb17Parts.RateDescription RateDescription { get; set; }
        public Fwb17Parts.OtherCharges OtherCharges { get; set; }
        public Fwb17Parts.PrepaidChargeSummary PrepaidChargeSummary { get; set; }
        public Fwb17Parts.CollectChargeSummary CollectChargeSummary { get; set; }
        public Fwb17Parts.ShippersCertification ShippersCertification { get; set; }
        public Fwb17Parts.CarriersExecution CarriersExecution { get; set; }
        public Fwb17Parts.OtherServiceInformation OtherServiceInformation { get; set; }
        public Fwb17Parts.CcChargesInDestinationCurrency CcChargesInDestinationCurrency { get; set; }
        public Fwb17Parts.SenderReference SenderReference { get; set; }
        public Fwb17Parts.CustomsOrigin CustomsOrigin { get; set; }
        public Fwb17Parts.CommissionInformation CommissionInformation { get; set; }
        public Fwb17Parts.SalesIncentiveInformation SalesIncentiveInformation { get; set; }
        public Fwb17Parts.AgentReferenceData AgentReferenceData { get; set; }
        public Fwb17Parts.SpecialHandlingDetails SpecialHandlingDetails { get; set; }
        public Fwb17Parts.NominatedHandlingParty NominatedHandlingParty { get; set; }
        public Fwb17Parts.ShipmentReferenceInformation ShipmentReferenceInformation { get; set; }
        public List<Fwb17Parts.OtherParticipantInformation> OtherParticipantInformation { get; set; }
        public Fwb17Parts.OtherCustSecurityAndRegulatCtrlInfo OtherCustSecurityAndRegulatCtrlInfo { get; set; }
    }
}