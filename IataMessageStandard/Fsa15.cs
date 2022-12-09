using IataMessageStandard.Fsa15Parts;

namespace IataMessageStandard
{
    public class Fsa15
    {
        public StandardMessageIdentification StandardMessageIdentification { get; set; }
        public List<MulticarrierConsignments> MulticarrierConsignments { get; set; }
    }}