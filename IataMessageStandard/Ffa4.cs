using IataMessageStandard.Ffa4Parts;

namespace IataMessageStandard
{
    public class Ffa4
    {
        public StandardMessageIdentification StandardMessageIdentification { get; set; }
        public ConsignmentDetail ConsignmentDetail { get; set; }
        public FlightDetails FlightDetails { get; set; }
        public SpecialServiceRequest SpecialServiceRequest { get; set; }
        public OtherServiceInformation OtherServiceInformation { get; set; }
        public BookingReference BookingReference { get; set; }
        public ShipmentReferenceInformation ShipmentReferenceInformation { get; set; }
    }}