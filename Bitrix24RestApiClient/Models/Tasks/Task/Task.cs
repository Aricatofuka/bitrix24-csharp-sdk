using BXRest.Converter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BXRest.Models.Tasks.Task
{
    /// Данные о задаче, так как апи необходимо передавать название отдаваемых полей, каждое из них ниже помеченно как возможный null 
    public class iTask
    {
        /// id
        public uint? id { get; set; } = null;

        /// Родительский ID
        public int? parentId { get; set; } = null;

        /// Заголовок
        public string? title { get; set; } = null;

        /// Описание
        public string? description { get; set; } = null;

        /// Приоритет
        public int? priority { get; set; } = null;

        /// Метка задачи
        public string? mark { get; set; } = null;

        /// Флаг "Не просмотрено"
        [JsonConverter(typeof(YesNoBX))]
        public bool? notViewed { get; set; } = null;

        /// Флаг "Дублирование"
        [JsonConverter(typeof(YesNoBX))]
        public bool? replicate { get; set; } = null;

        /// Идентификатор задачи для обмена
        public string? guid { get; set; } = null;

        /// Внешний (XML) идентификатор задачи
        public string? xmlId { get; set; } = null;

        /// Количество комментариев
        public string? commentsCount { get; set; } = null;

        /// Контроль задачи
        public string? taskControl { get; set; } = null;

        /// Признак включения задачи в отчет о выполнении работ
        public string? addInReport { get; set; } = null;

        /// ID задачи-шаблона
        public string? forkedByTemplateId { get; set; } = null;

        /// Предполагаемое время выполнения задачи (в часах)
        public double? timeEstimate { get; set; } = null;

        /// Затраченное время (в секундах)
        public string? timeSpentInLogs { get; set; } = null;

        /// Флаг "Оценка времени"
        public string? matchWorkTime { get; set; } = null;

        /// Идентификатор сайта
        public string? siteId { get; set; } = null;

        /// Флаг "Подчиненная задача"
        public string? subordinate { get; set; } = null;

        /// Флаг "Избранное"
        public string? favorite { get; set; } = null;

        /// Дата изменения в обменном формате
        public string? exchangeModified { get; set; } = null;

        /// Идентификатор задачи во внешней системе
        public string? exchangeId { get; set; } = null;

        /// Версия Outlook, в которой создана задача
        public string? outlookVersion { get; set; } = null;
        
        /// Фактически затраченное время (в секундах)
        public string? durationFact { get; set; } = null;

        /// Тип предполагаемого времени выполнения задачи
        public string? durationType { get; set; } = null;
        // public bool? ufCrmTask { get; set; } может быть как List<string> так и bool, поэтому пока что исключено
        // public List<int>? ufTaskWebdavFiles { get; set; } может быть как  List<int> так и bool, поэтому пока что исключено
        public List<int>? auditors { get; set; } = null;
        public int? newCommentsCount { get; set; } = null;
        public List<string>? tags { get; set; } = null;

        /// Статус задачи
        public int? status { get; set; } = null;

        [JsonConverter(typeof(YesNoBX))]
        public bool? multitask { get; set; } = null;

        /// ID группы задач
        public int? groupId { get; set; } = null;

        /// ID этапа задачи
        public int? stageId { get; set; } = null;

        /// ID создателя
        public int? createdBy { get; set; } = null;

        /// Дата создания задачи
        public DateTime? createdDate { get; set; } = null;

        /// ID ответственного за задачу
        public int? responsibleId { get; set; } = null;

        /// ID автора последнего изменения
        public int? changedBy { get; set; } = null;

        /// Дата последнего изменения задачи
        public DateTime? changedDate { get; set; } = null;

        /// ID автора изменения статуса
        public int? statusChangedBy { get; set; } = null;

        /// Дата изменения статуса задачи
        public DateTime? statusChangedDate { get; set; } = null;

        /// ID закрывшего задачу
        public int? closedBy { get; set; } = null;

        /// Дата завершения задачи
        public DateTime? closedDate { get; set; } = null;

        /// Предполагаемая дата начала выполнения задачи
        public DateTime? dateStart { get; set; } = null;

        /// Крайний срок выполнения задачи
        public DateTime? deadline { get; set; } = null;

        /// Плановая дата начала выполнения задачи
        public DateTime? startDatePlan { get; set; } = null;

        /// Плановая дата завершения выполнения задачи
        public DateTime? endDatePlan { get; set; } = null;

        /// ID темы форума, связанной с задачей
        public int? forumTopicId { get; set; } = null;

        /// ID форума, связанного с задачей
        public int? forumId { get; set; } = null;

        /// Дата просмотра задачи пользователем
        public DateTime? viewedDate { get; set; } = null;

        /// Поле для сортировки
        public float? sorting { get; set; } = null;

        /// Предполагаемая длительность выполнения задачи (в часах)
        public int? durationPlan { get; set; } = null;

        /// Флаг "Описание задачи в BBCode"
        [JsonConverter(typeof(YesNoBX))]
        public bool? descriptionInBbcode { get; set; } = null;

        /// Список дополнительных исполнителей
        public List<int>? accomplices { get; set; } = null;
        
        /// Список пунктов чек-листа
        public List<int>? checklist { get; set; } = null;

        /// Подстатус
        public int? subStatus { get; set; } = null;

        /// Сведения о создателе задачи
        public iPeople? creator { get; set; } = null;

        /// Сведения о ответственном за задачу
        public iPeople? responsible { get; set; } = null;

        /// Кастомное поле сложность, в теории может быть удалено с битрикса в любой момент
        public string? ufAuto957927659722 { get; set; }

        /// группа
        [JsonConverter(typeof(ObjectOrDef<iTaskGroup>))]
        public iTaskGroup? group { get; set; }
 
        /// можно ли трекать эту задачу
        [JsonConverter(typeof(YesNoBX))]
        public bool? allowTimeTracking { get; set; } = null;
        /* TODO: разобраться что за херня
        [JsonConverter(typeof(DictionaryButArrayIfNull<int, iPeople>))]
        public Dictionary<int, iPeople>? accomplicesData { get; set; }

        [JsonConverter(typeof(DictionaryButArrayIfNull<int, iPeople>))]
        public Dictionary<int, iPeople>? auditorsData { get; set; }
        */

        /// наше костомное поле указывающее сеньёрити задачи
        public uint? ufList1 { get; set; } = null;

        /// наше костомное поле указывающее дисцеплину
        public uint? ufListDiscipline { get; set; } = null;

        /// наше костомное поле указывающее саб. дисцеплину
        public uint? ufUfListSubdiscipline { get; set; } = null;

    }

    /// Базавые данные о группе к которой относиться задача, отдаваеться в месте с задачей, полные данные имют иное представление
    public class iTaskGroup
    {
        /// уникальный индификатор
        public int id { get; set; }

        /// Имя группы
        public string name { get; set; }

        /// Открытая ли эта группа
        public bool opened { get; set; }

        /// Колличество человек
        public int membersCount { get; set; }

        /// Сылка на изображение-аватар
        public string image { get; set; }
        public List<int?> additionalData { get; set; }
     }

    /// Данные о доступных для задачи действиях
    public class iTaskAction
    {
        /// Возможность принимать задачу
        public bool accept { get; set; }

        /// Возможность отклонять задачу
        public bool decline { get; set; }

        /// Возможность завершать задачу
        public bool complete { get; set; }

        /// Возможность одобрять задачу
        public bool approve { get; set; }

        /// Возможность не одобрять задачу
        public bool disapprove { get; set; }

        /// Возможность начать выполнение задачи
        public bool start { get; set; }

        /// Возможность приостановить выполнение задачи
        public bool pause { get; set; }

        /// Возможность делегировать (назначить ответственным) задачу
        public bool @delegate { get; set; }

        /// Возможность удалить задачу
        public bool remove { get; set; }

        /// Возможность редактировать задачу
        public bool edit { get; set; }

        /// Возможность отложить задачу
        public bool defer { get; set; }

        /// Возможность возобновить выполнение задачи
        public bool renew { get; set; }

        /// Возможность создавать задачи
        public bool create { get; set; }

        /// Возможность изменять крайний срок выполнения задачи
        public bool changeDeadline { get; set; }

        /// Возможность добавлять элементы в чек-лист
        public bool checklistAddItems { get; set; }

        /// Возможность добавлять задачу в избранное
        public bool addFavorite { get; set; }

        /// Возможность удалять задачу из избранного
        public bool deleteFavorite { get; set; }

        /// Возможность оценивать задачи
        public bool rate { get; set; }

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
