using BXRest.Converter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using static BXRest.Api.Models.Base;
using static BXRest.Models.Parameter.Request.Filter;

namespace BXRest.Api.Models.Tasks.ElapsedItem
{
    public class iGetList : iBXRestBaseParamAlternative
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? TASKID { get; set; }
        public iGetListOrder ORDER { get; set; } = new iGetListOrder()
        {
            ID = iBXRestOrder.Asc,
        };
        // public BXRestFilterGenerator<iGetFilter> FILTER { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FilterWithSpecialCharacter<iGetListFilter>))]
        public iBXFilterValue<iGetListFilter>? FILTER { get; set; }

        public List<string>? SELECT { get; set; } = new List<string>() { "*" };
    }

    /*
    public class MyModel
    {
        [JsonProperty(Base.GetDescriptionEnum(SpecialCharacter.More) + nameof(CREATED_DATE))]
        public KeyValuePair<SpecialCharacter, string> CREATED_DATE { get; set; }
    }
    */

    public class iGetListFilter
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? ID { get; set; } // идентификатор комментария

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<uint>? USER_ID { get; set; } // идентификатор пользователя, от имени которого была сделана запись о затраченном времени

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CREATED_DATE { get; set; } // дата создания записи
    }

    public class iGetListFilterTest
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int>? ID { get; set; } // идентификатор комментария

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int>? USER_ID { get; set; } // идентификатор пользователя, от имени которого была сделана запись о затраченном времени

       // [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(FilterWithSpecialCharacter<DateTime>))]
        public KeyValuePair<SpecialCharacter, DateTime>? CREATED_DATE { get; set; } // дата создания записи
    }
    
    public class iGetListOrder
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? ID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? USER_ID { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? MINUTES { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? SECONDS { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? CREATED_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? DATE_START { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(OrderBX))]
        public iBXRestOrder? DATE_STOP { get; set; }
    }
}
