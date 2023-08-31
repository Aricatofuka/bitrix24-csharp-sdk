using Newtonsoft.Json;
using BXRest.Core.Models.Response.Common;

namespace BXRest.Core.Models.Response
{
    public class AddResponse
    {
        [JsonProperty("result")]
        public int Result { get; set; }

        [JsonProperty("time")]
        public Time Time { get; set; }
    }
}
