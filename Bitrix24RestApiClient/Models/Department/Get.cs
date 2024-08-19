#nullable enable
using Newtonsoft.Json;
using System.Collections.Generic;
using static BXRest.Api.Models.Base;

namespace BXRest.Models.Department
{
    /// Параметры для получения
    public class iGetParam : iBXRestBaseParam
    {
        /// фильтр по идентификатору подразделения
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<uint>? ID { get; set; }

        /// NAME
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? NAME { get; set; }

        /// поле, по которому сортируются результаты
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SORT { get; set; }

        /// фильтр по родительскому подразделению
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? PARENT { get; set; }

        /// фильтр по руководителю подразделения
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? UF_HEAD { get; set; }

        /// поле, по которому сортируются результаты
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public iBXRestOrder? ORDER { get; set; }
    }

    /// Отдельный элементы в ответе метода
    public class iGetItem
    {
        /// ID подразделения
        public uint ID { get; set; }

        /// Название подразделения
        public string NAME { get; set; }

        /// ID Родительского подразделения
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? PARENT { get; set; }

        /// ID Руководителя
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? UF_HEAD { get; set; }

        /// Сортировочный номер (возможно влияет на порядок выдачи, не знаю)
        public int SORT { get; set; }

        /* это не работает почемуто
        /// логика для получения уникальных значений при вызове метода Distinct
        public bool Equals(iGetItem other)
        {
            //Check whether the compared object is null.
            if (Object.ReferenceEquals(other, null)) return false;

            //Check whether the compared object references the same data.
            if (Object.ReferenceEquals(this, other)) return true;

            //Check whether the products' properties are equal.
            return ID.Equals(other.ID);
        }
        */
    }
}
