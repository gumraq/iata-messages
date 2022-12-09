using Antlr4.Runtime;
using FluentResults;

namespace IataMessageProcessor.Parsers.TextMessages
{
    public class Ffa4MessageParser : Parser<string>
    {
        public Ffa4MessageParser()
        {
        }

        public Ffa4MessageParser(IParser<string> parser) : base(parser)
        {
        }

        protected override bool IsThisCase(string standatdMessage)
        {
            try
            {
                using var reader = new StringReader(standatdMessage);
                string firstLine = reader.ReadLine();
                return string.Equals(firstLine, "FFA/4");
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
                var speakLexer = new ffa4Lexer(inputStream);
                var commonTokenStream = new CommonTokenStream(speakLexer);
                var ffa4Parser = new ffa4Parser(commonTokenStream);
                var errorListener = new SyntaxErrorListener();
                ffa4Parser.AddErrorListener(errorListener);
                var ffa4Context = ffa4Parser.ffa4();
                var visitor = new MessageParseTreeVisitor<IataMessageStandard.Ffa4>();

                visitor.Visit(ffa4Context);
                visitor.ExpressionExecute()();

                return Result.Ok(visitor.Message);

            }
            catch (Exception ex)
            {
                return Result.Fail(new Error("Не удалось разложить FFA/4").CausedBy(ex));
            }
        }
    }
}