#nullable enable
using BXRest.Converter;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BXRest.Models.User
{
    /// Пользователи
    public class iUser
    {
        /// ID
        [JsonConverter(typeof(StringToNumberConverter<uint>))]
        public uint ID { get; set; }
        
        /// Активность
        public bool ACTIVE { get; set; }

        /// E-Mail
        public string EMAIL { get; set; }

        /// Последняя авторизация
        public string? LAST_LOGIN { get; set; }

        /// Дата регистрации
        public string DATE_REGISTER { get; set; }

        /// IS_ONLINE
        public string IS_ONLINE { get; set; }

        /// Имя
        public string? NAME { get; set; }

        /// Фамилия
        public string? LAST_NAME { get; set; }

        /// Отчество
        public string SECOND_NAME { get; set; }

        /// Пол человека
        public string? PERSONAL_GENDER { get; set; }

        /// Профессия
        public string? PERSONAL_PROFESSION { get; set; }

        /// Домашняя страничка
        public string? PERSONAL_WWW { get; set; }

        /// Дата рождения
        public DateTime? PERSONAL_BIRTHDAY { get; set; }

        /// Фотография
        public string? PERSONAL_PHOTO { get; set; }

        /// ICQ
        public string? PERSONAL_ICQ { get; set; }

        /// Личный телефон
        public string? PERSONAL_PHONE { get; set; }

        /// Факс
        public string? PERSONAL_FAX { get; set; }

        /// Личный мобильный
        public string? PERSONAL_MOBILE { get; set; }

        /// Пейджер
        public string? PERSONAL_PAGER { get; set; }

        /// Улица проживания
        public string? PERSONAL_STREET { get; set; }

        /// Город проживания
        public string? PERSONAL_CITY { get; set; }

        /// Область / край
        public string? PERSONAL_STATE { get; set; }

        /// Почтовый индекс
        public string? PERSONAL_ZIP { get; set; }

        /// Страна
        public string? PERSONAL_COUNTRY { get; set; }

        /// TIME_ZONE_OFFSET
        public string? TIME_ZONE_OFFSET { get; set; }

        /// Компания
        public string? WORK_COMPANY { get; set; }

        /// Должность
        public string? WORK_POSITION { get; set; }

        /// Телефон компании
        public string? WORK_PHONE { get; set; }

        /// Подразделения
        public List<uint> UF_DEPARTMENT { get; set; } = [];

        /// Интересы
        public string? UF_INTERESTS{ get; set; }

        /// Навыки
        public string? UF_SKILLS { get; set; }

        /// Другие сайты
        public string? UF_WEB_SITES { get; set; }

        /// Xing
        public string? UF_XING { get; set; }

        /// LinkedIn
        public string? UF_LINKEDIN { get; set; }

        /// Facebook
        public string? UF_FACEBOOK { get; set; }

        /// Twitter
        public string? UF_TWITTER { get; set; }

        /// Логин Skype
        public string? UF_SKYPE { get; set; }

        /// Район
        public string? UF_DISTRICT { get; set; }

        /// Внутренний телефон
        public string? UF_PHONE_INNER { get; set; }

        public string? USER_TYPE { get; set; }

    }
}
