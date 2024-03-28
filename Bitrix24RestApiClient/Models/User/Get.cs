﻿using Newtonsoft.Json;
using System.Collections.Generic;
using static BXRest.Api.Models.Base;

namespace BXRest.Models.User
{
    /// Параметры для получения пользователя
    public class iGet: iBXRestBaseParam
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<uint>? ID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? order { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public iGetFilter? FILTER { get; set; }

    }

    /// Фильтр запроса пользователя, относиться к модели выше
    public class iGetFilter {


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<uint>? ID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? PERSONAL_BIRTHDAY { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int>? UF_DEPARTMENT { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? UF_PHONE_INNER { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public iBXRestYesNo? IS_ONLINE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? NAME_SEARCH { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? USER_TYPE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? ACTIVE { get; set; }
    }
}
