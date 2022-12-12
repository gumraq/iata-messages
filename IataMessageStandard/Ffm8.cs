using IataMessageStandard.Ffm8Parts;

namespace IataMessageStandard
{
    public class Ffm8
    {
        public StandardMessageIdentification StandardMessageIdentification { get; set; }
        public FlightIdAndPointOfLoading FlightIdAndPointOfLoading { get; set; }
        public List<DestinationHeader> DestinationHeader { get; set; }
        public ManifestCompleteIndicator ManifestCompleteIndicator { get; set; }
    }}