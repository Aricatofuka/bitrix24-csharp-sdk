using BXRest.Converter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using static BXRest.Api.Models.Base;
using static BXRest.Models.Parameter.Request.Filter;

namespace BXRest.Api.Models.Tasks.ElapsedItem
{
    /// Параметры для получения списока треков по задачам
    public class iGetList : iBXRestBaseParamAlternative
    {
        /// id задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? TASKID { get; set; }

        /// Сортировка
        public iGetListOrder ORDER { get; set; } = new iGetListOrder()
        {
            ID = iBXRestOrder.Asc,
        };
        // public BXRestFilterGenerator<iGetFilter> FILTER { get; set; }

        /// Фильтр
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FilterWithSpecialCharacter<iGetListFilter>))]
        public iBXFilterValue<iGetListFilter>? FILTER { get; set; }

        /// Выбр выгружаемых полей задач ("*" - все поля, стоит по уумолчанию) 
        /// + если нужны все с кастомными то надо писать - "*" и хотябы одно кастовое поле
        public List<string>? SELECT { get; set; } = new List<string>() { "*" };
    }

    /*
    public class MyModel
    {
        [JsonProperty(Base.GetDescriptionEnum(SpecialCharacter.More) + nameof(CREATED_DATE))]
        public KeyValuePair<SpecialCharacter, string> CREATED_DATE { get; set; }
    }
    */

    /// Фильтр для треков времени по задачам
    public class iGetListFilter
    {
        /// уникальный индификатор
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? ID { get; set; } // идентификатор комментария

        /// Индификатор пользователя
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<uint>? USER_ID { get; set; } // идентификатор пользователя, от имени которого была сделана запись о затраченном времени

        /// Дата создания
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CREATED_DATE { get; set; } // дата создания записи
    }
    
    /// Список направлений фильтра по трекам задач
    public class iGetListOrder
    {
        /// Индификатор
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? ID { get; set; }

        /// Индификатор пользователя
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? USER_ID { get; set; }

        /// Минуты
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? MINUTES { get; set; }

        /// Секунды
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? SECONDS { get; set; }

        /// Дата создания
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? CREATED_DATE { get; set; }

        /// Дата и время старта
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? DATE_START { get; set; }

        /// Дата и время остановки
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? DATE_STOP { get; set; }
    }
}
