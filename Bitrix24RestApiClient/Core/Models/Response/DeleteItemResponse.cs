using Newtonsoft.Json;
using BXRest.Core.Models.Response.Common;

namespace BXRest.Core.Models.Response
{
    public class DeleteItemResponse
    {
        [JsonProperty("time")]
        public Time Time { get; set; }
    }
}
