namespace BXRest.Core.Models
{
    /// <summary>
    /// Список все доступных методов
    /// </summary>
    public static class RestMedots
    {
        public static string Batch = "batch";
        public static class User
        {
            private static string Base = "user.";

            public static string Admin = Base + "admin";
            public static string Get = Base + "get";
            public static string Current = Base + "current";
            public static string Update = Base + "update";
            public static string Search = Base + "search";
            public static string Access = Base + "access";
            // U1 - пользователь с id =1
            // AU - все авторизованные пользователи
            // D1 - подразделение с id=1
            // G1 - группа с id=1
            public static string fields = Base + "fields";
            public static class Userfield
            {
                private static string Base = "user.userfield";

                public static string list = "list";
            }
        }
        public static class Crm
        {
            private static string Base = "crm.";
            public static string StageHistory = Base + "stagehistory";
            public static string Status = Base + "status";
            public static string Type = Base + "type";
            public static string PaySystem = Base + "paysystem";
            public static string Invoice = Base + "invoice";
            public static string Product = Base + "product";
            public static string ProductSection = Base + "productsection";
            public static string CompanyBase = Base + "company";
            public static string DealBase = Base + "deal";
            public static string Lead = Base + "lead";
            public static string Item = Base + "item";
            public static string RequisiteBase = Base + "requisite";


            public static class Contact
            {
                private static string Base = "crm.contact.";

                public static string Add = Base + "add"; // Создаёт новый контакт
                public static string Delete = Base + "Delete"; // Удаляет контакт и все связанные с ним объекты
                public static string Fields = Base + "fields"; // Возвращает описание полей контакта
                public static string Get = Base + "get"; // Возвращает контакт по идентификатору
                public static string List = Base + "list"; // Возвращает список контактов по фильтру
                public static string Update = Base + "update"; // Обновляет существующий контакт

                public static class Company
                {
                    private static string Base = "crm.contact.company.";

                    public static string Add = Base + "add"; // Добавляет компанию к указанному контакту
                    public static string Delete = Base + "delete"; // Удаляет компанию из указанного контакта
                    public static string Fields = Base + "fields"; // Возвращает описание полей для связи контакт-компания

                    public static class Items
                    {
                        private static string Base = "crm.contact.company.item.";

                        public static string Delete = Base + "delete"; // Очищает набор компаний, связанных с указанным контактом
                        public static string Get = Base + "get"; // Возвращает набор компаний, связанных с указанным контактом
                        public static string Set = Base + "set"; // Устанавливает набор компаний, связанных с указанным контактом
                    }

                }

                public static class Userfield
                {
                    private static string Base = "crm.contact.userfield.";

                    public static string Add = Base + "add"; // Создаёт новое пользовательское поле для контактов
                    public static string Get = Base + "get"; //  Возвращает пользовательское поле контактов по идентификатору
                    public static string List = Base + "list"; //  Возвращает список пользовательских полей контактов по фильтру
                    public static string Update = Base + "update"; //  Обновляет существующее пользовательское поле контактов
                    public static string Delete = Base + "delete"; //  Удаляет пользовательское поле контактов
                }
            }

            public static class Deal
            {
                private static string Base = "crm.deal.";

                public static string Productrows = Base + "productrows";
                public static string Сontact = Base + "contact";
                public static string Userfield = Base + "userfield";
                public static class Contact
                {
                    public static string Items = "crm.deal.contact.items";
                }
            }

            public static class Company
            {

                private static string Base = "crm.company.";

                public static string Contact = Base + "contact";
                public static string ContactItems = Base + "contact.items";

            }

            public static class Requisite
            {
                private static string Base = "crm.requisite.";

                public static string Link = Base + "link";
                public static string Bankdetail = Base + "bankdetail";
                public static string PresetField = Base + "preset.field";
                public static string Preset = Base + "preset";
            }

            public static class Timeline
            {
                public static string Comment = "crm.timeline.comment";
            }

            public static string ItemProduct = Base + "item.productrow";

        }

        public static class Task
        {
            private static string Base = "task.";
            public static class ElapsedItem
            {
                private static string Base = "task.elapseditem.";
                public static string GetManIFest = Base + "getmanifest"; // Возвращает список методов и их описание
                public static string GetList = Base + "getlist"; // Возвращает список записей о затраченном времени по задаче
                public static string Get = Base + "get"; // Возвращает запись о затраченном времени по ее идентификатору
                public static string Add = Base + "add"; // Добавляет затраченное время к задаче
                public static string Delete = Base + "delete"; // Удаляет запись о затраченном времени
                public static string IsactionAllowed = Base + "isactionallowed"; // Проверяет разрешено ли действие
                public static string Update = Base + "update"; //  Изменяет параметры записи о затраченном времени
            }

            public static class Item
            {
                private static string Base = "task.item.";
                public static class Userfield
                {
                    private static string Base = "task.item.userfield.";

                    public static string GetFields = Base + "getfields"; // Получение всех доступных полей свойства
                    public static string GetTypes = Base + "gettypes"; // Получение всех доступных типов данных
                    public static string Add = Base + "add"; // Создание нового свойства
                    public static string Get = Base + "get"; // Получение свойства по идентификатору
                    public static string GetList = Base + "getlist"; // Получение списка свойств
                    public static string Update = Base + "update"; // Редактирование параметров свойства
                    public static string Delete = Base + "delete"; // Удаление свойства
                }
             
     
            }
        }

        public static class Tasks
        {
            public static class Task
            {
                private static string Base = "tasks.task.";

                /// <summary>
                /// Создает задачу.
                /// </summary>
                public static string Add = Base + "add";
                public static string Approve = Base + "approve"; // Позволяет принять задачу
                public static string Complete = Base + "complete"; // Переводит задачу в статус «завершена»

                public static class Counters
                {
                    public static string Get = Base + "counters.get"; // Получает счетчики пользователя
                }

                public static string Deger = Base + "deger"; // Переводит задачу в статус «отложена»
                public static string Delegate = Base + "delegate"; // Метод для делегирования задачи
                public static string Delete = Base + "delete"; //Удаляет задачу
                public static string Disapprove = Base + "disapprove"; // Позволяет отклонить задачу

                public static class Favorite
                {
                    private static string Base = "tasks.task.favorite";
                    public static string Add = Base + "add"; // Добавляет задачи в "Избранное"
                    public static string Remove = Base + "remove"; // Удаляет задачи из "Избранного"

                }

                public static class Files
                {
                    private static string Base = "tasks.task.favorite";
                    public static string Add = Base + "add"; // Добавляет задачи в "Избранное"
                    public static string Remove = Base + "remove"; // Удаляет задачи из "Избранного"
                    public static string Attach = Base + "attach"; // Прикрепляет загруженный на диск файл к задаче
                }

                public static string Get = Base + "get"; // Возвращает информацию о конкретной задаче
                public static string GetFields = Base + "getFields"; // Возвращает все доступные поля
                public static string Aetaccess = Base + "Aetaccess"; //  Метод для проверки доступа к задаче

                public static class History
                {
                    public static string List = "tasks.task.history.list"; // Получает историю задачи
                }
                public static string List = Base + "list"; // Возвращает массив задач, каждая из которых содержит массив полей
                public static string Pause = Base + "pause"; // Останавливает выполнение задачи, переводя ее в статус "ждет выполнения"
                public static string Renew = Base + "renew"; // Возобновляет задачу после ее завершения
                public static string Start = Base + "start"; // Переводит задачу в статус «выполняется»
                public static string Startwatch = Base + "startwatch"; // Позволяет наблюдать за задачей
                public static string Stopwatch = Base + "stopwatch"; // Останавливает наблюдение за задачей
                public static string Update = Base + "update"; // Обновляет задачу
            }
        }


        public static class SonetGroup
        {
            private static string Base = "sonet_group.";

            public static string Create = Base + "create"; // Создает группу соцсети, используя метод API CSocNetGroup::CreateGroup(), указывая владельцем группы текущего пользователя
            public static string Delete = Base + "delete"; // Удаляет группу соцсети

            public static class Feature
            {
                private static string Base = "sonet_group.feature.";
                public static string Access = Base + "access"; // Проверяет, имеет ли текущий пользователь право на совершение операции в группе соцсети, осуществляя вызов функции CSocNetFeaturesPerms::CurrentUserCanPerformOperation()
            }

            public static string Get = Base + "get"; //  Возвращает массив групп соцсети, каждая из которых содержит массив полей, осуществляя вызов CSocNetGroup::GetList(), при этом возвращаются только те группы, которые доступны пользователю по правам
            public static string Setowner = Base + "setowner"; // Изменяет владельца группы
            public static string Update = Base + "setowner"; // Изменяет параметры группы соцсети, используя метод API CSocNetGroup::Update()

            public static class User
            {
                private static string Base = "sonet_group.user.";

                public static string Add = Base + "add"; // Добавляет пользователей в качестве участников рабочей группы (без приглашения и подтверждения)
                public static string Delete = Base + "delete"; // Удаляет пользователей из рабочей группы.
                public static string Get = Base + "get"; // Возвращает массив участников группы соцсети, осуществляя вызов CSocNetUserToGroup::GetList(), при этом проверяются права на доступ текущего пользователя к группе
                public static string Groups = Base + "groups"; // Возвращает массив групп соцсети текущего пользователя, осуществляя вызов CSocNetUserToGroup::GetList()
                public static string Invite = Base + "invite"; // Выполняет приглашение пользователей в группу соцсети от лица текущего пользователя, при этом проверяются права на доступ текущего пользователя к группе
                public static string Request = Base + "request"; // тправляет запрос текущего пользователя на вступление в группу соцсети, при этом проверяются права на доступ текущего пользователя к группе
                public static string Update = Base + "update"; // Изменяет роль пользователей в рабочей группе
            }
        }
    }
}
