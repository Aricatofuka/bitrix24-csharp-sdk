﻿namespace BXRest.Core.Models
{

    /// Список все доступных методов

    public static class RestMedots
    {
        /// Метод в который можно запухнуть несколько методов
        public static readonly string Batch = "batch";

        /// Ветка методов пользователей
        public static class User
        {
            private static readonly string Base = "user.";

            /// Определение, обладает ли текущий пользователь правами на управление настройками приложений
            public static readonly string Admin = Base + "admin";
            /// Получение фильтрованного списка пользователей
            public static readonly string Get = Base + "get";

            /// Получение информации о текущем пользователе.
            public static readonly string Current = Base + "current";

            /// Обновляет данные пользователя
            public static readonly string Update = Base + "update";

            /// Получение списка пользователей с ускоренным поиском по персональным данным.
            public static readonly string Search = Base + "search";

            /// Определение, обладает ли текущий пользователь хотя бы одним из заданного параметром ACCESS набора прав
            /// U1 - пользователь с id =1
            /// AU - все авторизованные пользователи
            /// D1 - подразделение с id=1
            /// G1 - группа с id=1
            public static readonly string Access = Base + "access";

            /// Получение списка названий полей пользователя
            public static readonly string fields = Base + "fields";

            /// Пространство имён "Пользовательские поля" (user.userfield)
            public static class Userfield
            {

                private static readonly string Base = "user.userfield";

                /// Добавляет пользовательское поле
                public static readonly string add = Base + "add";

                /// Обновляет пользовательское поле
                public static readonly string update = Base + "update";

                /// Удаляет пользовательское поле
                public static readonly string delete = Base + "delete";

                /// Получает список пользовательских полей
                public static readonly string list = Base + "list";

                /// Пространство имён "Файлы пользовательских полей" (user.userfield.file)
                public static class File
                {
                    private static readonly string Base = "user.userfield.file";

                    /// Получает файл из пользовательского поля
                    public static readonly string get = Base + "get";
                }
            }
        }

            /// Пространство имён "Подразделений"
            public static class Department
            {
                private static readonly string Base = "department.";

                /// Создает подразделение
                public static readonly string Add = Base + "add";

                /// Изменяет подразделение
                public static readonly string Update = Base + "update";

                /// Получение фильтрованного списка подразделений
                public static readonly string Get = Base + "get";

                /// Получение фильтрованного списка подразделений
                public static readonly string Fields = Base + "fields";

                /// Получение списка названий полей подразделения.
                public static readonly string Delete = Base + "delete";
            }

            /// Пространство имён "CRM"
            public static class CRM
            {
                private static readonly string Base = "crm.";

                // public static readonly string StageHistory = Base + "stagehistory";
                // public static readonly string Status = Base + "status";
                // public static readonly string Type = Base + "type";
                // public static readonly string PaySystem = Base + "paysystem";
                //  public static readonly string Invoice = Base + "invoice";
                //  public static readonly string Product = Base + "product";
                //  public static readonly string ProductSection = Base + "productsection";
                //  public static readonly string CompanyBase = Base + "company";
                //  public static readonly string DealBase = Base + "deal";
                //  public static readonly string Lead = Base + "lead";
                //  public static readonly string Item = Base + "item";
                //  public static readonly string RequisiteBase = Base + "requisite";

                /// CRM документы
                public static class Contact
                {
                    private static readonly string Base = "crm.contact.";

                    /// Создаёт новый контакт
                    public static readonly string Add = Base + "add";

                    /// Удаляет контакт и все связанные с ним объекты
                    public static readonly string Delete = Base + "Delete";

                    /// Возвращает описание полей контакта
                    public static readonly string Fields = Base + "fields";

                    /// Возвращает контакт по идентификатору
                    public static readonly string Get = Base + "get";

                    /// Возвращает список контактов по фильтру
                    public static readonly string List = Base + "list";

                    /// Обновляет существующий контакт
                    public static readonly string Update = Base + "update";

                    /// Company
                    public static class Company
                    {
                        private static readonly string Base = "crm.contact.company.";

                        /// Добавляет компанию к указанному контакту
                        public static readonly string Add = Base + "add";

                        /// Удаляет компанию из указанного контакта
                        public static readonly string Delete = Base + "delete";

                        /// Возвращает описание полей для связи контакт-компания
                        public static readonly string Fields = Base + "fields";

                        /// Items
                        public static class Items
                        {
                            private static readonly string Base = "crm.contact.company.item.";

                            /// Очищает набор компаний, связанных с указанным контактом
                            public static readonly string Delete = Base + "delete";

                            /// Возвращает набор компаний, связанных с указанным контактом
                            public static readonly string Get = Base + "get";

                            /// Устанавливает набор компаний, связанных с указанным контактом
                            public static readonly string Set = Base + "set";
                        }

                    }

                    /// Userfield
                    public static class Userfield
                    {
                        private static readonly string Base = "crm.contact.userfield.";

                        /// Создаёт новое пользовательское поле для контактов
                        public static readonly string Add = Base + "add";

                        /// Возвращает пользовательское поле контактов по идентификатору
                        public static readonly string Get = Base + "get";

                        ///  Возвращает список пользовательских полей контактов по фильтру
                        public static readonly string List = Base + "list";

                        ///  Обновляет существующее пользовательское поле контактов
                        public static readonly string Update = Base + "update";

                        ///  Удаляет пользовательское поле контактов
                        public static readonly string Delete = Base + "delete";
                    }
                }

                /*
            public static class Deal
            {
                private static readonly string Base = "crm.deal.";

                public static readonly string Productrows = Base + "productrows";
                public static readonly string Сontact = Base + "contact";
                public static readonly string Userfield = Base + "userfield";
                public static class Contact
                {
                    public static readonly string Items = "crm.deal.contact.items";
                }
            }

            public static class Company
            {

                private static string Base = "crm.company.";

                public static readonly string Contact = Base + "contact";
                public static readonly string ContactItems = Base + "contact.items";

            }

            public static class Requisite
            {
                private static string Base = "crm.requisite.";

                public static readonly string Link = Base + "link";
                public static readonly string Bankdetail = Base + "bankdetail";
                public static readonly string PresetField = Base + "preset.field";
                public static readonly string Preset = Base + "preset";
            }

            public static class Timeline
            {
                public static readonly string Comment = "crm.timeline.comment";
            }
                */

                /// Товарные позиции 
                /// https://dev.1c-bitrix.ru/rest_help/crm/productrow/index.php
                public static readonly string ItemProduct = Base + "item.productrow";

            }

            /// Старый но еще использемый раздел задач
            public static class Task
            {
                private static readonly string Base = "task.";

                /// Раздел затраченого времени на задачу
                public static class ElapsedItem
                {
                    private static readonly string Base = "task.elapseditem.";

                    /// Возвращает список методов и их описание
                    public static readonly string GetManIFest = Base + "getmanifest";

                    /// Возвращает список записей о затраченном времени по задаче
                    public static readonly string GetList = Base + "getlist";

                    /// Возвращает запись о затраченном времени по ее идентификатору
                    public static readonly string Get = Base + "get";

                    /// Добавляет затраченное время к задаче
                    public static readonly string Add = Base + "add";

                    /// Удаляет запись о затраченном времени
                    public static readonly string Delete = Base + "delete";

                    /// Проверяет разрешено ли действие
                    public static readonly string IsactionAllowed = Base + "isactionallowed";

                    ///  Изменяет параметры записи о затраченном времени
                    public static readonly string Update = Base + "update";
                }

                /// Старый раздел задач
                public static class Item
                {
                    private static readonly string Base = "task.item.";

                    /// Раздел с пользовательскими полями по задачам
                    public static class Userfield
                    {
                        private static readonly string Base = "task.item.userfield.";

                        /// Получение всех доступных полей свойства
                        public static readonly string GetFields = Base + "getfields";

                        /// Получение всех доступных типов данных
                        public static readonly string GetTypes = Base + "gettypes";

                        /// Создание нового свойства
                        public static readonly string Add = Base + "add";

                        /// Получение свойства по идентификатору
                        public static readonly string Get = Base + "get";

                        /// Получение списка свойств
                        public static readonly string GetList = Base + "getlist";

                        /// Редактирование параметров свойства
                        public static readonly string Update = Base + "update";

                        /// Удаление свойства
                        public static readonly string Delete = Base + "delete";
                    }


                }
            }

            /// Раздел задач, новый судя по всему
            public static class Tasks
            {
                /// Раздел задач
                public static class Task
                {
                    private static readonly string Base = "tasks.task.";

                    /// Создает задачу.
                    public static readonly string Add = Base + "add";

                    /// Позволяет принять задачу
                    public static readonly string Approve = Base + "approve";

                    /// Переводит задачу в статус «завершена»
                    public static readonly string Complete = Base + "complete";

                    /// Раздел счесчиков задачи
                    public static class Counters
                    {
                        /// Получает счетчики пользователя
                        public static readonly string Get = Base + "counters.get";
                    }

                    /// Переводит задачу в статус «отложена»
                    public static readonly string Deger = Base + "deger";

                    /// Метод для делегирования задачи
                    public static readonly string Delegate = Base + "delegate";

                    /// Удаляет задачу
                    public static readonly string Delete = Base + "delete";

                    /// Позволяет отклонить задачу
                    public static readonly string Disapprove = Base + "disapprove";

                    /// Раздел задача помеченных "лайком"
                    public static class Favorite
                    {
                        private static readonly string Base = "tasks.task.favorite";

                        /// Добавляет задачи в "Избранное"
                        public static readonly string Add = Base + "add";

                        /// Удаляет задачи из "Избранного"
                        public static readonly string Remove = Base + "remove";

                    }

                    /// Раздел файлов прикрепленных к задаче
                    public static class Files
                    {
                        private static readonly string Base = "tasks.task.favorite";

                        /// Добавляет задачи в "Избранное"
                        public static readonly string Add = Base + "add";

                        /// Удаляет задачи из "Избранного"
                        public static readonly string Remove = Base + "remove";

                        /// Прикрепляет загруженный на диск файл к задаче
                        public static readonly string Attach = Base + "attach";
                    }

                    /// Возвращает информацию о конкретной задаче
                    public static readonly string Get = Base + "get";

                    /// Возвращает все доступные поля
                    public static readonly string GetFields = Base + "getFields";

                    /// Метод для проверки доступа к задаче
                    public static readonly string Aetaccess = Base + "Aetaccess";

                    /// Раздел истории по по задаче
                    public static class History
                    {
                        /// Получает историю задачи
                        public static readonly string List = "tasks.task.history.list";
                    }

                    /// Возвращает массив задач, каждая из которых содержит массив полей
                    public static readonly string List = Base + "list";

                    /// Останавливает выполнение задачи, переводя ее в статус "ждет выполнения"
                    public static readonly string Pause = Base + "pause";

                    /// Возобновляет задачу после ее завершения
                    public static readonly string Renew = Base + "renew";

                    /// Переводит задачу в статус «выполняется»
                    public static readonly string Start = Base + "start";

                    /// Позволяет наблюдать за задачей
                    public static readonly string Startwatch = Base + "startwatch";

                    /// Останавливает наблюдение за задачей
                    public static readonly string Stopwatch = Base + "stopwatch";


                    /// Обновляет задачу
                    public static readonly string Update = Base + "update";
                }
            }


            /// Пространство имен "Рабочие группы соцсети"
            public static class SonetGroup
            {
                private static readonly string Base = "sonet_group.";


                /// Создает группу соцсети, используя метод API CSocNetGroup::CreateGroup(), указывая владельцем группы текущего пользователя
                public static readonly string Create = Base + "create";


                /// Удаляет группу соцсети
                public static readonly string Delete = Base + "delete";

                /// https://dev.1c-bitrix.ru/rest_help/sonet_group/sonet_group_feature_access.php
                public static class Feature
                {
                    private static string Base = "sonet_group.feature.";


                    /// Проверяет, имеет ли текущий пользователь право на совершение операции в группе соцсети, 
                    /// осуществляя вызов функции CSocNetFeaturesPerms::CurrentUserCanPerformOperation()
                    public static readonly string Access = Base + "access";
                }


                /// Возвращает массив групп соцсети, каждая из которых содержит массив полей, 
                /// осуществляя вызов CSocNetGroup::GetList(), при этом возвращаются только те группы, 
                /// которые доступны пользователю по правам
                public static readonly string Get = Base + "get";


                /// Изменяет владельца группы
                public static readonly string Setowner = Base + "setowner";


                /// Изменяет параметры группы соцсети, используя метод API CSocNetGroup::Update()
                public static readonly string Update = Base + "setowner";

                /// под пространство "sonet_group.user."
                public static class User
                {
                    private static readonly string Base = "sonet_group.user.";

                    /// Добавляет пользователей в качестве участников рабочей группы (без приглашения и подтверждения)
                    public static readonly string Add = Base + "add";

                    /// Удаляет пользователей из рабочей группы
                    public static readonly string Delete = Base + "delete";

                    /// Возвращает массив участников группы соцсети, осуществляя вызов CSocNetUserToGroup::GetList(), 
                    /// при этом проверяются права на доступ текущего пользователя к группе
                    public static readonly string Get = Base + "get";

                    /// Возвращает массив групп соцсети текущего пользователя, осуществляя вызов CSocNetUserToGroup::GetList()
                    public static readonly string Groups = Base + "groups";

                    /// Выполняет приглашение пользователей в группу соцсети от лица текущего пользователя,
                    /// при этом проверяются права на доступ текущего пользователя к группе
                    public static readonly string Invite = Base + "invite";

                    /// отправляет запрос текущего пользователя на вступление в группу соцсети,
                    /// при этом проверяются права на доступ текущего пользователя к группе
                    public static readonly string Request = Base + "request";

                    /// Изменяет роль пользователей в рабочей группе
                    public static readonly string Update = Base + "update";
                }
            }


            /// Пространство имен методов для ботов
            public static class Imbot
            {

                /// Пространство имен методов для сообщений ботов
                public static class Message
                {
                    private static readonly string Base = "imbot.message.";


                    /// добавление сообщения от бота https://dev.1c-bitrix.ru/learning/course/index.php?COURSE_ID=93&LESSON_ID=17112
                    public static readonly string Add = Base + "add";
                }
            }
        }
    }