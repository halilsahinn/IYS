#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Base;
using Invo.izin.Yönetim.Sistemi.Persistance.Contex;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore.Base
{
    public class EfGenericBaseRepository<T> : IGenericBaseRepository<T> where T : class
    {
        #region FIELDS
        private readonly IYSDbContext _dbContext;
        protected DbSet<T> _dbSet => _dbContext.Set<T>();
        #endregion

        #region CTOR
        public EfGenericBaseRepository(IYSDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region METHODS
        public async Task<T> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public async Task Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetById(id);
            return entity != null;
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public IQueryable<T> GetAllByIQueryable()
        {
            return _dbSet.AsQueryable();
        }

        public IEnumerable<T> GetBy(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
            // _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public T GetByPredicate(Expression<Func<T, bool>> expression)
        {
            return _dbSet.SingleOrDefault(expression);
        }
        #endregion
    }
}
