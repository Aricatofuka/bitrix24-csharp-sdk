using BXRest.Converter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BXRest.Models.Tasks.Task
{
    public class iTask
    {
        /// <summary>
        /// id
        /// Тип: string
        /// </summary>
        public int? id { get; set; } = null;

        
        /// <summary>
        /// Родительский ID
        /// Тип: string
        /// </summary>
        public int? parentId { get; set; } = null;
        public string? title { get; set; } = null;
        public string? description { get; set; } = null;
        /// <summary>
        /// Приоритет
        /// Тип: string
        /// </summary>
        public int? priority { get; set; } = null;
        public string? mark { get; set; } = null;

        [JsonConverter(typeof(YesNoBX))]
        public bool? notViewed { get; set; } = null;

        [JsonConverter(typeof(YesNoBX))]
        public bool? replicate { get; set; } = null;
        public string? guid { get; set; } = null;
        public string? xmlId { get; set; } = null;
        public string? commentsCount { get; set; } = null;
        public string? taskControl { get; set; } = null;
        public string? addInReport { get; set; } = null;
        public string? forkedByTemplateId { get; set; } = null;
        public double? timeEstimate { get; set; } = null;
        public string? timeSpentInLogs { get; set; } = null;
        public string? matchWorkTime { get; set; } = null;
        public string? siteId { get; set; } = null;
        public string? subordinate { get; set; } = null;
        public string? favorite { get; set; } = null;
        public string? exchangeModified { get; set; } = null;
        public string? exchangeId { get; set; } = null;
        public string? outlookVersion { get; set; } = null;
        public string? durationFact { get; set; } = null;
        public string? durationType { get; set; } = null;
        public bool? ufCrmTask { get; set; }
        // public List<int>? ufTaskWebdavFiles { get; set; } может быть как  List<int> так и bool, поэтому пока что исключено
        public List<int>? auditors { get; set; } = null;
        public int? newCommentsCount { get; set; } = null;
        public List<string>? tags { get; set; } = null;

        /// <summary>
        /// Статус
        /// </summary>
        public int? status { get; set; } = null;

        [JsonConverter(typeof(YesNoBX))]
        public bool? multitask { get; set; } = null;
        public int? groupId { get; set; } = null;
        public int? stageId { get; set; } = null;
        public int? createdBy { get; set; } = null;
        public DateTime? createdDate { get; set; } = null;
        public int? responsibleId { get; set; } = null;
        public int? changedBy { get; set; } = null;
        public DateTime? changedDate { get; set; } = null;
        public int? statusChangedBy { get; set; } = null;
        public DateTime? statusChangedDate { get; set; } = null;
        public int? closedBy { get; set; } = null;
        public DateTime? closedDate { get; set; } = null;
        public DateTime? dateStart { get; set; } = null;
        public DateTime? deadline { get; set; } = null;
      
        public DateTime? startDatePlan { get; set; } = null;
        public DateTime? endDatePlan { get; set; } = null;
        public int? forumTopicId { get; set; } = null;
        public int? forumId { get; set; } = null;
        public DateTime? viewedDate { get; set; } = null;
        public float? sorting { get; set; } = null;
        public int? durationPlan { get; set; } = null;
     
        [JsonConverter(typeof(YesNoBX))]
        public bool? descriptionInBbcode { get; set; } = null;
        public List<int>? accomplices { get; set; } = null;
        public List<int>? checklist { get; set; } = null;
        public int? subStatus { get; set; } = null;
        public iPeople? creator { get; set; } = null;
        public iPeople? responsible { get; set; } = null;
        public string? ufAuto957927659722 { get; set; } // сложность
            /* TODO: разобраться что за херня
        [JsonConverter(typeof(YesNoBX))]
        public bool? allowTimeTracking { get; set; } = null;
        public iTaskGroup? group { get; set; } = null;

        [JsonConverter(typeof(DictionaryButArrayIfNull<int, iPeople>))]
        public Dictionary<int, iPeople>? accomplicesData { get; set; }

        [JsonConverter(typeof(DictionaryButArrayIfNull<int, iPeople>))]
        public Dictionary<int, iPeople>? auditorsData { get; set; }
        */
        // action
    }

     public class iTaskGroup
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool opened { get; set; }
        public int membersCount { get; set; }
        public string image { get; set; }
        public List<int?> additionalData { get; set; }
     }

    public class iTaskAction
    {
        public bool accept { get; set; }
        public bool decline { get; set; }
        public bool complete { get; set; }
        public bool approve { get; set; }
        public bool disapprove { get; set; }
        public bool start { get; set; }
        public bool pause { get; set; }
        public bool @delegate { get; set; }
        public bool remove { get; set; }
        public bool edit{ get; set; }
        public bool defer{ get; set; }
        public bool renew{ get; set; }
        public bool create{ get; set; }
        public bool changeDeadline{ get; set; }
        public bool checklistAddItems{ get; set; }
        public bool addFavorite{ get; set; }
        public bool deleteFavorite{ get; set; }
        public bool rate{ get; set; }

        //  public bool ["edit.originator"] { get; set; }
        //  public bool checklist.reorder{ get; set; }
        //  public bool elapsedtime.add{ get; set; }
        //  public bool dayplan.timer.toggle{ get; set; }
        //  public bool edit.plan{ get; set; }
        // public bool checklist.add{ get; set; }
        //  public bool favorite.add{ get; set; }
        //  public bool favorite.delete { get; set; }
    }

}
