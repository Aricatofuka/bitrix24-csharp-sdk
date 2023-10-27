using BXRest.Core.Models.Response.Common;
using static BXRest.Api.Models.Base;

namespace BXRest.Core.Models.Response
{
    public class iGetRespnse<T>
    {
        public T result { get; set; }
        public int? next { get; set; }
        public int? total { get; set; }
        public Time time { get; set; }
    }
}
