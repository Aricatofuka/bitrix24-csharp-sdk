using Newtonsoft.Json;

namespace BXRest.Core.Models.Response
{
    public class iGetItemResponse<TEntity>
    {
        [JsonProperty("item")]
        public TEntity Item { get; set; }
    }
}
