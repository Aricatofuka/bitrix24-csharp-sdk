using System;

namespace BXRest.Models.Tasks.Task
{
    public class iAdd
    {
        /// <summary>
        /// Идентификатор задачи
        /// </summary>
        public int? ID { get; set; }

        /// <summary>
        /// ID родительской задачи  По умолчанию - 0
        /// </summary>
        public int? PARENTID { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string TITLE { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string DESCRIPTION { get; set; }

        /// <summary>
        /// Оценка  N - Отрицательная, P - Положительная. По умолчанию - null
        /// </summary>
        public char? MARK { get; set; }

        /// <summary>
        /// Приоритет   2 - Высокий,  1 - Средний,  0 - Низкий.  По умолчанию - 1
        /// </summary>
        public int? PRIORITY { get; set; }

        /// <summary>
        /// Статус  enum    2 - Ждет выполнения,  3 - Выполняется, 4 - Ожидает контроля, 5 - Завершена, 6 - Отложена. По умолчанию - 2
        /// </summary>
        public int? STATUS { get; set; }

        /// <summary>
        /// Множественная задача. По умолчанию - Нет
        /// </summary>
        public iBXRestYesNo MULTITASK { get; set; }

        /// <summary>
        /// По умолчанию - Нет
        /// </summary>
        public iBXRestYesNo NOTVIEWED { get; set; }

        /// <summary>
        /// Повторяемая задача. По умолчанию - Нет
        /// </summary>
        public iBXRestYesNo REPLICATE { get; set; }

        /// <summary>
        /// Проект. По умолчанию - 0
        /// </summary>
        public int? GROUPID { get; set; }

        /// <summary>
        /// Стадия. По умолчанию - 0
        /// </summary>
        public int? STAGEID { get; set; }

        /// <summary>
        /// Постановщик, если оставить парамер пустым, им будет тот кто отправил запрос
        /// </summary>
        public int? CREATEDBY { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime? CREATEDDATE { get; set; }

        /// <summary>
        /// Исполнитель
        /// </summary>
        public int RESPONSIBLEID { get; set; }

        /// <summary>
        /// Соисполнители
        /// </summary>
        public int[] ACCOMPLICES { get; set; }

        /// <summary>
        /// Наблюдатели
        /// </summary>
        public int[] AUDITORS { get; set; }

        /// <summary>
        /// Кто зменил
        /// </summary>
        public int? CHANGEDBY { get; set; }

        /// <summary>
        /// Дата изменения
        /// </summary>
        public DateTime? CHANGEDDATE { get; set; }

        /// <summary>
        /// Изменил статус
        /// </summary>
        public int? STATUSCHANGEDBY { get; set; }

        /// <summary>
        /// Закрыл задачу
        /// </summary>
        public int? CLOSEDBY { get; set; }

        /// <summary>
        /// Дата закрытия
        /// </summary>
        public DateTime? CLOSEDDATE { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime? DATESTART { get; set; }

        /// <summary>
        /// Крайний срок
        /// </summary>
        public DateTime? DEADLINE { get; set; }

        /// <summary>
        /// Плановое начало
        /// </summary>
        public DateTime? STARTDATEPLAN { get; set; }

        /// <summary>
        /// Плановое завершение
        /// </summary>
        public DateTime? ENDDATEPLAN { get; set; }

        /// <summary>
        /// GUID
        /// </summary>
        public string GUID { get; set; }

        /// <summary>
        /// XMLID
        /// </summary>
        public string XMLID { get; set; }

        /// <summary>
        /// Кол-во комментариев
        /// </summary>
        public string COMMENTSCOUNT { get; set; }

        /// <summary>
        /// Кол-во новых комментариев
        /// </summary>
        public string NEWCOMMENTSCOUNT { get; set; }

        /// <summary>
        /// Разрешить менять сроки. По умолчанию - Нет
        /// </summary>
        public iBXRestYesNo ALLOWCHANGEDEADLINE { get; set; }

        /// <summary>
        /// Принять работу По умолчанию - Нет
        /// </summary>
        public iBXRestYesNo TASKCONTROL { get; set; }

        /// <summary>
        /// Добавить в отчёт. По умолчанию - Нет
        /// </summary>
        public iBXRestYesNo ADDINREPORT { get; set; }

        /// <summary>
        /// Создано из шаблона. По умолчанию - Нет
        /// </summary>
        public iBXRestYesNo FORKEDBYTEMPLATEID { get; set; }

        /// <summary>
        /// Затраченое время
        /// </summary>
        public int? TIMEESTIMATE { get; set; }

        /// <summary>
        /// Затраченое время из истории изменений
        /// </summary>
        public int? TIMESPENTINLOGS { get; set; }

        /// <summary>
        /// Пропустить выходные дни
        /// </summary>
        public int? MATCHWORKTIME { get; set; }

        /// <summary>
        /// Идентификатор темы форума
        /// </summary>
        public int? FORUMTOPICID { get; set; }

        /// <summary>
        /// Идентификатор форума
        /// </summary>
        public int? FORUMID { get; set; }

        /// <summary>
        /// Идентификатор сайта
        /// </summary>
        public string SITEID { get; set; }

        /// <summary>
        /// Задача подчиненного. По умолчанию - Нет
        /// </summary>
        public iBXRestYesNo SUBORDINATE { get; set; }

        /// <summary>
        /// Добавлен в Избранное. По умолчанию - Нет
        /// </summary>
        public iBXRestYesNo FAVORITE { get; set; }
        public DateTime? EXCHANGEMODIFIED { get; set; }
        public int? EXCHANGEID { get; set; }
        public int? OUTLOOKVERSION { get; set; }

        /// <summary>
        /// Дата последнего просмотра
        /// </summary>
        public DateTime? VIEWEDDATE { get; set; }

        /// <summary>
        ///  Индекс сортировки
        /// </summary>
        public int? SORTING { get; set; }

        /// <summary>
        /// Затрачено (план)
        /// </summary>
        public int? DURATIONPLAN { get; set; }

        /// <summary>
        /// Затрачено (фактически)
        /// </summary>
        public int? DURATIONFACT { get; set; }

        /// <summary>
        /// Чеклист ???
        /// </summary>
        public dynamic[] CHECKLIST { get; set; }

        /// <summary>
        /// DURATIONTYPE     По умолчанию - 3
        /// </summary>
        public int? DURATIONTYPE { get; set; }

        /// <summary>
        ///  Привязка к элементам CRM LXX - lead, CXX - contact,DXX - deal
        /// </summary>
        public string UFCRMTASK { get; set; }

        /// <summary>
        /// Файл (Диск) diskfile
        /// </summary>
        public string[] UFTASKWEBDAVFILES { get; set; }

        public object UFMAILMESSAGE { get; set; }
        public iBXRestYesNo ISMUTED { get; set; }
        public iBXRestYesNo ISPINNED { get; set; }
        public iBXRestYesNo ISPINNEDINGROUP { get; set; }
        public int SERVICECOMMENTSCOUNT { get; set; }
    }

    public enum iBXRestYesNo
    {
        Yes,
        No
    }
}
