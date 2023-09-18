using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;
using static BXRest.Api.Models.Base;

namespace BXRest.Converter
{
    internal class OrderBX : JsonConverter<iBXRestOrder>
    {

        public override iBXRestOrder ReadJson(JsonReader reader, Type objectType, [AllowNull] iBXRestOrder existingValue, bool hasExistingValue, JsonSerializer serializer)
        {

            string boolValue = reader.Value?.ToString().ToLower();
            if (boolValue.Equals("asc"))
            {
                return iBXRestOrder.Asc;
            }
            if (boolValue.Equals("desc"))
            {
                return iBXRestOrder.Desc;
            }
            throw new JsonException($"{reader.Path}:{boolValue}, Invalid iBXRestOrder.");
        }

        public override void WriteJson(JsonWriter writer, [AllowNull] iBXRestOrder value, Newtonsoft.Json.JsonSerializer serializer)
        {

            writer.WriteValue(value.ToString().ToUpper());
        }
    }
}
