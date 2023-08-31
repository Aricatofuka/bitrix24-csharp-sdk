using Newtonsoft.Json;
using BXRest.Core.Models.CrmAbstractEntity;

namespace BXRest.Test.Models
{
    public class TestDeal
    {

        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}
