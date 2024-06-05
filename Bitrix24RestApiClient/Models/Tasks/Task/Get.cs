#nullable enable
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BXRest.Models.Tasks.Task
{
    /// Параметр для получени задачи
    public class iGet
    {
        /// идификатор задачи
        public int taskId { get; set; }

        /// Список полей для выдачи (динамическая выдача полей)
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<iBXRestTaskFieldsName>? select { get; set; }
    }

    /// Название полей
    [JsonConverter(typeof(StringEnumConverter))]
    public enum iBXRestTaskFieldsName
    {
        /// выборка всех полей
        [EnumMember(Value = "*")]
        all,
        /// идентификатор задачи
        ID,
        /// идентификатор родительской задачи
        PARENT_ID,
        /// название задачи
        TITLE,
        /// описание
        DESCRIPTION,
        /// оценка
        MARK,
        /// приоритет: 0 - низкий, 1 - средний, 2 - высокий
        PRIORITY,
        /// статус
        STATUS,
        /// множественная задача
        MULTITASK,
        /// непросмотренная задача
        NOT_VIEWED,
        /// повторяемая задача
        REPLICATE,
        /// рабочая группа.
        GROUP_ID,
        /// стадия
        STAGE_ID,
        /// постановщик
        CREATED_BY,
        /// дата создания
        CREATED_DATE,
        /// исполнитель
        RESPONSIBLE_ID,
        /// идентификатор соисполнителя
        ACCOMPLICES,
        /// идентификатор аудитора
        AUDITORS,
        /// кем изменена задача
        CHANGED_BY,
        /// дата изменения
        CHANGED_DATE,
        /// кто изменил статус
        STATUS_CHANGED_DATE,
        /// кто закрыл задачу
        CLOSED_BY,
        /// дата закрытия задачи
        CLOSED_DATE,
        /// дата начала
        DATE_START,
        /// крайний срок
        DEADLINE,
        /// плановое начало
        START_DATE_PLAN,
        /// плановое завершение
        END_DATE_PLAN,
        /// GUID (статистически уникальный 128-битный идентификатор)
        GUID,
        /// внешний код
        XML_ID,
        /// количество комментариев
        COMMENTS_COUNT,
        /// количество новых комментариев
        NEW_COMMENTS_COUNT,
        /// принять в работу
        TASK_CONTROL,
        /// добавить в отчет
        ADD_IN_REPORT,
        /// создано из шаблона
        FORKED_BY_TEMPLATE_ID,
        /// затраченное время
        TIME_ESTIMATE,
        /// затраченное время из истории изменений
        TIME_SPENT_IN_LOGS,
        /// пропустить выходные дни
        MATCH_WORK_TIME,
        /// идентификатор темы форума
        FORUM_TOPIC_ID,
        /// идентификатор форума
        FORUM_ID,
        /// идентификатор сайта
        SITE_ID,
        /// задача подчиненного
        SUBORDINATE,
        /// Избранное
        FAVORITE,
        /// дата последнего просмотра
        VIEWED_DATE,
        /// индекс сортировки
        SORTING,
        /// затрачено (план)
        DURATION_PLAN,
        /// затрачено (фактически)
        DURATION_FACT,
        /// тип единицы измерения в планируемой длительности: days, hours или minutes
        DURATION_TYPE, 
        /// Дата активности
        ACTIVITY_DATE,
        /// Теги
        TAGS,
        /// разрешён трек времени
        ALLOW_TIME_TRACKING,
        /// сложность
        UF_AUTO_957927659722, 
    }

    /// Так задачи в Result пихаються
    public class iGetResult
    {
        /// Так задачи в Result пихаються
        public iTask task { get; set; }
        
    }
}
