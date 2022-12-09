using IataMessageStandard.Fbr2Parts;

namespace IataMessageStandard
{
    public class Fbr2
    {
        public StandardMessageIdentification StandardMessageIdentification { get; set; }
        public FlightInformation FlightInformation { get; set; }
        public RequestReference RequestReference { get; set; }
    }}