using Newtonsoft.Json;
using BXRest.Core.Models.Response.Common;

namespace BXRest.Core.Models.Response
{
    public class DeleteResponse
    {
        [JsonProperty("result")]
        public bool? Result { get; set; }

        [JsonProperty("time")]
        public Time Time { get; set; }
    }
}
