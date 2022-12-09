using Antlr4.Runtime;
using FluentResults;

namespace IataMessageProcessor.Parsers.TextMessages
{
    public class Fbr2MessageParser : Parser<string>
    {
        public Fbr2MessageParser()
        {
        }

        public Fbr2MessageParser(IParser<string> parser) : base(parser)
        {
        }

        protected override bool IsThisCase(string standatdMessage)
        {
            try
            {
                using var reader = new StringReader(standatdMessage);
                string firstLine = reader.ReadLine();
                return string.Equals(firstLine, "FBR/2");
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
                var speakLexer = new fbr2Lexer(inputStream);
                var commonTokenStream = new CommonTokenStream(speakLexer);
                var fbr2Parser = new fbr2Parser(commonTokenStream);
                var errorListener = new SyntaxErrorListener();
                fbr2Parser.AddErrorListener(errorListener);
                var fbr2Context = fbr2Parser.fbr2();
                var visitor = new MessageParseTreeVisitor<IataMessageStandard.Fbr2>();

                visitor.Visit(fbr2Context);
                visitor.ExpressionExecute()();

                return Result.Ok(visitor.Message);

            }
            catch (Exception ex)
            {
                return Result.Fail(new Error("Не удалось разложить FBR/2").CausedBy(ex));
            }
        }
    }
}