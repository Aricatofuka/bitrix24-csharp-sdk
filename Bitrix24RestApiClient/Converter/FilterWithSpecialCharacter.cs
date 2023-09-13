using BXRest.Api.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using static BXRest.Models.Parameter.Request.Filter;

namespace BXRest.Converter
{

    public class FilterWithSpecialCharacter<T> : JsonConverter<iBXFilterValue<T>>
    {

        // возможно когданибудь надг будет написать, но сейчас в этом нет никакого смысла
        public override iBXFilterValue<T> ReadJson(JsonReader reader, Type objectType, [AllowNull] iBXFilterValue<T> existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
        {

            string boolValue = reader.Value?.ToString().ToLower();
            throw new Newtonsoft.Json.JsonException($"{reader.Path}:{boolValue}, ReadJson not writed.");
        }

        public override void WriteJson(JsonWriter writer, [AllowNull] iBXFilterValue<T> value, Newtonsoft.Json.JsonSerializer serializer)
        {

            writer.WriteStartObject();
            foreach (KeyValuePair<SpecialCharacter, T> kvp in value)
            {
                foreach (var prop in kvp.Value.GetType().GetProperties())
                {
                    var writeValue = prop.GetValue(kvp.Value);
                    if (writeValue != null)
                    {
                        writer.WritePropertyName(Base.GetDescriptionEnum(kvp.Key) + prop.Name);
                        if (writeValue is IList)
                        {
                            var writeEndValue = (IList)writeValue;
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
            writer.WriteEndObject();
            
          
        }
    }
}
