using IataMessageStandard.Fbl4Parts;

namespace IataMessageStandard
{
    public class Fbl4
    {
        public StandardMessageIdentification StandardMessageIdentification { get; set; }
        public FlightIdAndPointOfLoading FlightIdAndPointOfLoading { get; set; }
        public List<DestinationHeader> DestinationHeader { get; set; }
        public ListCompleteIndicator ListCompleteIndicator { get; set; }
    }}