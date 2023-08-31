using Newtonsoft.Json;
using BXRest.Core.Models.Response.Common;

namespace BXRest.Core.Models.Response.AddItemResponse
{
    public class AddItemResponse<TEntity>
    {
        [JsonProperty("result")]
        public AddItemResponseItem<TEntity> Result { get; set; }

        [JsonProperty("time")]
        public Time Time { get; set; }
    }
}
