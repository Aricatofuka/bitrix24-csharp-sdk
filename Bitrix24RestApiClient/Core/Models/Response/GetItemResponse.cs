using Newtonsoft.Json;
using BXRest.Core.Models.Response.Common;

namespace BXRest.Core.Models.Response
{
    public class GetItemResponse<TEntity>
    {
        [JsonProperty("item")]
        public TEntity Item { get; set; }
    }
}
