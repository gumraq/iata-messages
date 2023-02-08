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
            Fbr2 fbr2 = rObject.ValueOrDefault as Fbr2;

            Assert.NotNull(fbr2);
            Assert.Empty(rObject.Errors);

            string fbr2TextActual = formatter.ToString(fbr2);

            Assert.Equal(fbr2Text, fbr2TextActual);
        }
    }
}
