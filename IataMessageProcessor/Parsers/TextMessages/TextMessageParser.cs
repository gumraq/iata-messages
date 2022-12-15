using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using FluentResults;

namespace IataMessageProcessor.Parsers.TextMessages
{
    public class TextMessageParser
    {
        public Result<object> Parse(string standardMessage)
        {
            try
            {
                string messageIdentification = DetectMessageIdentification(standardMessage);
                Func<string, IParseTree> textParser = this.CreateParser(messageIdentification);
                Func<IParseTree, object> treeVisitor = this.CreateVisitor(messageIdentification);

                IParseTree tree = textParser.Invoke(standardMessage);
                object message = treeVisitor.Invoke(tree);
                return Result.Ok(message);
            }
            catch (Exception ex)
            {
                return Result.Fail(new Error($"Не удалось разложить сообщение '{standardMessage}'").CausedBy(ex));
            }
        }

        private string DetectMessageIdentification(string standardMessage)
        {
            if (string.IsNullOrEmpty(standardMessage)) throw new ArgumentException("сообщение пустое");
            using var reader = new StringReader(standardMessage);
            string firstLine = reader.ReadLine();
            if (string.IsNullOrEmpty(firstLine)) throw new ArgumentException("строка идентификации пустая");
            return Regex.Replace(firstLine, @"\W", String.Empty).ToLower();
        }

        private Func<string, IParseTree> CreateParser(string messageIdentification)
        {
            Type parseTreeType = typeof(IParseTree);
            Type parserType = Type.GetType($"{messageIdentification}Parser");
            Type lexerType = Type.GetType($"{messageIdentification}Lexer");
            if (parserType == null || lexerType==null) throw new ArgumentException($"Незарегистирован тип '{messageIdentification}Parser' или '{messageIdentification}Lexer'");

            LabelTarget target = Expression.Label(parseTreeType);
            MethodInfo methodAddErrorListener = parserType.GetMethods().FirstOrDefault(m => m.Name == "AddErrorListener" && m.GetParameters().Length == 1);
            MethodInfo methodMessage = parserType.GetMethods().FirstOrDefault(m => m.Name == messageIdentification && m.GetParameters().Length == 0);
            ConstructorInfo constructorAntlrInputStream =  typeof(AntlrInputStream).GetConstructor(new[] { typeof(string) });
            ConstructorInfo constructorLexer = lexerType.GetConstructor(new[] { typeof(ICharStream) });
            ConstructorInfo constructorCommonTokenStream = typeof(CommonTokenStream).GetConstructor(new[] { typeof(ITokenSource) });
            ConstructorInfo constructorParser = parserType.GetConstructor(new[] { typeof(ITokenStream) });

            ParameterExpression peParseTree = Expression.Parameter(parseTreeType, "parseTree");
            ParameterExpression peStandardMessage = Expression.Parameter(typeof(string), "standardMessage");
            ParameterExpression peErrorListener = Expression.Parameter(typeof(IAntlrErrorListener<IToken>), "errorListener");
            ParameterExpression peCharStream = Expression.Parameter(typeof(ICharStream), "charStream");
            ParameterExpression peTokenSource = Expression.Parameter(typeof(ITokenSource), "tokenSource");
            ParameterExpression peTokenStream = Expression.Parameter(typeof(ITokenStream), "tokenStream");
            ParameterExpression peParser = Expression.Parameter(parserType, "parser");

            BinaryExpression createErrorListener = Expression.Assign(peErrorListener, Expression.New(typeof(SyntaxErrorListener)));
            BinaryExpression createCharStream = Expression.Assign(peCharStream, Expression.New(constructorAntlrInputStream, peStandardMessage));
            BinaryExpression createTokenSource = Expression.Assign(peTokenSource, Expression.New(constructorLexer, peCharStream));
            BinaryExpression createTokenStream = Expression.Assign(peTokenStream, Expression.New(constructorCommonTokenStream, peTokenSource));
            BinaryExpression createParser = Expression.Assign(peParser, Expression.New(constructorParser, peTokenStream));
            MethodCallExpression addErrorListener = Expression.Call(peParser, methodAddErrorListener, peErrorListener);
            BinaryExpression createParseTree = Expression.Assign(peParseTree, Expression.Call(peParser, methodMessage));
            GotoExpression returnParseTree = Expression.Return(target, peParseTree);
            LabelExpression labelExpression = Expression.Label(target, Expression.Default(parseTreeType));

            BlockExpression body = Expression.Block(
                new List<ParameterExpression>{ peParseTree , peErrorListener , peCharStream , peTokenSource , peTokenStream , peParser }, 
                new List<Expression> {createErrorListener, createCharStream, createTokenSource, createTokenStream, createParser, addErrorListener, createParseTree, returnParseTree, labelExpression });

            Expression<Func<string, IParseTree>> lambda = Expression.Lambda<Func<string, IParseTree>>(body, peStandardMessage);
            return lambda.Compile();
        }

        private Func<IParseTree, object> CreateVisitor(string messageIdentification)
        {
            Type elementType = Type.GetType($"IataMessageStandard.{messageIdentification.FirstCharToUpper()},IataMessageStandard");
            if (elementType == null) throw new ArgumentException($"Незарегистирован тип '{messageIdentification.FirstCharToUpper()}'");

            Type messageParseTreeVisitorType = typeof(MessageParseTreeVisitor<>).MakeGenericType(elementType);
            ParameterExpression peParseTree = Expression.Parameter(typeof(IParseTree), "parseTree");
            NewExpression neMessageParseTreeVisitor = Expression.New(messageParseTreeVisitorType);
            MethodInfo method = messageParseTreeVisitorType.GetMethods().FirstOrDefault(m => m.Name == "Visit" && m.GetParameters().Length == 1);
            MethodCallExpression mceVisit = Expression.Call(neMessageParseTreeVisitor, method, peParseTree);

            Expression<Func<IParseTree, object>> lambda = Expression.Lambda<Func<IParseTree, object>>(mceVisit, peParseTree);
            return lambda.Compile();
        }
    }
    public static class StringExtensions
    {
        public static string FirstCharToUpper(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => input[0].ToString().ToUpper() + input.Substring(1)
            };
    }
}
