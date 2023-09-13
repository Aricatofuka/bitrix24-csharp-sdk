using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BXRest.Converter
{
    /// <summary>
    /// Преобразуем всякое дерьмо которое не может определиться обьект оно с ключами - значениями или просто массив
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class DictionaryButArrayIfNull<K, T> : JsonConverter<Dictionary<K, T>>
    {

        public override Dictionary<K, T> ReadJson(JsonReader reader, Type objectType, [AllowNull] Dictionary<K, T> existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
        {

            try
            {
                return  (Dictionary<K, T>)JsonConvert.DeserializeObject(reader.Value?.ToString());
            } 
            catch 
            {
                return new Dictionary<K, T>();
            }
       
        }

        public override void WriteJson(JsonWriter writer, [AllowNull] Dictionary<K, T> value, Newtonsoft.Json.JsonSerializer serializer)
        {
            writer.WriteValue(value);
            // throw new Newtonsoft.Json.JsonException("DictionaryButArrayIfNull not writed.");
            // throw new NotImplementedException();
        }

      // public override bool CanWrite { get { return false; } }
    }
}
