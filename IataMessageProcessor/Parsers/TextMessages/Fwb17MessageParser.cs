using Antlr4.Runtime;
using FluentResults;

namespace IataMessageProcessor.Parsers.TextMessages
{
    public class Fwb17MessageParser : Parser<string>
    {
        public Fwb17MessageParser()
        {
        }

        public Fwb17MessageParser(IParser<string> parser) : base(parser)
        {
        }

        protected override bool IsThisCase(string standatdMessage)
        {
            try
            {
                using var reader = new StringReader(standatdMessage);
                string firstLine = reader.ReadLine();
                return string.Equals(firstLine, "FWB/17");
            }
            catch
            {
                return false;
            }
        }

        protected override Result<object> Proccess(string standatdMessage)
        {
            try
            {
                var inputStream = new AntlrInputStream(standatdMessage);
                var speakLexer = new fwb17Lexer(inputStream);
                var commonTokenStream = new CommonTokenStream(speakLexer);
                var fwb17Parser = new fwb17Parser(commonTokenStream);
                var errorListener = new SyntaxErrorListener();
                fwb17Parser.AddErrorListener(errorListener);
                var fwb17Context = fwb17Parser.fwb17();
                var visitor = new MessageParseTreeVisitor<IataMessageStandard.Fwb17>();

                visitor.Visit(fwb17Context);
                visitor.ExpressionExecute()();

                return Result.Ok(visitor.Message);

            }
            catch (Exception ex)
            {
                return Result.Fail(new Error("Не удалось разложить FWB/17").CausedBy(ex));
            }
        }
    }
}