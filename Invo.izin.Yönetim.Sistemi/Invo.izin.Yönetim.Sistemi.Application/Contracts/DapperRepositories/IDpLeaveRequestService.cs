using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest;

namespace Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories
{
    public interface IDpLeaveRequestService
    {
        public Task<List<LeaveRequestDto>> GetLeaveRequestList();
    }
}
