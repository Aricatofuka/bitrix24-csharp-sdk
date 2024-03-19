using BXRest.Converter;
using System;
using Newtonsoft.Json;

namespace BXRest.Models.SonetGroup
{
    /// Элемент - группа
    public class iGroup
    {
        /// Индификатор
        public uint ID { get; set; }

        /// Индификатор сайта
        public string SITE_ID { get; set; }

        /// Назавание группы
        public string NAME { get; set; }

        /// Описание
        public string DESCRIPTION { get; set; }

        /// Дата создания
        public DateTime? DATE_CREATE { get; set; }

        /// Дата обновления
        public DateTime? DATE_UPDATE { get; set; }

        /// Активна ли еще группа
        [JsonConverter(typeof(YesNoBX))]
        public bool? ACTIVE { get; set; }
        
        /// Видна ли группа
        [JsonConverter(typeof(YesNoBX))]
        public bool? VISIBLE { get; set; }

        /// Открыта ли группа
        [JsonConverter(typeof(YesNoBX))]
        public bool? OPENED { get; set; }
        
        /// Закрыта ли группа
        [JsonConverter(typeof(YesNoBX))]
        public bool? CLOSED { get; set; }

        public uint? SUBJECT_ID { get; set; }
        public uint? OWNER_ID { get; set; }
        public uint? NUMBER_OF_MEMBERS { get; set; }
        public DateTime? DATE_ACTIVITY { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool? PROJECT { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool? IS_EXTRANET { get; set; }

    }
}
