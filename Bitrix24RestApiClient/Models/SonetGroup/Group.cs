using BXRest.Converter;
using System;
using Newtonsoft.Json;

namespace BXRest.Models.SonetGroup
{
    public class iGroup
    {
        public int ID { get; set; }
        public string SITE_ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public DateTime? DATE_CREATE { get; set; }
        public DateTime? DATE_UPDATE { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool? ACTIVE { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool? VISIBLE { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool? OPENED { get; set; }
         
        [JsonConverter(typeof(YesNoBX))]
        public bool? CLOSED { get; set; }
        public int? SUBJECT_ID { get; set; }
        public int? OWNER_ID { get; set; }
        public int? NUMBER_OF_MEMBERS { get; set; }
        public DateTime? DATE_ACTIVITY { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool? PROJECT { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool? IS_EXTRANET { get; set; }

    }
}
