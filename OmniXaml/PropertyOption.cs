namespace OmniXaml
{
    using System.Diagnostics;

    [DebuggerDisplay("{ToString()}")]
    class PropertyOption : Option
    {
        public string Property { get; }
        public string Value { get; }

        public PropertyOption(string property, string value)
        {
            Property = property;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Property}={Value}";
        }

        protected bool Equals(PropertyOption other)
        {
            return string.Equals(Property, other.Property) && string.Equals(Value, other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != GetType())
            {
                return false;
            }
            return Equals((PropertyOption) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Property.GetHashCode()*397) ^ Value.GetHashCode();
            }
        }
    }
}