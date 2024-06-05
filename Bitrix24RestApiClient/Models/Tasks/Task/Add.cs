using System;

namespace BXRest.Models.Tasks.Task
{
    /// Модель добавления задачи
    public class iAdd
    {
        /// Идентификатор задачи
        public int? ID { get; set; }

        /// ID родительской задачи  По умолчанию - 0
        public int? PARENTID { get; set; }

        /// Название
        public string TITLE { get; set; }

        /// Описание
        public string DESCRIPTION { get; set; }

        /// Оценка  N - Отрицательная, P - Положительная. По умолчанию - null
        public char? MARK { get; set; }

        /// Приоритет   2 - Высокий,  1 - Средний,  0 - Низкий.  По умолчанию - 1
        public int? PRIORITY { get; set; }

        /// Статус  enum    2 - Ждет выполнения,  3 - Выполняется, 4 - Ожидает контроля, 5 - Завершена, 6 - Отложена. По умолчанию - 2
        public int? STATUS { get; set; }

        /// Множественная задача. По умолчанию - Нет
        public iBXRestYesNo MULTITASK { get; set; }

        /// По умолчанию - Нет
        public iBXRestYesNo NOTVIEWED { get; set; }

        /// Повторяемая задача. По умолчанию - Нет
        public iBXRestYesNo REPLICATE { get; set; }

        /// Проект. По умолчанию - 0
        public int? GROUPID { get; set; }

        /// Стадия. По умолчанию - 0
        public int? STAGEID { get; set; }

        /// Постановщик, если оставить парамер пустым, им будет тот кто отправил запрос
        public int? CREATEDBY { get; set; }

        /// Дата создания
        public DateTime? CREATEDDATE { get; set; }

        /// Исполнитель
        public int RESPONSIBLEID { get; set; }

        /// Соисполнители
        public int[] ACCOMPLICES { get; set; }

        /// Наблюдатели
        public int[] AUDITORS { get; set; }

        /// Кто зменил
        public int? CHANGEDBY { get; set; }

        /// Дата изменения
        public DateTime? CHANGEDDATE { get; set; }

        /// Изменил статус
        public int? STATUSCHANGEDBY { get; set; }

        /// Закрыл задачу
        public int? CLOSEDBY { get; set; }

        /// Дата закрытия
        public DateTime? CLOSEDDATE { get; set; }

        /// Дата начала
        public DateTime? DATESTART { get; set; }

        /// Крайний срок
        public DateTime? DEADLINE { get; set; }

        /// Плановое начало
        public DateTime? STARTDATEPLAN { get; set; }

        /// Плановое завершение
        public DateTime? ENDDATEPLAN { get; set; }

        /// GUID
        public string GUID { get; set; }

        /// XMLID
        public string XMLID { get; set; }

        /// Кол-во комментариев
        public string COMMENTSCOUNT { get; set; }

        /// Кол-во новых комментариев
        public string NEWCOMMENTSCOUNT { get; set; }

        /// Разрешить менять сроки. По умолчанию - Нет
        public iBXRestYesNo ALLOWCHANGEDEADLINE { get; set; }

        /// Принять работу По умолчанию - Нет
        public iBXRestYesNo TASKCONTROL { get; set; }

        /// Добавить в отчёт. По умолчанию - Нет
        public iBXRestYesNo ADDINREPORT { get; set; }

        /// Создано из шаблона. По умолчанию - Нет
        public iBXRestYesNo FORKEDBYTEMPLATEID { get; set; }

        /// Затраченое время
        public int? TIMEESTIMATE { get; set; }

        /// Затраченое время из истории изменений
        public int? TIMESPENTINLOGS { get; set; }

        /// Пропустить выходные дни
        public int? MATCHWORKTIME { get; set; }

        /// Идентификатор темы форума
        public int? FORUMTOPICID { get; set; }

        /// Идентификатор форума
        public int? FORUMID { get; set; }

        /// Идентификатор сайта
        public string SITEID { get; set; }

        /// Задача подчиненного. По умолчанию - Нет
        public iBXRestYesNo SUBORDINATE { get; set; }

        /// Добавлен в Избранное. По умолчанию - Нет
        public iBXRestYesNo FAVORITE { get; set; }

        /// Дата последнего просмотра
        public DateTime? VIEWEDDATE { get; set; }

        ///  Индекс сортировки
        public int? SORTING { get; set; }

        /// Затрачено (план)
        public int? DURATIONPLAN { get; set; }

        /// Затрачено (фактически)
        public int? DURATIONFACT { get; set; }

        /// Чеклист ???
        public dynamic[] CHECKLIST { get; set; }

        /// DURATIONTYPE     По умолчанию - 3
        public int? DURATIONTYPE { get; set; }

        ///  Привязка к элементам CRM LXX - lead, CXX - contact,DXX - deal
        public string UFCRMTASK { get; set; }

        /// Файл (Диск) diskfile
        public string[] UFTASKWEBDAVFILES { get; set; }
    }

    /// Список ['Да','Нет'] для булевой связи с битрисом
    public enum iBXRestYesNo
    {
        /// Да
        Yes,
        /// Нет
        No
    }
}
