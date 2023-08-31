using Newtonsoft.Json;
using BXRest.Core.Models.Response.Common;

namespace BXRest.Core.Models.Response.AddItemResponse
{
    public class UpdateItemResponse<TEntity>
    {
        [JsonProperty("result")]
        public UpdateItemResponseItem<TEntity> Result { get; set; }

        [JsonProperty("time")]
        public Time Time { get; set; }
    }
}
