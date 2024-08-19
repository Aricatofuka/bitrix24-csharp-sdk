using Newtonsoft.Json;
using System;

namespace BXRest.Models.Tasks.ElapsedItem
{
    /// Элемент списка треков по задачам
    public class iElapsedItem
    {
        /// Уникальный идентификатор
        public uint ID { get; set; }

        /// Минуты
        public int MINUTES { get; set; }

        /// Секунды
        public int SECONDS { get; set; }

        /// Идентификатор задачи
        public uint TASK_ID { get; set; }

        /// Текст комментария
        public string COMMENT_TEXT { get; set; }

        /// Идентификатор задачи
        public uint USER_ID { get; set; }
        public int SOURCE { get; set; }

        /// Дата и время создания
        public DateTime CREATED_DATE { get; set; }

        /// Дата и время старта
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime DATE_START { get; set; }

        /// Дата и время остановки
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime DATE_STOP { get; set; }
    }
}
