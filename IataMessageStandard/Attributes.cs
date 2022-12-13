namespace IataMessageStandard
{
    public class SeparatorCrlfAttribute : Attribute { }

    public class SeparatorSlantAttribute : Attribute { }

    public class SeparatorHyphenAttribute : Attribute { }

    public class ReferenceAttribute : Attribute
    {
        public ReferenceAttribute(int index)
        {
            Index = index;
        }
        public int Index { get; }
    }
}
