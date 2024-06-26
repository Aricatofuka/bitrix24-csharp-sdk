﻿#nullable enable
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Reflection;

namespace BXRest.Api.Models
{
    /// Базовые модели запроса к битриксу
    public static class Base
    {
        /// Базовые параметры запросов
        public class iBXRestBaseParam
        {
            /// Откуда начинать выгрузку если используем постраничную навигацию
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public int? start { get; set; }
        }

        /// Альтернативные базовые параметры запросов
        public class iBXRestBaseParamAlternative
        {
            /// Альтернативные параметры навигации если используенм постраничную навигацию
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public iParam? PARAMS { get; set; }
        }

        /// Параметры для альтернативной постраничной навигации
        public class iParam
        {
            /// Внутренние параметры для альтернативной постраничной навигации
            public iGetParamNavParams NAV_PARAMS { get; set; }
        }

        /// Внутренние параметры для альтернативной постраничной навигации
        public class iGetParamNavParams
        {
            /// колличество элементов на странице. В целях ограничения нагрузки на постраничную навигацию наложено ограничение в 50 записей
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public int? nPageSize { get; set; }

            /// номер страницы при постраничной навигации.
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public int? iNumPage { get; set; } 
        }

        /// Представление битрикса о true и false 
        public enum iBXRestYesNo
        {
            /// true
            Y = 'Y',
            /// false
            N = 'N'
        }

        /// Направление сортировки
        public enum iBXRestOrder
        {
            /// по возрастанию
            [Description("asc")]
            Asc,

            /// по убыванию
            [Description("desc")]
            Desc
        }

        /// достает Description у Enum если он у него есть
        public static string GetDescriptionEnum(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            if (field == null) return value.ToString();
            DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
            return attribute != null ? attribute.Description : value.ToString();
        }

        /// Пораметры для подтвержедния автроризации по rest api
        public class iBXAuth
        {
            /// Сам токен авторизации
            public string auth { get; set; }
            /*

            enum MyEnum
            {
                Value1 = new List<char> { 's', 't' },
                Value2 = new List<char> { 's', 't' },
                Value3 = iBXRestOrder
            }
            */

            /*
            public sealed class iBXRestOrder : SmartEnum<iBXRestOrder>
            {
                public static readonly iBXRestOrder Asc = new("asc", 1);

                public static readonly iBXRestOrder Desc = new("desc", 2);

                private iBXRestOrder(string name, int value) : base(name, value)
                {
                }
            }
            */

            /*
            public enum iBXRestOrder 
            {
                [Description("asc")]
                asc,
                [Description("desc")]
                desc
            }
            */

            /*
            public abstract class Enumeration : IComparable
            {
                public string Name { get; private set; }

                public int Id { get; private set; }

                protected Enumeration(int id, string name) => (Id, Name) = (id, name);

                public override string ToString() => Name;

                public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
                    typeof(T).GetFields(BindingFlags.Public |
                                        BindingFlags.Static |
                                        BindingFlags.DeclaredOnly)
                             .Select(f => f.GetValue(null))
                             .Cast<T>();

                public override bool Equals(object obj)
                {
                    if (obj is not Enumeration otherValue)
                    {
                        return false;
                    }

                    var typeMatches = GetType().Equals(obj.GetType());
                    var valueMatches = Id.Equals(otherValue.Id);

                    return typeMatches && valueMatches;
                }

                public int CompareTo(object other) => Id.CompareTo(((Enumeration)other).Id);


                // Other utility methods ...
            }

            /*
            public static Dictionary<int, string> iBXRestOrder = new Dictionary<int, string>()
            {
                    { 1, "asc"},

                    { 2, "desc"}
            };
            */

            /*
            public readonly struct iBXRestOrder : IEquatable<iBXRestOrder>
            {
                private readonly string _value;

                public static iBXRestOrder Asc { get; } = new iBXRestOrder("asc");
                public static iBXRestOrder Desc { get; } = new iBXRestOrder("desc");

                public iBXRestOrder(string value)
                {
                    _value = value;
                }

                public override bool Equals(object obj)
                {
                    return obj is iBXRestOrder p && Equals(p);
                }

                public bool Equals(iBXRestOrder other)
                {
                    return _value == other._value;
                }

                public static bool operator ==(iBXRestOrder left, iBXRestOrder right) => Equals(left, right);

                public static bool operator !=(iBXRestOrder left, iBXRestOrder right) => !Equals(left, right);

                public static explicit operator string(iBXRestOrder value) => value.ToString();

                public static explicit operator iBXRestOrder(string value) => new iBXRestOrder(value);

                public override string? ToString() => _value;
            }


            // Console.WriteLine(CountryType.UnitedStates); // "United States"

            */
        }
    }
}
