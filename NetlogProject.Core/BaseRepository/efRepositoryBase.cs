using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NetlogProject.Core.BaseRepository
{
    public class efRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, new()
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public efRepositoryBase(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            var activeEntity = _dbSet.Add(entity);
            activeEntity.State = EntityState.Added;
        }

        public void Delete(TEntity entity)
        {
            var activeEntity = _context.Entry(entity);
            activeEntity.State = EntityState.Deleted;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> condition)
        {
            return _context.Set<TEntity>().AsNoTracking().FirstOrDefault(condition);
        }

        public List<TEntity> List(Expression<Func<TEntity, bool>> condition = null)
        {
            var list = condition == null ?
                _context.Set<TEntity>().ToList() :
                _context.Set<TEntity>().Where(condition).ToList();

            return list;
        }

        public void Update(TEntity entity)
        {
            var activeEntity = _context.Entry(entity);
            activeEntity.State = EntityState.Modified;
        }

        public bool SaveChanges()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
