#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Base;
using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest;
using Invo.izin.Yönetim.Sistemi.Domain.Leave;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories
{
    public interface ILeaveRequestService : IGenericBaseRepository<LeaveRequestEntity>
    {
        public   Task<ApprovedStatusDto>  UpdateLeaveRequestApproved(int id);
        public Task<LeaveRequestEntity> GetLeaveRequestById(int id);

    }
}
