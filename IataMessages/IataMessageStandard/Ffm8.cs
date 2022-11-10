using System.Collections.Generic;

namespace IataMessageStandard
{
    public class Ffm8
    {
        public Ffm8Parts.StandardMessageIdentification StandardMessageIdentification { get; set; }
        public Ffm8Parts.FlightIdAndPointOfLoading FlightIdAndPointOfLoading { get; set; }
        public List<Ffm8Parts.DestinationHeader> DestinationHeader { get; set; }
        public Ffm8Parts.ManifestCompleteIndicator ManifestCompleteIndicator { get; set; }
    }
}
