#nullable enable
using Newtonsoft.Json;
using System.Collections.Generic;
using static BXRest.Api.Models.Base;

namespace BXRest.Models.User
{
    /// Параметры для получения пользователя
    public class iGet: iBXRestBaseParam
    {
        /// Индификатор
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<uint>? ID { get; set; }
        
        /// Направление сортировка
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? order { get; set; }

        /// Основной фильтр
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public iGetFilter? FILTER { get; set; }

    }

    /// Фильтр запроса пользователя, относиться к модели выше
    public class iGetFilter {

        /// Индификатор
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<uint>? ID { get; set; }

        /// День рождение
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? PERSONAL_BIRTHDAY { get; set; }

        /// Индификаторы подразделений
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<uint>? UF_DEPARTMENT { get; set; }

        /// Номер телефона
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? UF_PHONE_INNER { get; set; }

        /// Онлаин в текущий момент
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public iBXRestYesNo? IS_ONLINE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? NAME_SEARCH { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? USER_TYPE { get; set; }

        /// Отсуствует бан на профиле
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ACTIVE { get; set; }
    }
}
