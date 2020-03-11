using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Pangathon.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : IEntity
    {
        void Delete(Guid id);
        void Delete(TEntity entityToDelete);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        TEntity GetById(Guid id);
        TEntity GetById(Guid id, string includeProperties);
        TEntity Insert(TEntity entityToInsert);
        void Update(TEntity entityToUpdate);
    }
}
