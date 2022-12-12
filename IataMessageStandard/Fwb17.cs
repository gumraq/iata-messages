using IataMessageStandard.Fwb17Parts;

namespace IataMessageStandard
{
    public class Fwb17
    {
        public StandardMessageIdentification StandardMessageIdentification { get; set; }
        public AwbConsignmentDetail AwbConsignmentDetail { get; set; }
        public FlightBookings FlightBookings { get; set; }
        public Routing Routing { get; set; }
        public Shipper Shipper { get; set; }
        public Consignee Consignee { get; set; }
        public Agent Agent { get; set; }
        public SpecialServiceRequest SpecialServiceRequest { get; set; }
        public AlsoNotify AlsoNotify { get; set; }
        public AccountingInformation AccountingInformation { get; set; }
        public ChargeDeclarations ChargeDeclarations { get; set; }
        public RateDescription RateDescription { get; set; }
        public OtherCharges OtherCharges { get; set; }
        public PrepaidChargeSummary PrepaidChargeSummary { get; set; }
        public CollectChargeSummary CollectChargeSummary { get; set; }
        public ShippersCertification ShippersCertification { get; set; }
        public CarriersExecution CarriersExecution { get; set; }
        public OtherServiceInformation OtherServiceInformation { get; set; }
        public CcChargesInDestinationCurrency CcChargesInDestinationCurrency { get; set; }
        public SenderReference SenderReference { get; set; }
        public CustomsOrigin CustomsOrigin { get; set; }
        public CommissionInformation CommissionInformation { get; set; }
        public SalesIncentiveInformation SalesIncentiveInformation { get; set; }
        public AgentReferenceData AgentReferenceData { get; set; }
        public SpecialHandlingDetails SpecialHandlingDetails { get; set; }
        public NominatedHandlingParty NominatedHandlingParty { get; set; }
        public ShipmentReferenceInformation ShipmentReferenceInformation { get; set; }
        public List<OtherParticipantInformation> OtherParticipantInformation { get; set; }
        public OtherCustSecurityAndRegulatCtrlInfo OtherCustSecurityAndRegulatCtrlInfo { get; set; }
    }}