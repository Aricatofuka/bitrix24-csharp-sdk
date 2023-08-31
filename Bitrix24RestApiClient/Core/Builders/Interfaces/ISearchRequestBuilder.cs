using System;
using System.Linq.Expressions;
using BXRest.Core.Models;
using BXRest.Core.Builders.Interfaces;

namespace BXRest.Core.Builders.Interfaces
{
    public interface ISearchRequestBuilder<TEntity>
    {
        ISearchRequestBuilder<TEntity> AddFilter(Expression<Func<TEntity, object>> nameExpr, object value, FilterOperator op = FilterOperator.Default);
    }
}
