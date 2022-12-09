using Antlr4.Runtime;
using FluentResults;

namespace IataMessageSourceGenerator
{
    /// <summary>
    /// Парсер g4 от Antlr4
    /// </summary>
    public class EntryPointParser
    {
        public Result<string> Proc(string grammar)
        {

            string[] eofs = new[] { "\r\n", "\n" };
            var lines = grammar.Split(eofs, StringSplitOptions.None);

            try
            {
                ICharStream inputStream = new AntlrInputStream(string.Join("\r\n", lines));
                Lexer speakLexer = new ANTLRv4Lexer(inputStream);
                ITokenStream tokenStream = new CommonTokenStream(speakLexer);
                ANTLRv4Parser grammarParser = new ANTLRv4Parser(tokenStream);
                ANTLRv4Parser.GrammarSpecContext rootContext = grammarParser.grammarSpec();
                CsharpStructureParseTreeVisitor visitor = new CsharpStructureParseTreeVisitor();
                visitor.Visit(rootContext);
                visitor.SourceCode();
                return Result.Ok();

            }
            catch (Exception ex)
            {
                return Result.Fail(new Error("Не удалось разложить грэммар файл на классы-структуры C#").CausedBy(ex));
            }
        }
    }
}
