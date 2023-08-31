using System;
using System.Linq.Expressions;
using BXRest.Core.Models;
using BXRest.Core.Builders.Interfaces;

namespace BXRest.Core.Builders.Interfaces
{
    public interface IStageHistoriesListRequestBuilder<TEntity>
    {
        IListRequestBuilder<TEntity> SetStart(int start);
        IListRequestBuilder<TEntity> AddOrderBy(Expression<Func<TEntity, object>> fieldExpr);
        IListRequestBuilder<TEntity> AddOrderByDesc(Expression<Func<TEntity, object>> fieldExpr);
        IListRequestBuilder<TEntity> AddFilter(Expression<Func<TEntity, object>> nameExpr, object value, FilterOperator op = FilterOperator.Default);
    }
}
