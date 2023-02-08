using FluentResults;
using IataMessageProcessor.Formatters.TextMessages;
using IataMessageProcessor.Parsers.TextMessages;
using IataMessageStandard;
using Xunit;


namespace IataMessageProcessorFacts
{
    public class Fbr2Facts
    {
        private TextMessageParser parser;
        private TextMessageFormatter formatter;

        public Fbr2Facts()
        {
            parser = new TextMessageParser();
            formatter = new TextMessageFormatter();
        }

        [Fact]
        public void ParserAndFormat()
        {
            string fbr2Text = @"FBR/2
FLT/KL775/09FEB/ZRH
REF//FRA111020090112/AGT/STRECKTRANSPORTGE/FRA
";
            Result<object> rObject = parser.Parse(fbr2Text);
            Assert.NotNull(rObject);
            Result<Fbr2> fbr2 = rObject.ToResult(o => (Fbr2)o);

            string fblTextActual = formatter.ToString(fbr2.Value);

            Assert.Equal(fbr2Text, fblTextActual);
        }
    }
}
