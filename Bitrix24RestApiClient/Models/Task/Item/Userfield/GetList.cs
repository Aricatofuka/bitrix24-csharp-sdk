using Newtonsoft.Json;
using System.Collections.Generic;
using static BXRest.Api.Models.Base;

namespace BXRest.Models.Task.Item.Userfield
{
    /// <summary>
    /// Модель для получения кастомных поле задач из битрикса
    /// TODO: проверить
    /// </summary>
    public class iGetList: iBXRestBaseParam
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Dictionary<string, string>> ORDER { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Dictionary<string, string>> FILTER { get; set; }
    }
}
