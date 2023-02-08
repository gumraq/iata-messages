using FluentResults;
using IataMessageProcessor.Formatters.TextMessages;
using IataMessageProcessor.Parsers.TextMessages;
using IataMessageStandard;
using Xunit;


namespace IataMessageProcessorFacts
{
    public class Ffa4Facts
    {
        private TextMessageParser parser;
        private TextMessageFormatter formatter;

        public Ffa4Facts()
        {
            parser = new TextMessageParser();
            formatter = new TextMessageFormatter();
        }

        [Fact]
        public void ParserAndFormat()
        {
            string ffa4OriginText = @"FFA/4
555-29681396SVOKHV/T286K878MC0.4/KOSMETIKA
/470/471/RMD
SU1712/03NOV/SVOKHV/KK
SU2301/31DEC/FRASVO/KK
SU270/01JAN/SVOBKK/KK
SSR/SPECIALIZED DGR
/DANGEROUS GOODS AS PER ATTACHED SHIPPER S DECLARATION
OSI/NOT SECURED
REF//FRA111020090112/AGT/STRECKTRANSPORTGE/FRA
";
            Result<object> rObject = parser.Parse(ffa4OriginText);
            Ffa4 ffa4 = rObject.ValueOrDefault as Ffa4;

            Assert.NotNull(ffa4);
            Assert.Empty(rObject.Errors);

            string ffa4TextActual = formatter.ToString(ffa4);

            Assert.Equal(ffa4OriginText, ffa4TextActual);
        }
    }
}
