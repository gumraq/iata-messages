using IataMessageStandard.Fbr2Parts;

namespace IataMessageStandard
{
    public class Fbr2
    {
        [Reference(1)]
        public StandardMessageIdentification StandardMessageIdentification { get; set; }

        [Reference(2)]
        public FlightInformation FlightInformation { get; set; }

        [Reference(3)]
        public RequestReference RequestReference { get; set; }
    }
}