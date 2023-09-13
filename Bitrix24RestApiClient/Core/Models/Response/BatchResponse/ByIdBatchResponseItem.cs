namespace BXRest.Core.Models.Response.BatchResponse
{
    public class ByIdBatchResponseItem<R>
    {
        public R result { get; set; }
        public int id { get; set; }
    }
}
