using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionLibrary
{
    public static class ConversionHelper
    {
        /// <summary>
        /// Gets the specified property value and converts it, if necessary.
        /// </summary>
        /// <typeparam name="T">The type to convert to.</typeparam>
        /// <param name="o">The object to convert.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public static T Convert<T>(this object o, T defaultValue = default(T))
        {
            if (o == null) return defaultValue;
            o = o.Convert(typeof(T), defaultValue);
            return o is T ? (T)o : defaultValue;
        }

        /// <summary>
        /// Gets the specified property value and converts it, if necessary.
        /// </summary>
        /// <param name="o">The object to convert.</param>
        /// <param name="type">The type to convert to.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public static object Convert(this object o, Type type, object defaultValue)
        {
            if (o == null || o is DBNull) return defaultValue;
            if (type.IsInstanceOfType(o)) return o;

            try
            {
                object result;
                var s = o as string;

                if (s != null)
                {
                    if (s.Length == 0) return defaultValue;
                    result = Parse(type, s);
                    if (result != null) return result;
                }

                var valueType = o.GetType();
                var tc = TypeDescriptor.GetConverter(valueType);

                if (tc.CanConvertTo(type))
                {
                    result = tc.ConvertTo(o, type);
                    return result;
                }

                tc = TypeDescriptor.GetConverter(type);

                if (tc.CanConvertFrom(valueType))
                {
                    result = tc.ConvertFrom(o);
                    return result;
                }

                result = Parse(type, o) ?? defaultValue;
                return result;
            }
            catch
            {
                throw new Exception("Value cannot be converted");
            }
        }

        /// <summary>
        /// Parses the specified object into the specified type.
        /// </summary>
        /// <param name="type">The type to parse into.</param>
        /// <param name="o">The object to parse.</param>
        /// <returns>An object of the specified type, if successfull; otherwise, null.</returns>
        public static object Parse(Type type, object o)
        {
            if (o == null) return null;
            var text = o.ToString();
            if (string.IsNullOrEmpty(text)) return null;

            object result = null;

            switch (type.Name)
            {
                case "UInt16":
                    {
                        UInt16 v2;
                        if (UInt16.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out v2)) result = v2;
                        break;
                    }
                case "UInt32":
                    {
                        UInt32 v2;
                        if (UInt32.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out v2)) result = v2;
                        break;
                    }
                case "UInt64":
                    {
                        UInt64 v2;
                        if (UInt64.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out v2)) result = v2;
                        break;
                    }
                case "Int16":
                    {
                        Int16 v2;
                        if (Int16.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out v2)) result = v2;
                        break;
                    }
                case "Int32":
                    {
                        Int32 v2;
                        if (Int32.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out v2)) result = v2;
                        break;
                    }
                case "Int64":
                    {
                        Int64 v2;
                        if (Int64.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out v2)) result = v2;
                        break;
                    }
                case "Byte":
                    {
                        Byte v2;
                        if (Byte.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out v2)) result = v2;
                        break;
                    }
                case "Boolean":
                    {
                        result = BooleanValues.Contains(text);
                        break;
                    }
                case "Decimal":
                    {
                        decimal v2;
                        if (decimal.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out v2)) result = v2;
                        break;
                    }
                case "DateTime":
                    {
                        DateTime v2;
                        if (DateTime.TryParse(text, CultureInfo.InvariantCulture,
                                              DateTimeStyles.AllowInnerWhite | DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowWhiteSpaces,
                                              out v2)) result = v2;
                        break;
                    }
                case "DateTimeOffset":
                    {
                        DateTimeOffset v2;
                        if (DateTimeOffset.TryParse(text, CultureInfo.InvariantCulture,
                                                    DateTimeStyles.AllowInnerWhite | DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowWhiteSpaces,
                                                    out v2)) result = v2;
                        break;
                    }
                case "TimeSpan":
                    {
                        TimeSpan v2;
                        if (TimeSpan.TryParse(text, CultureInfo.InvariantCulture, out v2)) result = v2;
                        break;
                    }
            }

            return result;
        }

        private static readonly HashSet<string> BooleanValues = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "true", "1", "on", "yes", "ja" };
    }
}
