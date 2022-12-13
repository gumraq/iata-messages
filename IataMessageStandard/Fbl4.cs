using IataMessageStandard.Fbl4Parts;

namespace IataMessageStandard
{
    public class Fbl4
    {
        [Reference(1)]
        public StandardMessageIdentification StandardMessageIdentification { get; set; }

        [Reference(2)]
        public FlightIdAndPointOfLoading FlightIdAndPointOfLoading { get; set; }

        [Reference(3)]
        public List<DestinationHeader> DestinationHeader { get; set; }

        [Reference(4)]
        public ListCompleteIndicator ListCompleteIndicator { get; set; }
    }
}