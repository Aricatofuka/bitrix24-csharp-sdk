using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;

namespace BXRest.Converter
{
    /// Конвертер битриксовых представлений о тру и фолс
    public class YesNoBX : JsonConverter<bool>
    {
        /// Вывод при чтении json
        public override bool ReadJson(JsonReader reader, Type objectType, [AllowNull] bool existingValue, bool hasExistingValue, JsonSerializer serializer)
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
            throw new JsonException($"{reader.Path}:{boolValue}, Invalid Boolean.");
        }

        /// Вывод при запись в json
        public override void WriteJson(JsonWriter writer, [AllowNull] bool value, JsonSerializer serializer)
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

    /// Для чтения и вывода параметров запроса битрикса
    public class YesNoBXParamRequest : YesNoBX {

        /// Вывод при запись в json
        public override void WriteJson(JsonWriter writer, [AllowNull] bool value, JsonSerializer serializer)
        {
            switch (value)
            {
                case true:
                    writer.WriteValue("Y");
                    break;
                case false:
                    writer.WriteValue("N");
                    break;

            }
        }
    }
}
