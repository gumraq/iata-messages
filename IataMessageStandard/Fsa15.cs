using IataMessageStandard.Fsa15Parts;

namespace IataMessageStandard
{
    public class Fsa15
    {
        [Reference(1)]
        public StandardMessageIdentification StandardMessageIdentification { get; set; }

        [Reference(2)]
        public List<MulticarrierConsignments> MulticarrierConsignments { get; set; }
    }
}