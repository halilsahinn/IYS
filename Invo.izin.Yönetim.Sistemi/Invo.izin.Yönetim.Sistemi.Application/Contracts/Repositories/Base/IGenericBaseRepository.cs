#region NAMESPACES
using System.Linq.Expressions;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Base
{
    public interface IGenericBaseRepository<T> where T : class
    {
        #region METHODS  SIGNATURES
        Task<T> GetById(int id);
        IEnumerable<T> GetBy(Expression<Func<T, bool>> expression);
        T GetByPredicate(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAll();
        IQueryable<T> GetAllByIQueryable();
        Task<T> Add(T entity);
        Task<bool> Exists(int id);
        Task Update(T entity);
        Task Delete(T entity);
        #endregion

    }
}
