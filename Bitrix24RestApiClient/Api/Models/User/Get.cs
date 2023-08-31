
using System.Collections.Generic;
using static BXRest.Api.Models.Base;

namespace BXRest.Api.Models.User
{
    public class iGet
    {
        public List<int>? ID { get; set; }
        public string? order { get; set; }
        public iGetFilter? FILTER { get; set; }

    }

    public class iGetFilter {
        public List<string>? PERSONAL_BIRTHDAY { get; set; }
        public List<int>? UF_DEPARTMENT { get; set; }
        public string? UF_PHONE_INNER { get; set; }
        public iBXRestYesNo? IS_ONLINE { get; set; }
        public string? NAME_SEARCH { get; set; }
        public string? USER_TYPE { get; set; }
        public int? ACTIVE { get; set; }
    }
}
