namespace IataMessageProcessor.Parsers.TextMessages
{
    public class TextMessageParser : Parser<string>
    {
        public TextMessageParser(IParser<string> parser) : base(parser)
        {
        }
    }
}
