using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace BXRest.Converter
{
    /// <summary>
    /// Обьект или его дефолтное представление
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ObjectOrDef<T> : JsonConverter
    {
        /// <summary>
        /// Чтение из json
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                // Читаем значение свойства
                var token = JToken.Load(reader);
                // Если тип значения соответствует типу T, возвращаем его
                return token.ToObject<T>();
            }
            catch (Exception)
            {
                // Если произошла ошибка, возвращаем значение по умолчанию
            }
       
            return default(T);
        }

        /// <summary>
        /// Запись в json (скорей всего сломано) TODO: проверить сломано ли
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // Просто записываем значение свойства
            writer.WriteValue(value);
        }

        /// <summary>
        /// Всегда можно конверитровать
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
