using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;

namespace BXRest.Converter
{
    /// <summary>
    /// Конвертер битриксовых представлений о тру и фолс
    /// </summary>
    public class YesNoBX : JsonConverter<bool>
    {

        public override bool ReadJson(JsonReader reader, Type objectType, [AllowNull] bool existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
        {

            string boolValue = reader.Value?.ToString().ToLower();
            if (boolValue.Equals("true") || boolValue.Equals("yes") || boolValue.Equals("y") || boolValue.Equals("1"))
            {
                return true;
            }
            if (boolValue.Equals("false") || boolValue.Equals("no") || boolValue.Equals("n") || boolValue.Equals("0"))
            {
                return false;
            }
            throw new Newtonsoft.Json.JsonException($"{reader.Path}:{boolValue}, Invalid Boolean.");
        }

        public override void WriteJson(JsonWriter writer, [AllowNull] bool value, Newtonsoft.Json.JsonSerializer serializer)
        {
            switch (value)
            {
                case true:
                    writer.WriteRawValue("true");
                    break;
                case false:
                    writer.WriteRawValue("false");
                    break;

            }
        }
    }
}
