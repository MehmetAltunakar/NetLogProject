using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NetlogProject.Core.BaseRepository
{
    public interface IEntityRepository<T> where T : class, new()
    {
        List<T> List(Expression<Func<T, bool>> condition = null);
        T Get(Expression<Func<T, bool>> condition);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool SaveChanges();
    }
}
