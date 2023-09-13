using BXRest.Converter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using static BXRest.Api.Models.Base;

namespace BXRest.Models.SonetGroup
{
    public class iGet: iBXRestBaseParam
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public iGetOrder? ORDER { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public iGetFilter? FILTER { get; set; }

        // TODO: добавить arGroupBy, arNavStartParams, arSelectFields 
    }

    public class iGetOrder 
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int>? ID { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SITE_ID { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? NAME { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATE { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATE { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_ACTIVITY { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonConverter(typeof(YesNoBX))]
        public bool? ACTIVE { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonConverter(typeof(YesNoBX))]
        public bool? VISIBLE { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonConverter(typeof(YesNoBX))]
        public bool? OPENED { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonConverter(typeof(YesNoBX))]
        public bool? CLOSED { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SUBJECT_ID { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? OWNER_ID { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? NUMBER_OF_MEMBERS { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? INITIATE_PERMS { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SPAM_PERMS { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? SUBJECT_NAME { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? OWNER_NAME { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? OWNER_LAST_NAME { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? OWNER_LOGIN { get; set; }
    }
    public class iGetFilter
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int?>? ID { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SITE_ID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATE { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATE { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_ACTIVITY { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonConverter(typeof(YesNoBX))]
        public bool? ACTIVE { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonConverter(typeof(YesNoBX))]
        public bool? VISIBLE { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonConverter(typeof(YesNoBX))]
        public bool? OPENED { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonConverter(typeof(YesNoBX))]
        public bool? CLOSED { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SUBJECT_ID { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? OWNER_ID { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? NUMBER_OF_MEMBERS { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? INITIATE_PERMS { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SPAM_PERMS { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? SUBJECT_NAME { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? OWNER_NAME { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? OWNER_LAST_NAME { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? OWNER_LOGIN { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [System.Text.Json.Serialization.JsonConverter(typeof(YesNoBX))]
        public bool? CHECK_PERMISSIONS { get; set; }

        
    }
}
