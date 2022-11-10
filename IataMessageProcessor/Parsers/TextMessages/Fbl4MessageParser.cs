using Antlr4.Runtime;
using FluentResults;

namespace IataMessageProcessor.Parsers.TextMessages
{
    public class Fbl4MessageParser : Parser<string>
    {
        public Fbl4MessageParser()
        {
        }

        public Fbl4MessageParser(IParser<string> parser) : base(parser)
        {
        }

        protected override bool IsThisCase(string standatdMessage)
        {
            try
            {
                using var reader = new StringReader(standatdMessage);
                string firstLine = reader.ReadLine();
                return string.Equals(firstLine, "FBL/4");
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
                var speakLexer = new fbl4Lexer(inputStream);
                var commonTokenStream = new CommonTokenStream(speakLexer);
                var fbl4Parser = new fbl4Parser(commonTokenStream);
                var errorListener = new SyntaxErrorListener();
                fbl4Parser.AddErrorListener(errorListener);
                var fsuContext = fbl4Parser.fbl4();
                var visitor = new MessageParseTreeVisitor<IataMessageStandard.Fbl4>();

                visitor.Visit(fsuContext);
                visitor.ExpressionExecute()();

                return Result.Ok(visitor.Message);

            }
            catch (Exception ex)
            {
                return Result.Fail(new Error("Не удалось разложить FBL/4").CausedBy(ex));
            }
        }
    }
}
