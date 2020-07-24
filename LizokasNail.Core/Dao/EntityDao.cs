using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace LizokasNail.Core.Dao
{
    public class EntityDao<TData> : BaseDao, IDao<TData> where TData : EntityData
    {
        public EntityDao(IDataSource dataSource) : base(dataSource)
        { }

        public TData Get(int id)
        {
            return ReadContext(db => { return db.Set<TData>().FirstOrDefault(x => x.Id.Equals(id)); });
        }

        public TData Get_NoTracking(int id)
        {
            return ReadContext(db => { return db.Set<TData>().AsNoTracking().FirstOrDefault(x => x.Id.Equals(id)); });
        }

        public virtual List<TData> Get(Expression<Func<TData, bool>> condition = null)
        {
            return ReadContext(db =>
            {
                var set = condition == null ? db.Set<TData>() : db.Set<TData>().Where(condition);
                return set.ToList();
            });
        }

        public virtual List<TData> Get_NoTracking(Expression<Func<TData, bool>> condition = null)
        {
            return ReadContext(db =>
            {
                var set = condition == null ? db.Set<TData>().AsNoTracking() : db.Set<TData>().AsNoTracking().Where(condition);
                return set.ToList();
            });
        }

        public virtual void Create(TData entity)
        {
            if (entity == null) return;
            UpdateContext(db => db.Add(entity));
        }

        public void CreateRange(IEnumerable<TData> entities)
        {
            if (entities == null) return;
            UpdateContext(db => db.AddRange(entities));
        }

        public virtual void Update(TData data)
        {
            UpdateContext(x => x.Update(data));
        }

        public virtual void UpdateRange(IEnumerable<TData> entities)
        {
            if (entities == null) return;
            UpdateContext(x => x.UpdateRange(entities));
        }

        public virtual void Delete(int id)
        {
            UpdateContext(db =>
            {
                var entity = db.Set<TData>().Find(id);
                if (entity != null) db.Remove(entity);
            });
        }

        public virtual void Delete(Expression<Func<TData, bool>> condition)
        {
            UpdateContext(db =>
            {
                var entity = db.Set<TData>().Where(condition);
                db.RemoveRange(entity);
            });
        }

        public virtual void DeleteRange(IEnumerable<TData> entities)
        {
            if (entities == null) return;
            UpdateContext(x => x.RemoveRange(entities));
        }
    }
}
