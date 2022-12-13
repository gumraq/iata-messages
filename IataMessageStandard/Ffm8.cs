using IataMessageStandard.Ffm8Parts;

namespace IataMessageStandard
{
    public class Ffm8
    {
        [Reference(1)]
        public StandardMessageIdentification StandardMessageIdentification { get; set; }

        [Reference(2)]
        public FlightIdAndPointOfLoading FlightIdAndPointOfLoading { get; set; }

        [Reference(3)]
        public List<DestinationHeader> DestinationHeader { get; set; }

        [Reference(4)]
        public ManifestCompleteIndicator ManifestCompleteIndicator { get; set; }
    }
}