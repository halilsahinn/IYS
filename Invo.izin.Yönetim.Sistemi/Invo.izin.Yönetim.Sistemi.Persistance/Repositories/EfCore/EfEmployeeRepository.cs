#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories;
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using Invo.izin.Yönetim.Sistemi.Persistance.Contex;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore.Base;
using Microsoft.EntityFrameworkCore;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore
{
    public class EfEmployeeRepository : EfGenericBaseRepository<EmployeeEntity>, IEmployeeService
    {
        #region FIELDS
        private readonly IYSDbContext _dbContext;
        #endregion

        #region CTOR
        public EfEmployeeRepository(IYSDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region METHODS
        public async Task<List<EmployeeEntity>> GetEmployeeWithParameters()
        {
            var result= await _dbSet
                .Include(s => s.Department)
                .Include(s => s.Title)
                .Include(s => s.BranchOffice)
                .ToListAsync();

            return result;
        }
        #endregion


    }
}
