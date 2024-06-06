using System;
using System.Linq.Expressions;
using BXRest.Core.Models;

namespace BXRest.Core.Builders.Interfaces
{
    public interface ISearchRequestBuilder<TEntity>
    {
        ISearchRequestBuilder<TEntity> AddFilter(Expression<Func<TEntity, object>> nameExpr, object value, FilterOperator op = FilterOperator.Default);
    }
}
