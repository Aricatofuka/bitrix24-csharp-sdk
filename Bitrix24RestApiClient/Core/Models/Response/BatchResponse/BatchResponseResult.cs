using Newtonsoft.Json;
using System.Collections.Generic;
using BXRest.Core.Models.Response.Common;

namespace BXRest.Core.Models.Response.BatchResponse
{
    /// Модель ответа метода в который пихаться методы
    public class BatchResponseResult<TCmdResultItem>
    {
        /// Результат
        [JsonIgnore]
        public Dictionary<string, TCmdResultItem> Result
        {
            get {
                string str = JsonConvert.SerializeObject(ResultExt);
                if (str == "[]")
                {
                    return [];
                }
                return JsonConvert.DeserializeObject<Dictionary<string, TCmdResultItem>>(str);
            }
        }

        /// Результат
        [JsonProperty("result")]
        public object ResultExt { get; set; }

        /// Массив ошибок
        [JsonIgnore]
        public Dictionary<string, BatchResponseResultError> Error
        {
            get
            {
                string str = JsonConvert.SerializeObject(ErrorExt);
                if (str == "[]")
                {
                    return [];
                }
                return JsonConvert.DeserializeObject<Dictionary<string, BatchResponseResultError>>(str);
            }
        }

        /// Общая ошибка
        [JsonProperty("result_error")]
        public object ErrorExt { get; set; }

        /// Подсчёт всех возможных элементов для ответа для каждого метода
        [JsonIgnore]
        public Dictionary<string, int> Total
        {
            get
            {
                string str = JsonConvert.SerializeObject(TotalExt);
                if (str == "[]")
                {
                    return [];
                }
                return JsonConvert.DeserializeObject<Dictionary<string, int>>(str);
            }
        }

        /// Каким должен быть конечный результат, его количество
        [JsonProperty("result_total")]
        public object TotalExt { get; set; }

        /// Следующий номер с которого начинать забор массива ответов
        [JsonIgnore]
        public Dictionary<string, int> Next
        {
            get
            {
                string str = JsonConvert.SerializeObject(NextExt);
                if (str == "[]")
                {
                    return [];
                }
                return JsonConvert.DeserializeObject<Dictionary<string, int>>(str);
            }
        }

        /// Следующий номер с которого начинать забор массива ответов
        [JsonProperty("result_next")]
        public object NextExt { get; set; }

        /// Время выполнения каждого метода
        [JsonIgnore]
        public Dictionary<string, Time> Time
        {
            get
            {
                string str = JsonConvert.SerializeObject(TimeExt);
                if (str == "[]")
                {
                    return [];
                }
                return JsonConvert.DeserializeObject<Dictionary<string, Time>>(str);
            }
        }
        /// Время выполнения запроса
        [JsonProperty("result_time")]
        public object TimeExt { get; set; }
    }
}
