using BXRest.Api.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using static BXRest.Models.Parameter.Request.Filter;

namespace BXRest.Converter
{
    /// Для REST API BITRIX с не типичной постраничной навигацией
    public class FilterWithSpecialCharacter<T> : JsonConverter<iBXFilterValue<T>>
    {

        /// возможно когданибудь надо будет написать, но сейчас в этом нет никакого смысла
        public override iBXFilterValue<T> ReadJson(JsonReader reader, Type objectType, [AllowNull] iBXFilterValue<T> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {

            string strJson = reader.Value?.ToString();
            throw new JsonException($"{reader.Path}:{strJson}, ReadJson not writed.");
        }

        /// запись json
        public override void WriteJson(JsonWriter writer, [AllowNull] iBXFilterValue<T> value, JsonSerializer serializer)
        {

            writer.WriteStartObject();
            if (value != null)
            {
                foreach (KeyValuePair<SpecialCharacter, T> kvp in value)
                {
                    foreach (var prop in kvp.Value.GetType().GetProperties())
                    {
                        var writeValue = prop.GetValue(kvp.Value);
                        if (writeValue != null)
                        {
                            writer.WritePropertyName(Base.GetDescriptionEnum(kvp.Key) + prop.Name);
                            if (writeValue is IList writeEndValue)
                            {
                                writer.WriteStartArray();
                                foreach (var item in writeEndValue)
                                {
                                    writer.WriteValue(item);
                                }

                                writer.WriteEndArray();
                            }
                            else
                            {
                                writer.WriteValue(writeValue);
                            }
                        }
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}
