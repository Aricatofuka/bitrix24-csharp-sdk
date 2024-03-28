using Newtonsoft.Json;
using BXRest.Core.Models.Response.Common;

namespace BXRest.Core.Models.Response.BatchResponse
{
    /// Ответ от метода в который бихаються несколько методов
    public class BatchResponse<TCmdResultItem>
    {
        /// Все ответы
        [JsonProperty("result")]
        public BatchResponseResult<TCmdResultItem> Result { get; set; }

        /// Общее время выполнения
        [JsonProperty("time")]
        public Time Time { get; set; }
    }
}
