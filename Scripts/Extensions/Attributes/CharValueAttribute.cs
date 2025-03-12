using System;

namespace Framework.Extensions.Attributes
{
    public sealed class CharValueAttribute : Attribute
    {
        public char Value { get; }

        public CharValueAttribute(char value) => Value = value;
    }
}