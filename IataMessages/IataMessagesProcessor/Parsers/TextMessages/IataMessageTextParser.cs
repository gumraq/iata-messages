namespace IataMessagesProcessor.Parsers.TextMessages
{
    public class IataMessageTextParser : Parser<string>
    {
        public IataMessageTextParser(IParser<string> parser) : base(parser)
        {
        }
    }
}
