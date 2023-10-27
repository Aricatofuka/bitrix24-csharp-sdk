using Newtonsoft.Json;
using System;

namespace BXRest.Models.Tasks.ElapsedItem
{
    public class iElapsedItem
    {
        public uint ID { get; set; }
        public int MINUTES { get; set; }
        public int SECONDS { get; set; }
        public uint TASK_ID { get; set; }
        public string COMMENT_TEXT { get; set; }
        public uint USER_ID { get; set; }
        public int SOURCE { get; set; }
        public DateTime CREATED_DATE { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime DATE_START { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime DATE_STOP { get; set; }
    }
}
