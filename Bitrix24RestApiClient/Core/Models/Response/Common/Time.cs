using System;

namespace BXRest.Core.Models.Response.Common
{
    public class Time
	{
		public decimal start { get; set; }
		public decimal finish { get; set; }

		public decimal duration { get; set; }
		public decimal processing { get; set; }
		public DateTimeOffset dateStart { get; set; }
		public DateTimeOffset dateFinish { get; set; }
    }
}
