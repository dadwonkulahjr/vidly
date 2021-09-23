using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vidly.Services.Repository.IRepository
{
    public interface IDefaultRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string navigationProperties = null);
    }
}
