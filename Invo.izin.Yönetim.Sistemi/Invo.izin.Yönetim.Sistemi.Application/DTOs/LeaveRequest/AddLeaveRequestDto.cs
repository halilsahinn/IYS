namespace Invo.izin.Yönetim.Sistemi.Application.DTOs.LeaveRequest
{
    public class AddLeaveRequestDto
    {
        #region CTOR
        public AddLeaveRequestDto()
        {
            IsApproved = false;
        }
        #endregion

        #region PROPERTIES
        public int EmployeeId { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public byte LeaveTypeId { get; set; }
        public decimal LeaveTime { get; set; }
        public bool IsApproved { get; set; }

        #endregion

    }
}
