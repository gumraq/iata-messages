using Antlr4.Runtime;
using FluentResults;

namespace IataMessageProcessor.Parsers.TextMessages
{
    public class Fsa15MessageParser : Parser<string>
    {
        public Fsa15MessageParser()
        {
        }

        public Fsa15MessageParser(IParser<string> parser) : base(parser)
        {
        }

        protected override bool IsThisCase(string standatdMessage)
        {
            try
            {
                using var reader = new StringReader(standatdMessage);
                string firstLine = reader.ReadLine();
                return string.Equals(firstLine, "FSA/15");
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
                var speakLexer = new fsa15Lexer(inputStream);
                var commonTokenStream = new CommonTokenStream(speakLexer);
                var fsa15Parser = new fsa15Parser(commonTokenStream);
                var errorListener = new SyntaxErrorListener();
                fsa15Parser.AddErrorListener(errorListener);
                var fsa15Context = fsa15Parser.fsa15();
                var visitor = new MessageParseTreeVisitor<IataMessageStandard.Fsa15>();

                visitor.Visit(fsa15Context);
                visitor.ExpressionExecute()();

                return Result.Ok(visitor.Message);

            }
            catch (Exception ex)
            {
                return Result.Fail(new Error("Не удалось разложить FSA/15").CausedBy(ex));
            }
        }
    }
}