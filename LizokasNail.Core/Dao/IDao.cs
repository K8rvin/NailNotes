using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LizokasNail.Core.Dao
{
    public interface IDao<TData> where TData : EntityData
    {
        TData Get(int id);
        TData Get_NoTracking(int id);
        List<TData> Get(Expression<Func<TData, bool>> condition = null);
        List<TData> Get_NoTracking(Expression<Func<TData, bool>> condition = null);

        void Create(TData entity);
        void CreateRange(IEnumerable<TData> range);

        void Update(TData entity);
        void UpdateRange(IEnumerable<TData> entities);

        void Delete(int id);
        void Delete(Expression<Func<TData, bool>> condition);
        void DeleteRange(IEnumerable<TData> entities);
    }
}
