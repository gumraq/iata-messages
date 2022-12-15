using System.Reflection;
using System.Text;
using IataMessageStandard;

namespace IataMessageProcessor.Formatters.TextMessages
{
    /// <summary>
    /// Форматтер телесков под текстовый вида
    /// </summary>
    public class TextMessageFormatter
    {
        protected string sCRLF = "\u000d\u000a";
        protected string sSlant = "/";
        protected string sHyphen = "-";

        public string ToString<TObjectStructure>(TObjectStructure objectStructure)
        {
            return Recursive(objectStructure);
        }

        private string Recursive(object element)
        {
            StringBuilder sb = new StringBuilder();
            Type elemType = element.GetType();
            foreach (PropertyInfo property in elemType.GetProperties().OrderBy(Reference))
            {
                foreach (string separator in property.GetCustomAttributes(false).Select(Separator))
                {
                    sb.Append(separator);
                }
                object propVal = property.GetValue(element, null);
                if (propVal != null && property.PropertyType.IsGenericType &&
                    property.PropertyType.GetGenericTypeDefinition() == typeof(List<>) &&
                    property.PropertyType.GetGenericArguments()[0].IsClass &&
                    !property.PropertyType.GetGenericArguments()[0].FullName.StartsWith("System."))
                {
                    int count = (int)property.PropertyType.GetProperty("Count").GetValue(propVal, null);
                    PropertyInfo p = property.PropertyType.GetProperty("Item");
                    for (int i = 0; i < count; i++)
                    {
                        var indexObj = p.GetValue(propVal, new object[] { i });
                        sb.Append(this.Recursive(indexObj));
                    }
                }
                else if (propVal != null && property.PropertyType.IsClass &&
                         !property.PropertyType.FullName.StartsWith("System."))
                {
                    sb.Append(this.Recursive(propVal));
                }
                else
                {
                    sb.Append(propVal);
                }
            }

            foreach (string separator in elemType.GetCustomAttributes(false).Select(Separator))
            {
                sb.Append(separator);
            }

            return sb.ToString();
        }

        private int Reference(PropertyInfo property)
        {
            Attribute attribute = property.GetCustomAttribute(typeof(ReferenceAttribute));
            if (attribute != null)
            {
                return ((ReferenceAttribute)attribute).Index;
            }

            return 1;
        }

        private string Separator(object attribute)
        {
            string n = attribute.GetType().Name;
            if (n == "SeparatorSlantAttribute")
            {
                return this.sSlant;
            }
            if (n == "SeparatorCrlfAttribute")
            {
                return this.sCRLF;
            }
            if (n == "SeparatorHyphenAttribute")
            {
                return sHyphen;
            }

            return string.Empty;
        }

    }
}
