using System.Collections.Generic;

namespace IataMessageStandard
{
    public class Fbl4
    {
        public Fbl4Parts.StandardMessageIdentification StandardMessageIdentification { get; set; }
        public Fbl4Parts.FlightIdAndPointOfLoading FlightIdAndPointOfLoading { get; set; }
        public List<Fbl4Parts.DestinationHeader> DestinationHeader { get; set; }
        public Fbl4Parts.ListCompleteIndicator ListCompleteIndicator { get; set; }
    }
}
