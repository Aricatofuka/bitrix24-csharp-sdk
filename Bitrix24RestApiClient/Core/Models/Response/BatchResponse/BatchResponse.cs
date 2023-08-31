using Newtonsoft.Json;
using BXRest.Core.Models.Response.BatchResponse;
using BXRest.Core.Models.Response.Common;

namespace BXRest.Core.Models.Response.BatchResponse
{
    public class BatchResponse<TCmdResultItem>
    {
        [JsonProperty("result")]
        public BatchResponseResult<TCmdResultItem> Result { get; set; }

        [JsonProperty("time")]
        public Time Time { get; set; }
    }
}
