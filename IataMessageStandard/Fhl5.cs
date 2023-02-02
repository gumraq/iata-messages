using IataMessageStandard.Fhl5Parts;

namespace IataMessageStandard
{
    public class Fhl5
    {
        [Reference(1)]
        public StandardMessageIdentification StandardMessageIdentification { get; set; }

        [Reference(2)]
        public MasterAwbConsignmentDetail MasterAwbConsignmentDetail { get; set; }

        [Reference(3)]
        public List<HouseWaybills> HouseWaybills { get; set; }

        [Reference(4)]
        public ShipperNameAndAddress ShipperNameAndAddress { get; set; }

        [Reference(5)]
        public ConsigneeNameAndAddress ConsigneeNameAndAddress { get; set; }

        [Reference(6)]
        public ChargeDeclarations ChargeDeclarations { get; set; }
    }
}