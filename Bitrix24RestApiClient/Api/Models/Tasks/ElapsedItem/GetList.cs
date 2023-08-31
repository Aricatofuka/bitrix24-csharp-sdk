using BXRest.Converter;
using Newtonsoft.Json;
using System.Collections.Generic;
using static BXRest.Api.Models.Base;

namespace BXRest.Api.Models.Tasks.ElapsedItem
{
    public class iGetList
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? TASKID { get; set; }
        public iGetListOrder ORDER { get; set; } = new iGetListOrder()
        {
            ID = iBXRestOrder.Asc,
        };
        // public BXRestFilterGenerator<iGetFilter> FILTER { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public iGetListFilter? FILTER { get; set; }

        public List<string>? SELECT { get; set; } = new List<string>() { "*" };


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public iGetListFilter? PARAMS { get; set; }
    }

    public class iGetListFilter
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? ID { get; set; } // идентификатор комментария

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int>? USER_ID { get; set; } // идентификатор пользователя, от имени которого была сделана запись о затраченном времени

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? CREATED_DATE { get; set; } // дата создания записи
    }

    public class iGetListOrder
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? ID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? USER_ID { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? MINUTES { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? SECONDS { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? CREATED_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? DATE_START { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? DATE_STOP { get; set; }
    }


    public class iGetListParam
    {
        public iGetListParamNavParams NAV_PARAMS { get; set; }
    }

    public class iGetListParamNavParams
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? nPageSize { get; set; }  // колличество элементов на странице. В целях ограничения нагрузки на постраничную навигацию наложено ограничение в 50 записей.

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? iNumPage { get; set; } //  номер страницы при постраничной навигации.
    }
}
