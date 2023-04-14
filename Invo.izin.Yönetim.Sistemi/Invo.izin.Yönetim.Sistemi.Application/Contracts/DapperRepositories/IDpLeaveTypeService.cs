using Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveType;

namespace Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories
{
    public interface IDpLeaveTypeService
    {
        public Task<List<LeaveTypeSelectListDto>> GetLeaveTypeSelectList();

    }
}
