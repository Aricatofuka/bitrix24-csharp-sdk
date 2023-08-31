using Newtonsoft.Json;
using System.Collections.Generic;
using BXRest.Core.Models.Response.Common;

namespace BXRest.Core.Models.Response.FieldsResponse
{
    public class UserFieldsResponse
    {
        [JsonProperty("result")]
        public Dictionary<string, string> Result { get; set; } = new Dictionary<string, string>();

        [JsonProperty("time")]
        public Time Time { get; set; }
    }
}
