using Newtonsoft.Json;
using System.Collections.Generic;
using static BXRest.Api.Models.Base;

namespace BXRest.Api.Models.Tasks.Task
{
    public class iList
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public iListOrder? order { get; set; }
        public iListFilter filter { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<iBXRestTaskFieldsName>? select { get; set; }
    }


    public class iListResult
    {
        public List<iTask> tasks { get; set; }

    }

    public class iListOrder
    {
        public iBXRestOrder? ID { get; set; }
        public iBXRestOrder? TITLE { get; set; }
        public iBXRestOrder? TIME_SPENT_IN_LOGS { get; set; }
        public iBXRestOrder? DATE_START { get; set; }
        public iBXRestOrder? CREATED_DATE { get; set; }
        public iBXRestOrder? CHANGED_DATE { get; set; }
        public iBXRestOrder? CLOSED_DATE { get; set; }
        public iBXRestOrder? START_DATE_PLAN { get; set; }
        public iBXRestOrder? END_DATE_PLAN { get; set; }
        public iBXRestOrder? DEADLINE { get; set; }
        public iBXRestOrder? REAL_STATUS { get; set; }
        public iBXRestOrder? STATUS_COMPLETE { get; set; }
        public iBXRestOrder? PRIORITY { get; set; }
        public iBXRestOrder? MARK { get; set; }
        public iBXRestOrder? CREATED_BY_LAST_NAME { get; set; }
        public iBXRestOrder? RESPONSIBLE_LAST_NAME { get; set; }
        public iBXRestOrder? GROUP_ID { get; set; }
        public iBXRestOrder? TIME_ESTIMATE { get; set; }
        public iBXRestOrder? ALLOW_CHANGE_DEADLINE { get; set; }
        public iBXRestOrder? ALLOW_TIME_TRACKING { get; set; }
        public iBXRestOrder? MATCH_WORK_TIME { get; set; }
        public iBXRestOrder? FAVORITE { get; set; }
        public iBXRestOrder? SORTING { get; set; }
        public iBXRestOrder? MESSAGE_ID { get; set; }
    }

    public class iListFilter
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int>? ID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? GreaterThanID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? LessThanID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? GreaterThanOrEqualID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? LessThanOrEqualID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? EqualToID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? NotEqualToID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ACTIVITY_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? GreaterThanACTIVITY_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? GreaterThanOrEqualACTIVITY_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? LessThanACTIVITY_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? LessThanOrEqualACTIVITY_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? NotEqualToACTIVITY_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? PARENT_ID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? GROUP_ID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? CREATED_BY { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? STATUS_CHANGED_BY { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? PRIORITY { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? FORUM_TOPIC_ID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? RESPONSIBLE_ID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? TITLE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? TAG { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int>? REAL_STATUS { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int>? STATUS { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? MARK { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SITE_ID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ADD_IN_REPORT { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ALLOW_TIME_TRACKING { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? DATE_START { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? DEADLINE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? CREATED_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? GreaterThanCREATED_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? LessThanCREATED_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? GreaterThanOrEqualCREATED_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? LessThanOrEqualCREATED_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? CLOSED_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? CHANGED_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? GreaterThanCHANGED_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? LessThanCHANGED_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? GreaterThanOrEqualCHANGED_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? LessThanOrEqualCHANGED_DATE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? ACCOMPLICE { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? AUDITOR { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? DEPENDS_ON { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ONLY_ROOT_TASKS { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int>? STAGE_ID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int>? UF_CRM_TASK { get; set; }
    }
}
