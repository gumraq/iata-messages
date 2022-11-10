using System.Linq.Expressions;
using System.Reflection;

namespace IataMessageProcessor.Formatters
{
    #region Interfaces

    public interface IVisitor<TResult>
    {
        TResult Visit<TElement>(TElement element);
    }

    public interface IVisitor<TElement, TResult>
    {
        TResult Visit(TElement element);
    }

    public interface IMessageFormatter<TResult> : IVisitor<TResult>
    {
        TResult Message<TObjectStructure>(TObjectStructure messageObjectStructure);
    }

    #endregion

    #region Formatters

    public class Formattable<TObjectStructure>
    {
        public TObjectStructure ObjectStructure { get; }

        public Formattable(TObjectStructure objectStructure)
        {
            this.ObjectStructure = objectStructure;
        }

        public void Accept<TResult>(IVisitor<TResult> visitor)
        {
            Action<IVisitor<TResult>> action = this.EnumerateAccept<TResult>();
            if (action != null)
            {
                action(visitor);
            }
        }

        private Action<IVisitor<TResult>> EnumerateAccept<TResult>()
        {
            ParameterExpression
                peItem = Expression.Parameter(typeof(IVisitor<TResult>),
                    "visitor"); //(IVisitor visitor) параметр - аргумент актора.
            MemberExpression meStart = Expression.Property(Expression.Constant(this), "ObjectStructure");
            IEnumerable<Expression> acceptors = Enumerable.Empty<Expression>();
            acceptors = acceptors.Append(Expression.Call(peItem, "Visit", new[] { typeof(TObjectStructure) }, meStart));
            acceptors = acceptors.Concat(
                Recursive(this.ObjectStructure, Expression.Property(Expression.Constant(this), "ObjectStructure"))
                    .Select(expr =>
                        Expression.Call(peItem, "Visit", new[] { expr.Type }, expr))); // вызываем для каждлго свойства 
            BlockExpression beLambdaBody = Expression.Block(acceptors); // собираем всё вычисленное в фигурные скобки
            Expression<Action<IVisitor<TResult>>> le =
                Expression.Lambda<Action<IVisitor<TResult>>>(beLambdaBody, peItem);
            return le.Compile();
        }

        IEnumerable<Expression> Recursive(object element, Expression expression)
        {
            Type elemType = element.GetType();
            PropertyInfo[] properties = elemType.GetProperties();
            foreach (PropertyInfo elemProperty in properties)
            {
                object elemObj = elemProperty.GetValue(element, null);
                if (elemObj != null && elemProperty.PropertyType.IsGenericType &&
                    elemProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>) &&
                    elemProperty.PropertyType.GetGenericArguments()[0].IsClass &&
                    !elemProperty.PropertyType.GetGenericArguments()[0].FullName.StartsWith("System."))
                {
                    int count = (int)elemProperty.PropertyType.GetProperty("Count").GetValue(elemObj, null);
                    PropertyInfo p = elemProperty.PropertyType.GetProperty("Item");
                    for (int i = 0; i < count; i++)
                    {
                        var indexObj = p.GetValue(elemObj, new object[] { i });
                        Expression expr = Expression.Property(expression, elemProperty.Name);
                        expr = Expression.Property(expr, "Item", Expression.Constant(i));
                        yield return expr;
                        foreach (Expression expression1 in this.Recursive(indexObj, expr))
                        {
                            yield return expression1;
                        }
                    }
                }
                else if (elemObj != null && elemProperty.PropertyType.IsClass &&
                         !elemProperty.PropertyType.FullName.StartsWith("System."))
                {
                    Expression expr = Expression.Property(expression, elemProperty.Name);
                    yield return expr;
                    foreach (Expression expression1 in this.Recursive(elemObj, expr))
                    {
                        yield return expression1;
                    }
                }
            }
        }
    }

    public abstract class Formatter<TResult> : IVisitor<TResult> where TResult : class
    {
        public TResult Message<TObjectStructure>(TObjectStructure messageObjectStructure)
        {
            Formattable<TObjectStructure> formattable = new Formattable<TObjectStructure>(messageObjectStructure);
            formattable.Accept(this);
            return this.Visit(messageObjectStructure);
        }

        public TResult Visit<TElement>(TElement element)
        {
            return (this as IVisitor<TElement, TResult>)?.Visit(element);
        }
    }

    #endregion
}
