using BXRest.Converter;
using Newtonsoft.Json;

namespace BXRest.Models.Task.Item
{
    /// <summary>
    /// Модель костомных полей у задач в битриксе когда мы запрашивает одно поле через метод task.item.userfield.get
    /// </summary>
    public class iUserfieldWhenGetOne: iUserfield
    {
        public iUserfieldLabel EDIT_FORM_LABEL { get; set; }
        public iUserfieldLabel LIST_COLUMN_LABEL { get; set; }
        public iUserfieldLabel LIST_FILTER_LABEL { get; set; }
        public iUserfieldLabel ERROR_MESSAGE { get; set; }
        public iUserfieldLabel HELP_MESSAGE { get; set; }
    }

    /// <summary>
    /// Модель костомных полей у задач в битриксе, для метода task.item.userfield.getlist
    /// </summary>
    public class iUserfield
    {
        public int ID { get; set; }
        public string ENTITY_ID { get; set; }
        public string FIELD_NAME { get; set; }
        public string USER_TYPE_ID { get; set; }
        
        public string? XML_ID { get; set; }
        public int SORT { get; set; }
        
        [JsonConverter(typeof(YesNoBX))]
        public bool MULTIPLE { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool MANDATORY { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool SHOW_FILTER { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool SHOW_IN_LIST { get; set; }


        [JsonConverter(typeof(YesNoBX))]
        public bool EDIT_IN_LIST { get; set; }

        [JsonConverter(typeof(YesNoBX))]
        public bool IS_SEARCHABLE { get; set; }

        public dynamic SETTINGS { get; set; } // TODO: разобраться позже
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

    public class iUserfieldLabel
    {
        public string? br { get; set; }
        public string? de { get; set; }
        public string? en { get; set; }
        public string? fr { get; set; }
        public string? @in { get; set; }
        public string? it { get; set; }
        public string? la { get; set; }
        public string? pl { get; set; }
        public string? ru { get; set; }
        public string? sc { get; set; }
        public string? tc { get; set; }
        public string? tr { get; set; }
        public string? ua { get; set; }
    }
}
