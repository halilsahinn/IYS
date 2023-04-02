#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Parameter;
using Invo.izin.Yönetim.Sistemi.Domain.Parameter;
using Invo.izin.Yönetim.Sistemi.Persistance.Contex;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore.Base;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore.Parameter
{
    public class EfEmployeeTitleRepository : EfGenericBaseRepository<EmployeeTitleEntity>, IEmployeeTitleService
    {
        #region FIELDS
        private readonly IYSDbContext _dbContext;
        #endregion

        #region CTOR
        public EfEmployeeTitleRepository(IYSDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion
    }
}
