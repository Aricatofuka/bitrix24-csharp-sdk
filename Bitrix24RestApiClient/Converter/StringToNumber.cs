using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace BXRest.Converter
{
    /// Конвертер строки в число с указанием типа числа
    public class StringToNumberConverter<T> : JsonConverter<T>
    {

        /// чтение json
        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
            {
                return default(T);
            }

            var strValue = reader.Value.ToString();

            if (typeof(T) == typeof(int))
                return (T)(object)int.Parse(strValue);
            if (typeof(T) == typeof(long))
                return (T)(object)long.Parse(strValue);
            if (typeof(T) == typeof(float))
                return (T)(object)float.Parse(strValue);
            if (typeof(T) == typeof(double))
                return (T)(object)double.Parse(strValue);
            if (typeof(T) == typeof(decimal))
                return (T)(object)decimal.Parse(strValue);
            if (typeof(T) == typeof(DateTime))
                return (T)(object)DateTime.Parse(strValue);

            // Обработка перечислений
            if (typeof(T).IsEnum)
            {
                return (T)Enum.Parse(typeof(T), strValue, ignoreCase: true);
            }

            // Использование конвертера TypeDescriptor для неподдерживаемых типов
            if (TypeDescriptor.GetConverter(typeof(T)).CanConvertFrom(typeof(string)))
            {
                return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(strValue);
            }

            return default(T);
        }

        /// запись json
        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }
    }
}
