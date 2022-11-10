using System.Linq.Expressions;
using System.Reflection;
using Antlr4.Runtime.Tree;
using Microsoft.Extensions.Logging;

namespace IataMessageProcessor.Parsers.TextMessages
{
    public class MessageParseTreeVisitor<Result> : AbstractParseTreeVisitor<Result> where Result : new()
    {
        public Result Message { get; private set; }
        public IEnumerable<Expression> expression = Enumerable.Empty<Expression>();
        ILogger<MessageParseTreeVisitor<Result>> logger;

        public override Result Visit(IParseTree tree)
        {
            this.Message = new Result();
            return base.Visit(tree);
        }

        public override Result VisitChildren(IRuleNode node)
        {
                Expression currentProp = Expression.Property(Expression.Constant(this), nameof(Message));
                List<string> ancestors = Ancestors(node).ToList();
                int countRealNodes = 0;
            try
            {
                ancestors
                .TakeWhile(anc => !(currentProp.Type.IsPrimitive || currentProp.Type == typeof(string)))
                .Select((anc, index) =>
                {
                    countRealNodes++;
                    currentProp = Expression.Property(currentProp, anc);
                    Type currPropType = currentProp.Type;
                    if (index < ancestors.Count - 1 && currPropType.IsGenericType && (currPropType.GetGenericTypeDefinition() == typeof(List<>)))
                    {
                        MethodInfo method = typeof(Enumerable).GetMethods(BindingFlags.Static | BindingFlags.Public).FirstOrDefault(m => m.Name == "Last" && m.GetParameters().Count() == 1).MakeGenericMethod(new[] { currPropType.GenericTypeArguments[0] });
                        currentProp = Expression.Call(null, method, currentProp);
                    }
                    return anc;
                }).ToList();
            }
            catch (Exception ex) { }
                if (countRealNodes < ancestors.Count)
                {
                    return base.VisitChildren(node);
                }

                Type propType = currentProp.Type;
                if (propType.IsPrimitive || propType == typeof(string))
                {
                    try
                    {
                        currentProp = Expression.Assign(currentProp, Expression.Constant(node.GetText().Trim('\r', '\n')));
                        expression = expression.Append(currentProp);
                    }
                    catch(Exception ex) { };
                }
                else if (propType.IsGenericType && (propType.GetGenericTypeDefinition() == typeof(List<>)))
                {
                    try
                    {
                        Expression assignCurrentProp = Expression.IfThen(Expression.Equal(currentProp, Expression.Constant(null)), Expression.Assign(currentProp, Expression.New(propType)));
                        expression = expression.Append(assignCurrentProp);

                        MethodInfo method = propType.GetMethods().FirstOrDefault(m => m.Name == "Add" && m.GetParameters().Count() == 1);
                        currentProp = Expression.Call(currentProp, method, Expression.New(propType.GenericTypeArguments[0]));
                        expression = expression.Append(currentProp);
                    }
                    catch (Exception ex) { };
            }
                else
                {
                    try
                    {
                        currentProp = Expression.Assign(currentProp, Expression.New(propType));
                        expression = expression.Append(currentProp);
                    }
                    catch (Exception ex) { };
                }
            return base.VisitChildren(node);
        }

        IEnumerable<string> Ancestors(IRuleNode node)
        {
            IEnumerable<string> parents = Enumerable.Empty<string>();
            var np = node;
            while (np?.Parent != null)
            {
                parents = parents.Prepend(RemoveContext(np));
                np = np.Parent;
            }

            return parents;
        }

        private string RemoveContext(IRuleNode node)
        {
            return node.GetType().Name.Replace("Context", string.Empty);
        }

        public Action ExpressionExecute()
        {
            BlockExpression beLambdaBody = Expression.Block(this.expression.ToList());
            Expression<Action> le = Expression.Lambda<Action>(beLambdaBody);
            return le.Compile();
        }
    }
}

