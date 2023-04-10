namespace Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee
{
    public class UpdateEmployeeDto
    {
        #region CTOR
        public UpdateEmployeeDto()
        {
            UpdatedDate = DateTime.Now;
        }
        #endregion

        #region PROPPERTIES
        public string EmployeeName { get; set; }

        public string EmployeeSurName { get; set; }

        public int? UserId { get; set; }

        public bool IsHead { get; set; }

        public byte? BranchOfficeId { get; set; }

        public byte? LeavePermissionLevelId { get; set; }

        public DateTime UpdatedDate { get; set; }
        #endregion

    }
}
