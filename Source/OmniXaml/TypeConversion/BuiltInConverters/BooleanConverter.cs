﻿namespace OmniXaml.TypeConversion.BuiltInConverters
{
    using System;
    using System.Globalization;

    public class BooleanConverter : ITypeConverter
    {
        public object ConvertFrom(IXamlTypeConverterContext context, CultureInfo culture, object value)
        {
            return bool.Parse((string) value);
        }

        public object ConvertTo(IXamlTypeConverterContext context, CultureInfo culture, object value, Type destinationType)
        {
            return value.ToString();
        }

        public bool CanConvertTo(IXamlTypeConverterContext context, Type destinationType)
        {
            return true;
        }

        public bool CanConvertFrom(IXamlTypeConverterContext context, Type sourceType)
        {
            return true;
        }
    }
}