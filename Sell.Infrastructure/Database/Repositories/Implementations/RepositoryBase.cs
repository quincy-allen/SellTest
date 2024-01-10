using Microsoft.EntityFrameworkCore;
using Sell.Infrastructure.Database.Context;
using Sell.Infrastructure.Database.Repositories.Interfaces;
using System.Linq.Expressions;

namespace Sell.Infrastructure.Database.Repositories.Implementations
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected SellDbContext _context { get; set; }

        public RepositoryBase(SellDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> FindAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Delete(Expression<Func<T, bool>> expression)
        {
            var entitiesToDelete = _context.Set<T>().Where(expression).AsNoTracking();

            _context.Set<T>().RemoveRange(entitiesToDelete);
        }
    }
}
