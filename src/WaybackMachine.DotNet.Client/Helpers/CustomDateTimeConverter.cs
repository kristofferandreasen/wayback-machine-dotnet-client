using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WaybackMachine.DotNet.Client.Constants;

namespace WaybackMachine.DotNet.Client.Helpers
{
    /// <summary>
    /// Custom DateTime JSON serializer/deserializer
    /// </summary>
    public class CustomDateTimeConverter :  DateTimeConverterBase
    {
        /// <summary>
        /// Writes value to JSON
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Value to be written</param>
        /// <param name="serializer">JSON serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((DateTime)value).ToString(FormatConstants.DateFormat));
        }

        /// <summary>
        /// Reads value from JSON
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Target type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON serialized</param>
        /// <returns>Deserialized DateTime</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
            {
                return null;
            }

            var s = reader.Value.ToString();
            DateTime result;
            if (DateTime.TryParseExact(s, FormatConstants.DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                return result;
            }

            return DateTime.Now;
        }
    }
}