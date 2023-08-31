using Newtonsoft.Json;

namespace BXRest.Core.Models.Response.AddItemResponse
{
    public class UpdateItemResponseItem<TEntity>
    {
        [JsonProperty("item")]
        public TEntity Item { get; set; }
    }
}
