using Invo.izin.Yönetim.Sistemi.Application.DTOs.Base;

namespace Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest
{
    public class UpdateLeaveRequestDto : BaseDto<int>
    {
        public int EmployeeId { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public byte LeaveTypeId { get; set; }
        public decimal LeaveTime { get; set; }
        public bool IsApproved { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
