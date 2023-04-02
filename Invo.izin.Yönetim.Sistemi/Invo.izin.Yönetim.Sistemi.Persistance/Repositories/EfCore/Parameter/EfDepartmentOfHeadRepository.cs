#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Parameter;
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using Invo.izin.Yönetim.Sistemi.Persistance.Contex;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore.Base;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore.Parameter
{
    public class EfDepartmentOfHeadRepository : EfGenericBaseRepository<DepartmentOfHeadEntity>, IDepartmentOfHeadService
    {
        #region FIELDS
        private readonly IYSDbContext _dbContext;
        #endregion

        #region CTOR
        public EfDepartmentOfHeadRepository(IYSDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion
    }
}
