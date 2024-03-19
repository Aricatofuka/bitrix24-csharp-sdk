# nullable enable
using BXRest.Converter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using static BXRest.Api.Models.Base;

namespace BXRest.Models.SonetGroup
{
    /// Параметры получения группы
    public class iGet: iBXRestBaseParam
    {
        /// Переключатель возможности отфильтравать группы под админскими провами 
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(YesNoBXParamRequest))]
        public bool? IS_ADMIN { get; set; }
        /// Направление сокртировки выдачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public iGetOrder? ORDER { get; set; }

        /// Фильтр по выдаче
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public iGetFilter? FILTER { get; set; }
    }

    /// Направление сокртировки выдачи
    public class iGetOrder 
    {
        /// Индификатор записи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int>? ID { get; set; }

        /// Индификатор сайта
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SITE_ID { get; set; }

        /// Имя группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? NAME { get; set; }

        /// Дата создания
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATE { get; set; }

        /// Дата обновления
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATE { get; set; }

        /// Последняя дата активности
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_ACTIVITY { get; set; }

        /// Активна ли еще группа
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(YesNoBXParamRequest))]
        public bool? ACTIVE { get; set; }

        /// Видна ли группа
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(YesNoBXParamRequest))]
        public bool? VISIBLE { get; set; }

        /// Открыта ли группа
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(YesNoBXParamRequest))]
        public bool? OPENED { get; set; }

        /// Закрыта ли группа
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(YesNoBXParamRequest))]
        public bool? CLOSED { get; set; }

        /// Код темы 
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SUBJECT_ID { get; set; }

        /// Владелец группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? OWNER_ID { get; set; }

        /// Кол-во участников группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? NUMBER_OF_MEMBERS { get; set; }

        /// Кто имеет право на приглашение пользователей в группу (обязательное поле):
        /// A - только владелец группы,
        /// E - владелец группы и модераторы группы,
        /// K - все члены группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? INITIATE_PERMS { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SPAM_PERMS { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? SUBJECT_NAME { get; set; }

        /// Имя держателя группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? OWNER_NAME { get; set; }

        /// Фамилия держателя группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? OWNER_LAST_NAME { get; set; }

        /// Логин держателя группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? OWNER_LOGIN { get; set; }
    }

    /// Фильтр для получения группы через апи
    public class iGetFilter
    {
        /// Индификатор
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int?>? ID { get; set; }

        /// Индификатор сайта группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SITE_ID { get; set; }

        /// Дата создания группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATE { get; set; }

        /// Дата последнего обновления группы (описание, группа, список пользователей)
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATE { get; set; }

        /// Дата последней активноти группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_ACTIVITY { get; set; }

        /// Переключатель проверки активности группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(YesNoBXParamRequest))]
        public bool? ACTIVE { get; set; }

        /// Переключатель проверки видимости группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(YesNoBXParamRequest))]
        public bool? VISIBLE { get; set; }

        /// Переключатель проверки открытости группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(YesNoBXParamRequest))]
        public bool? OPENED { get; set; }

        /// Переключатель проверки закрытости группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(YesNoBXParamRequest))]
        public bool? CLOSED { get; set; }

        /// Код темы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SUBJECT_ID { get; set; }

        /// инидификатор держателья группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? OWNER_ID { get; set; }

        /// Кол-во учатников группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? NUMBER_OF_MEMBERS { get; set; }

        /// Кто имеет право на приглашение пользователей в группу (обязательное поле):
        /// A - только владелец группы,
        /// E - владелец группы и модераторы группы,
        /// K - все члены группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? INITIATE_PERMS { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SPAM_PERMS { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? SUBJECT_NAME { get; set; }

        /// Имя держателья группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? OWNER_NAME { get; set; }

        /// Фамилия держателья группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? OWNER_LAST_NAME { get; set; }

        /// Логин держателья группы
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? OWNER_LOGIN { get; set; }

        /// Проверка пермишинов
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(YesNoBXParamRequest))]
        public bool? CHECK_PERMISSIONS { get; set; }
    }
}
