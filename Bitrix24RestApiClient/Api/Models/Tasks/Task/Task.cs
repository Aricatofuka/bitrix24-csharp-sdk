using BXRest.Converter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BXRest.Api.Models.Tasks.Task
{
    public class iTask
    {
        /// <summary>
        /// id
        /// Тип: string
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// Родительский ID
        /// Тип: string
        /// </summary>
        public int? parentId { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }

        /// <summary>
        /// Приоритет
        /// Тип: string
        /// </summary>
        public int? priority { get; set; }
        public string? mark { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool? notViewed { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool? replicate { get; set; }
        public string? guid { get; set; }
        public string? xmlId { get; set; }
        public string? commentsCount { get; set; }
        public string? taskControl { get; set; }
        public string? addInReport { get; set; }
        public string? forkedByTemplateId { get; set; }
        public string? timeEstimate { get; set; }
        public string? timeSpentInLogs { get; set; }
        public string? matchWorkTime { get; set; }
        public string? siteId { get; set; }
        public string? subordinate { get; set; }
        public string? favorite { get; set; }
        public string? exchangeModified { get; set; }
        public string? exchangeId { get; set; }
        public string? outlookVersion { get; set; }
        public string? durationFact { get; set; }
        public string? durationType { get; set; }
        public List<int>? ufCrmTask { get; set; }
        public List<int>? ufTaskWebdavFiles { get; set; }
        public string? ufMailMessage { get; set; }
        public List<int>? auditors { get; set; }
        public int? newCommentsCount { get; set; }
        public List<string>? tags { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public int? status { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool? multitask { get; set; }
        public int? groupId { get; set; }
        public int? stageId { get; set; }
        public int? createdBy { get; set; }
        public DateTime? createdDate { get; set; }
        public int? responsibleId { get; set; }
        public int? changedBy { get; set; }
        public DateTime? changedDate { get; set; }
        public int? statusChangedBy { get; set; }
        public DateTime? statusChangedDate { get; set; }
        public int? closedBy { get; set; }
        public DateTime? closedDate { get; set; }
        public DateTime? dateStart { get; set; }
        public DateTime? deadline { get; set; }
        public DateTime? startDatePlan { get; set; }
        public DateTime? endDatePlan { get; set; }
        public int? forumTopicId { get; set; }
        public int? forumId { get; set; }
        public DateTime? viewedDate { get; set; }
        public float? sorting { get; set; }
        public int? durationPlan { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool? descriptionInBbcode { get; set; }
        public List<int>? accomplices { get; set; }
        public List<int>? checklist { get; set; }
        public int? subStatus { get; set; }
        public iPeople creator { get; set; }
        public iPeople responsible { get; set; }
        public List<iPeople> accomplicesData { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool? allowTimeTracking { get; set; }
        public iTaskGroup? group { get; set; }
        public Dictionary<string, iPeople> auditorsData { get; set; }

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
