using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BXRest.Models.Parameter.Request
{
    public class Filter
    {
        public enum SpecialCharacter
        {
            [Description("")]
            Equal,
            [Description(">")]
            More,
            [Description("<")]
            Less,
            [Description("<=")]
            LessOrEqual,
            [Description(">=")]
            MoreOrEqual,
            [Description("!")]
            notEqual
        }

        public class iBXFilterValue<T> : Dictionary<SpecialCharacter, T> { }


    }
}
