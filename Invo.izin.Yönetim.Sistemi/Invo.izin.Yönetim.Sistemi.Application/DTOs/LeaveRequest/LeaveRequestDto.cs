namespace Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest
{
    public class LeaveRequestDto
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime FinishedDate { get; set; }

        public  decimal LeaveTime { get; set; }
        public string LeaveTypeName { get; set; }
        public string Status { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }

    }
}
