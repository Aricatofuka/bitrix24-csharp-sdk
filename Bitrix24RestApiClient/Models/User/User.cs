#nullable enable
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BXRest.Models.User
{
    /// <summary>
    /// Пользователи
    /// </summary>
    public class iUser
    {
        /// <summary>
        /// ID
        /// Тип: string
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Активность
        /// Тип: string
        /// </summary>
        public bool ACTIVE { get; set; }

        /// <summary>
        /// E-Mail
        /// Тип: string
        /// </summary>
        public string EMAIL { get; set; }

        /// <summary>
        /// Последняя авторизация
        /// Тип: string
        /// </summary>
        public string? LAST_LOGIN { get; set; }

        /// <summary>
        /// Дата регистрации
        /// Тип: string
        /// </summary>
        public string DATE_REGISTER { get; set; }

        /// <summary>
        /// IS_ONLINE
        /// Тип: string
        /// </summary>
        public string IS_ONLINE { get; set; }

        /// <summary>
        /// Имя
        /// Тип: string
        /// </summary>
        public string? NAME { get; set; }

        /// <summary>
        /// Фамилия
        /// Тип: string
        /// </summary>
        public string? LAST_NAME { get; set; }

        /// <summary>
        /// Отчество
        /// Тип: string
        /// </summary>
        public string SECOND_NAME { get; set; }

        /// <summary>
        /// Пол
        /// Тип: string
        /// </summary>
        public string? PERSONAL_GENDER { get; set; }

        /// <summary>
        /// Профессия
        /// Тип: string
        /// </summary>
        public string? PERSONAL_PROFESSION { get; set; }

        /// <summary>
        /// Домашняя страничка
        /// Тип: string
        /// </summary>
        public string? PERSONAL_WWW { get; set; }

        /// <summary>
        /// Дата рождения
        /// Тип: string
        /// </summary>
        public DateTime? PERSONAL_BIRTHDAY { get; set; }

        /// <summary>
        /// Фотография
        /// Тип: string
        /// </summary>
        public string? PERSONAL_PHOTO { get; set; }

        /// <summary>
        /// ICQ
        /// Тип: string
        /// </summary>
        public string? PERSONAL_ICQ { get; set; }

        /// <summary>
        /// Личный телефон
        /// Тип: string
        /// </summary>
        public string? PERSONAL_PHONE { get; set; }

        /// <summary>
        /// Факс
        /// Тип: string
        /// </summary>
        public string? PERSONAL_FAX { get; set; }

        /// <summary>
        /// Личный мобильный
        /// Тип: string
        /// </summary>
        public string? PERSONAL_MOBILE { get; set; }

        /// <summary>
        /// Пейджер
        /// Тип: string
        /// </summary>
        public string? PERSONAL_PAGER { get; set; }

        /// <summary>
        /// Улица проживания
        /// Тип: string
        /// </summary>
        public string? PERSONAL_STREET { get; set; }

        /// <summary>
        /// Город проживания
        /// Тип: string
        /// </summary>
        public string? PERSONAL_CITY { get; set; }

        /// <summary>
        /// Область / край
        /// Тип: string
        /// </summary>
        public string? PERSONAL_STATE { get; set; }

        /// <summary>
        /// Почтовый индекс
        /// Тип: string
        /// </summary>
        public string? PERSONAL_ZIP { get; set; }

        /// <summary>
        /// Страна
        /// Тип: string
        /// </summary>
        public string? PERSONAL_COUNTRY { get; set; }

        /// <summary>
        /// TIME_ZONE_OFFSET
        /// Тип: string
        /// </summary>
        public string? TIME_ZONE_OFFSET { get; set; }

        /// <summary>
        /// Компания
        /// Тип: string
        /// </summary>
        public string? WORK_COMPANY { get; set; }

        /// <summary>
        /// Должность
        /// Тип: string
        /// </summary>
        public string? WORK_POSITION { get; set; }

        /// <summary>
        /// Телефон компании
        /// Тип: string
        /// </summary>
        public string? WORK_PHONE { get; set; }

        /// <summary>
        /// Подразделения
        /// Тип: string
        /// </summary>
        public List<int> UF_DEPARTMENT { get; set; }

        /// <summary>
        /// Интересы
        /// Тип: string
        /// </summary>
        public string? UfInterUF_INTERESTSests { get; set; }

        /// <summary>
        /// Навыки
        /// Тип: string
        /// </summary>
        public string? UF_SKILLS { get; set; }

        /// <summary>
        /// Другие сайты
        /// Тип: string
        /// </summary>
        public string? UF_WEB_SITES { get; set; }

        /// <summary>
        /// Xing
        /// Тип: string
        /// </summary>
        public string? UF_XING { get; set; }

        /// <summary>
        /// LinkedIn
        /// Тип: string
        /// </summary>
        public string? UF_LINKEDIN { get; set; }

        /// <summary>
        /// Facebook
        /// Тип: string
        /// </summary>
        public string? UF_FACEBOOK { get; set; }

        /// <summary>
        /// Twitter
        /// Тип: string
        /// </summary>
        public string? UF_TWITTER { get; set; }

        /// <summary>
        /// Логин Skype
        /// Тип: string
        /// </summary>
        public string? UF_SKYPE { get; set; }

        /// <summary>
        /// Район
        /// Тип: string
        /// </summary>
        public string? UF_DISTRICT { get; set; }

        /// <summary>
        /// Внутренний телефон
        /// Тип: string
        /// </summary>
        public string? UF_PHONE_INNER { get; set; }

        /// <summary>
        /// USER_TYPE
        /// Тип: string
        /// </summary>
        public string? USER_TYPE { get; set; }

    }
}
