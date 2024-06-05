using System.Collections.Generic;
using System.ComponentModel;

namespace BXRest.Models.Parameter.Request
{
    /// Перечень символов которые можно вставить первыми в начале фильтре
    public class Filter
    {
        /// Символы которые можно вставить первыми в начале фильтре
        public enum SpecialCharacter
        {
            /// Ровно
            [Description("")]
            Equal,
            /// Больше
            [Description(">")]
            More,
            /// Меньше
            [Description("<")]
            Less,
            /// Меньше и равно
            [Description("<=")]
            LessOrEqual,
            /// больше и равно
            [Description(">=")]
            MoreOrEqual,
            /// Не равно
            [Description("!")]
            notEqual
        }

        /// Модель таких фильтров в с#
        public class iBXFilterValue<T> : Dictionary<SpecialCharacter, T> { }


    }
}
