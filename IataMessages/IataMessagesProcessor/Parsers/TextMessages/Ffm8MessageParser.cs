using System;
using System.IO;
using Antlr4.Runtime;
using FluentResults;
using IataMessagesProcessor.Messages;

namespace IataMessagesProcessor.Parsers.TextMessages
{
    public class Ffm8MessageParser : Parser<string>
    {
        public Ffm8MessageParser()
        {
        }

        public Ffm8MessageParser(IParser<string> parser) : base(parser)
        {
        }

        protected override bool IsThisCase(string standatdMessage)
        {
            try
            {
                using var reader = new StringReader(standatdMessage);
                string firstLine = reader.ReadLine();
                return string.Equals(firstLine, "FFM/8");
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
                var speakLexer = new ffm8Lexer(inputStream);
                var commonTokenStream = new CommonTokenStream(speakLexer);
                var ffm8Parser = new ffm8Parser(commonTokenStream);
                var errorListener = new SyntaxErrorListener();
                ffm8Parser.AddErrorListener(errorListener);
                var fsuContext = ffm8Parser.ffm8();
                var visitor = new MessageParseTreeVisitor<Ffm8>();

                visitor.Visit(fsuContext);
                visitor.ExpressionExecute()();

                return Result.Ok(visitor.Message);

            }
            catch (Exception ex)
            {
                return Result.Fail(new Error("Не удалось разложить FFM/8").CausedBy(ex));
            }
        }
    }
}
