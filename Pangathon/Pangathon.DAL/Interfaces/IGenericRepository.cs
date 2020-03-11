using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Pangathon.DAL.Interfaces
{
    public interface IGenericRepository<TEntity, TIdType> where TEntity : IEntity<TIdType>
    {
        void Delete(TIdType id);
        void Delete(TEntity entityToDelete);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        TEntity GetById(TIdType id);
        TEntity Insert(TEntity entityToInsert);
        void Update(TEntity entityToUpdate);
    }
}
