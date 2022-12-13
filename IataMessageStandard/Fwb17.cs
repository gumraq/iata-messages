using IataMessageStandard.Fwb17Parts;

namespace IataMessageStandard
{
    public class Fwb17
    {
        [Reference(1)]
        public StandardMessageIdentification StandardMessageIdentification { get; set; }

        [Reference(2)]
        public AwbConsignmentDetail AwbConsignmentDetail { get; set; }

        [Reference(3)]
        public FlightBookings FlightBookings { get; set; }

        [Reference(4)]
        public Routing Routing { get; set; }

        [Reference(5)]
        public Shipper Shipper { get; set; }

        [Reference(6)]
        public Consignee Consignee { get; set; }

        [Reference(7)]
        public Agent Agent { get; set; }

        [Reference(8)]
        public SpecialServiceRequest SpecialServiceRequest { get; set; }

        [Reference(9)]
        public AlsoNotify AlsoNotify { get; set; }

        [Reference(10)]
        public AccountingInformation AccountingInformation { get; set; }

        [Reference(11)]
        public ChargeDeclarations ChargeDeclarations { get; set; }

        [Reference(12)]
        public RateDescription RateDescription { get; set; }

        [Reference(13)]
        public OtherCharges OtherCharges { get; set; }

        [Reference(14)]
        public PrepaidChargeSummary PrepaidChargeSummary { get; set; }

        [Reference(15)]
        public CollectChargeSummary CollectChargeSummary { get; set; }

        [Reference(16)]
        public ShippersCertification ShippersCertification { get; set; }

        [Reference(17)]
        public CarriersExecution CarriersExecution { get; set; }

        [Reference(18)]
        public OtherServiceInformation OtherServiceInformation { get; set; }

        [Reference(19)]
        public CcChargesInDestinationCurrency CcChargesInDestinationCurrency { get; set; }

        [Reference(20)]
        public SenderReference SenderReference { get; set; }

        [Reference(21)]
        public CustomsOrigin CustomsOrigin { get; set; }

        [Reference(22)]
        public CommissionInformation CommissionInformation { get; set; }

        [Reference(23)]
        public SalesIncentiveInformation SalesIncentiveInformation { get; set; }

        [Reference(24)]
        public AgentReferenceData AgentReferenceData { get; set; }

        [Reference(25)]
        public SpecialHandlingDetails SpecialHandlingDetails { get; set; }

        [Reference(26)]
        public NominatedHandlingParty NominatedHandlingParty { get; set; }

        [Reference(27)]
        public ShipmentReferenceInformation ShipmentReferenceInformation { get; set; }

        [Reference(28)]
        public List<OtherParticipantInformation> OtherParticipantInformation { get; set; }

        [Reference(29)]
        public OtherCustSecurityAndRegulatCtrlInfo OtherCustSecurityAndRegulatCtrlInfo { get; set; }
    }
}