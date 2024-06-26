﻿#nullable enable
using BXRest.Converter;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BXRest.Models.Task.Item
{
    /// Модель костомных полей у задач в битриксе когда мы запрашивает одно поле через метод task.item.userfield.get
    public class iUserfieldWhenGetOne: iUserfield
    {
        /// Название поля в форме редактирования
        public iUserfieldLabel EDIT_FORM_LABEL { get; set; }

        /// Название поля в колонке
        public iUserfieldLabel LIST_COLUMN_LABEL { get; set; }

        /// Название поля в фильтре
        public iUserfieldLabel LIST_FILTER_LABEL { get; set; }

        /// Сообщение об ошибке
        public iUserfieldLabel ERROR_MESSAGE { get; set; }

        /// Помощь 
        public iUserfieldLabel HELP_MESSAGE { get; set; }
    }

    /// Модель костомных полей у задач в битриксе, для метода task.item.userfield.getlist
    public class iUserfield
    {
        /// индификатор
        public int ID { get; set; }
        public string ENTITY_ID { get; set; }
        public string FIELD_NAME { get; set; }
        public string USER_TYPE_ID { get; set; }
        
        /// xml индификатор
        public string? XML_ID { get; set; }

        /// Циферка для сортировка
        public int SORT { get; set; }
        
        /// Мульти ввод (да/нет)
        [JsonConverter(typeof(YesNoBX))]
        public bool MULTIPLE { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool MANDATORY { get; set; }

        /// Показывать ли в фильтре
        [JsonConverter(typeof(YesNoBX))]
        public bool SHOW_FILTER { get; set; }

        /// Показывать ли в списке
        [JsonConverter(typeof(YesNoBX))]
        public bool SHOW_IN_LIST { get; set; }
        
        [JsonConverter(typeof(YesNoBX))]
        public bool EDIT_IN_LIST { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool IS_SEARCHABLE { get; set; }

        /// это свойство есть только у enum свойств
        public List<iUserfieldList>? LIST { get; set; }

        public dynamic SETTINGS { get; set; } // TODO: разобраться позже
    }

    public class iUserfieldList
    {
        public uint ID { get; set; }
        public uint SORT { get; set; }
        public string VALUE { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool DEF { get; set; }
    }
    /*
    public class iUserfieldSettings
    {
        [JsonConverter(typeof(YesNoBX))]
        public bool LEAD { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool CONTACT { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool COMPANY { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool DEAL { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool ORDER { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool SMART_INVOICE { get; set; }
    }
    */

    /// Обект названий на разных языках
    public class iUserfieldLabel
    {

        public string? br { get; set; }
        public string? de { get; set; }

        /// Английский 
        public string? en { get; set; }
        public string? fr { get; set; }
        public string? @in { get; set; }
        public string? it { get; set; }
        public string? la { get; set; }
        public string? pl { get; set; }

        /// Русский
        public string? ru { get; set; }
        public string? sc { get; set; }
        public string? tc { get; set; }
        public string? tr { get; set; }
        public string? ua { get; set; }
    }
}
