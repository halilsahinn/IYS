#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Base;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest;
using Invo.izin.Yönetim.Sistemi.Domain.Leave;
using Invo.izin.Yönetim.Sistemi.Persistance.Contex;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore.Base;
using Microsoft.EntityFrameworkCore;
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

        #region METHODS
        public async Task<ApprovedStatusDto> UpdateLeaveRequestApproved(int id)
        {
           var result= await GetLeaveRequestById(id);
            ApprovedStatusDto approved = new ApprovedStatusDto();


            if (result is not null)
            {
                result.IsApproved = true;

               
                var updateResult = Update(result);

                approved.Approved = true;
            }

            approved.Approved = false;


            return approved;
        }

        public async Task<LeaveRequestEntity> GetLeaveRequestById(int id)
        {
            var result= await GetById(id);
            return   result;
        }

        #endregion

    }
}
