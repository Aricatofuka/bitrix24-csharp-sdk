﻿namespace BXRest.Core.Models.Response.BatchResponse
{
    public class ByIdBatchResponseItem<TResult>
    {
        public TResult Result { get; set; }
        public int Id { get; set; }
    }
}
