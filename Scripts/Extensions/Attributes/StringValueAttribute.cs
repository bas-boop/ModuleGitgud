using System;

namespace Framework.Extensions.Attributes
{
    public sealed class StringValueAttribute : Attribute
    {
        public string Value { get; }

        public StringValueAttribute(string value) => Value = value;
    }
}