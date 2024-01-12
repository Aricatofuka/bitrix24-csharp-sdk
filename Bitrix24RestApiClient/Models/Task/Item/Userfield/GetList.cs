using Newtonsoft.Json;
using System.Collections.Generic;
using static BXRest.Api.Models.Base;

namespace BXRest.Models.Task.Item.Userfield
{
    /// Модель для получения кастомных поле задач из битрикса
    /// TODO: проверить
    public class iGetList: iBXRestBaseParam
    {
        /// Направление
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Dictionary<string, string>> ORDER { get; set; }

        /// Фильтр
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Dictionary<string, string>> FILTER { get; set; }
    }
}
