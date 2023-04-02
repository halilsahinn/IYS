#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Base;
using Invo.izin.Yönetim.Sistemi.Domain.Leave;
using Invo.izin.Yönetim.Sistemi.Persistance.Contex;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore.Base;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore
{
    public class EfLeaveRequestRepository : EfGenericBaseRepository<LeaveRequestEntity>, ILeaveRequestService
    {
        #region NAMESPACES
        private readonly IYSDbContext _dbContext;
        #endregion

        #region CTOR
        public EfLeaveRequestRepository(IYSDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

    }
}
