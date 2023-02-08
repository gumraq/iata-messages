using FluentResults;
using IataMessageProcessor.Formatters.TextMessages;
using IataMessageProcessor.Parsers.TextMessages;
using IataMessageStandard;
using Xunit;


namespace IataMessageProcessorFacts
{
    public class FsrFacts
    {
        private TextMessageParser parser;
        private TextMessageFormatter formatter;

        public FsrFacts()
        {
            parser = new TextMessageParser();
            formatter = new TextMessageFormatter();
        }

        [Fact]
        public void ParserAndFormat()
        {
            string fsrOriginText = @"FSR
057-12345675CDGLAX/T10K500/BOOKS
AF099/20MAR/CDGJFK
AA1234/22MAR/JFKLAX
SU//JFKLAX
OSI/CONSIGNEE IS LOOKING FOR THE TENTH PIECE
/SAFE TO -6 DEGREE
";
            Result<object> rObject = parser.Parse(fsrOriginText);
            Fsr fsr = rObject.ValueOrDefault as Fsr;

            Assert.NotNull(fsr);
            Assert.Empty(rObject.Errors);

            string fsrTextActual = formatter.ToString(fsr);

            Assert.Equal(fsrOriginText, fsrTextActual);
        }
    }
}
