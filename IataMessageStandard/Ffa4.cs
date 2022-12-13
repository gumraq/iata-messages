using IataMessageStandard.Ffa4Parts;

namespace IataMessageStandard
{
    public class Ffa4
    {
        [Reference(1)]
        public StandardMessageIdentification StandardMessageIdentification { get; set; }

        [Reference(2)]
        public ConsignmentDetail ConsignmentDetail { get; set; }

        [Reference(3)]
        public FlightDetails FlightDetails { get; set; }

        [Reference(4)]
        public SpecialServiceRequest SpecialServiceRequest { get; set; }

        [Reference(5)]
        public OtherServiceInformation OtherServiceInformation { get; set; }

        [Reference(6)]
        public BookingReference BookingReference { get; set; }

        [Reference(7)]
        public ShipmentReferenceInformation ShipmentReferenceInformation { get; set; }
    }
}