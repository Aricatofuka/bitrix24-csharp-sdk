using Newtonsoft.Json;

namespace BXRest.Core.Models.Response.BatchResponse
{
    /// Ответ описывающи ошибку из метода работающим сразу с несколькомми методами
    public class BatchResponseResultError
    {
        /// Ошибка
        [JsonProperty("error")]
        public string Error { get; set; }

        /// Описание ошибки
        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}
