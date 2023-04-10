namespace Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest
{
    public class LeaveRequestDto
    {
        public string EmployeeName { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public string LeaveType { get; set; }
        public decimal LeaveTime { get; set; }
        public bool IsApproved { get; set; }

    }
}
