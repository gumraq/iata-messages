using FluentResults;

namespace IataMessageProcessor.Parsers
{
    /// <summary>
    /// Интерфейс раскладки
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IParser<T>
    {
         Result<object> Parse(T standatdMessage);
    }

    /// <summary>
    /// Парсер сообщений IATA - точка входа в цепочку обязанностей
    /// </summary>
    public class Parser<T> : IParser<T>
    {
        private readonly IParser<T> nextParser;

        public Parser(IParser<T> parser)
        {
            this.nextParser = parser;
        }

        public Parser()
        {
        }

        public Result<object> Parse(T standatdMessage)
        {
            if (this.IsThisCase(standatdMessage))
            {
                return Proccess(standatdMessage);
            }

            return ElseIf(standatdMessage);
        }

        protected Result<object> ElseIf(T standatdMessage)
        {
            if (this.nextParser != null)
            {
                return this.nextParser.Parse(standatdMessage);
            }

            return Result.Fail("Не удалось подобрать алгоритм раскладки");
        }

        protected virtual bool IsThisCase(T standatdMessage)
        {
            return false;
        }

        protected virtual Result<object> Proccess(T standatdMessage)
        {
            return Result.Fail("Не удалось подобрать алгоритм раскладки");
        }
    }
}
