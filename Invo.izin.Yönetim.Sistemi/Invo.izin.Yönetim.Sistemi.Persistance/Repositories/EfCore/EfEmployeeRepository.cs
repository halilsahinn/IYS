#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories;
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using Invo.izin.Yönetim.Sistemi.Persistance.Contex;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore.Base;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore
{
    public class EfEmployeeRepository : EfGenericBaseRepository<EmployeeEntity>, IEmployeeService
    {
        #region NAMESPACES
        private readonly IYSDbContext _dbContext;
        #endregion

        #region CTOR
        public EfEmployeeRepository(IYSDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion
    }
}
