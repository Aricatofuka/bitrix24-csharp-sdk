#nullable enable
using Newtonsoft.Json;
using System.Collections.Generic;
using static BXRest.Api.Models.Base;

namespace BXRest.Models.User
{
    /// Параметры для получения пользователя
    public class iGet: iBXRestBaseParam
    {
        /// Идентификатор
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

        /// Идентификатор
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<uint>? ID { get; set; }

        /// День рождение
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? PERSONAL_BIRTHDAY { get; set; }

        /// Идентификаторы подразделений
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<uint>? UF_DEPARTMENT { get; set; }

        /// Номер телефона
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? UF_PHONE_INNER { get; set; }

        /// Онлайн в текущий момент
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public iBXRestYesNo? IS_ONLINE { get; set; }

        /// быстрый поиск по персональным данным.
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? NAME_SEARCH { get; set; }

        /// тип пользователя. Может принимать следующие значения:
        /// employee - сотрудник,
        /// extranet - пользователь экстранета,
        /// email - почтовый пользователь
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? USER_TYPE { get; set; }

        /// Отсутствует бан на профиле
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ACTIVE { get; set; }
    }
}
