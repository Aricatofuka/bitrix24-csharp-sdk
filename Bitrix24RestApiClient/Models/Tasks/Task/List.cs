using BXRest.Converter;
#nullable enable
using Newtonsoft.Json;
using static BXRest.Api.Models.Base;
using static BXRest.Models.Parameter.Request.Filter;
using System.Collections.Generic;

namespace BXRest.Models.Tasks.Task
{

    /// Класс для параметров метода tasks.task.list (список задач)
    public class iList : iBXRestBaseParam
    {
        /// Сортировка списка задач
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public iListOrder? order { get; set; }

        /// Фильтрация списка задач
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FilterWithSpecialCharacter<iListFilter>))]
        public iBXFilterValue<iListFilter> filter { get; set; }


        /// Выбираемые поля задач
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<iBXRestTaskFieldsName>? select { get; set; }
    }

    /// Так выглядит ответ на запрос на список задач/задачи
    public class iListResult
    {
        /// Список задач
        public List<iTask> tasks { get; set; } = [];
    }

    /// Фильтр сортировки
    public class iListOrder
    {
        /// Сортировать по идентификатору задачи
        public iBXRestOrder? ID { get; set; }

        /// Сортировать по заголовку задачи
        public iBXRestOrder? TITLE { get; set; }

        /// Сортировать по затраченному времени на задачу (в логах)
        public iBXRestOrder? TIME_SPENT_IN_LOGS { get; set; }

        /// Сортировать по дате начала задачи
        public iBXRestOrder? DATE_START { get; set; }

        /// Сортировать по дате создания задачи
        public iBXRestOrder? CREATED_DATE { get; set; }

        /// Сортировать по дате последнего изменения задачи
        public iBXRestOrder? CHANGED_DATE { get; set; }

        /// Сортировать по дате закрытия задачи
        public iBXRestOrder? CLOSED_DATE { get; set; }

        /// Сортировать по плановой дате начала задачи
        public iBXRestOrder? START_DATE_PLAN { get; set; }

        /// Сортировать по плановой дате завершения задачи
        public iBXRestOrder? END_DATE_PLAN { get; set; }

        /// Сортировать по крайнему сроку выполнения задачи
        public iBXRestOrder? DEADLINE { get; set; }

        /// Сортировать по реальному статусу задачи
        public iBXRestOrder? REAL_STATUS { get; set; }

        /// Сортировать по завершённости задачи
        public iBXRestOrder? STATUS_COMPLETE { get; set; }

        /// Сортировать по приоритету задачи
        public iBXRestOrder? PRIORITY { get; set; }

        /// Сортировать по метке задачи
        public iBXRestOrder? MARK { get; set; }

        /// Сортировать по фамилии создателя задачи
        public iBXRestOrder? CREATED_BY_LAST_NAME { get; set; }

        /// Сортировать по фамилии ответственного за задачу
        public iBXRestOrder? RESPONSIBLE_LAST_NAME { get; set; }

        /// Сортировать по идентификатору группы задач        public iBXRestOrder? GROUP_ID { get; set; }

        /// Сортировать по планируемому времени выполнения задачи        public iBXRestOrder? TIME_ESTIMATE { get; set; }

        /// Сортировать по возможности изменения крайнего срока задачи        public iBXRestOrder? ALLOW_CHANGE_DEADLINE { get; set; }

        /// Сортировать по возможности отслеживания времени выполнения задачи        public iBXRestOrder? ALLOW_TIME_TRACKING { get; set; }

        /// Сортировать по флагу "Оценка времени"
        public iBXRestOrder? MATCH_WORK_TIME { get; set; }

        /// Сортировать по флагу "Избранное"
        public iBXRestOrder? FAVORITE { get; set; }

        /// Сортировать по полю для сортировки
        public iBXRestOrder? SORTING { get; set; }

        /// Сортировать по идентификатору сообщения (внешний идентификатор)
        public iBXRestOrder? MESSAGE_ID { get; set; }
    }

    /// Все доступные свойства фильтра
    public class iListFilter
    {

        /// Идентификатор задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<uint>? ID { get; set; }

        /// Дата активности задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ACTIVITY_DATE { get; set; }

        /// Родительская задача
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? PARENT_ID { get; set; }

        /// Идентификатор группы задач
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? GROUP_ID { get; set; }

        /// Создатель задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? CREATED_BY { get; set; }

        /// Автор изменения статуса задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? STATUS_CHANGED_BY { get; set; }

        /// Приоритет задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? PRIORITY { get; set; }

        /// Идентификатор темы форума, связанной с задачей
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? FORUM_TOPIC_ID { get; set; }

        /// Ответственный за задачу
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? RESPONSIBLE_ID { get; set; }


        /// Заголовок задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? TITLE { get; set; }


        /// Тег задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? TAG { get; set; }


        /// Реальный статус задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int>? REAL_STATUS { get; set; }

        /// Статус задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int>? STATUS { get; set; }

        /// Метка задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? MARK { get; set; }

        /// Идентификатор сайта
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SITE_ID { get; set; }

        /// Признак включения задачи в отчет о выполнении работ
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ADD_IN_REPORT { get; set; }

        /// Флаг "Отслеживание времени"
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ALLOW_TIME_TRACKING { get; set; }

        /// Дата начала задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? DATE_START { get; set; }

        /// Крайний срок задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? DEADLINE { get; set; }

        /// Дата создания задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? CREATED_DATE { get; set; }

        /// Дата закрытия задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? CLOSED_DATE { get; set; }

        /// Дата последнего изменения задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? CHANGED_DATE { get; set; }

        /// Соисполнитель задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? ACCOMPLICE { get; set; }

        /// Аудитор задачи
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? AUDITOR { get; set; }

        /// Предшествующая задача
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? DEPENDS_ON { get; set; }

        /// Флаг "Только корневые задачи"
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ONLY_ROOT_TASKS { get; set; }

        /// Идентификаторы стадий
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int>? STAGE_ID { get; set; }

        /// Идентификаторы CRM-сделок
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<int>? UF_CRM_TASK { get; set; }
    }
}
