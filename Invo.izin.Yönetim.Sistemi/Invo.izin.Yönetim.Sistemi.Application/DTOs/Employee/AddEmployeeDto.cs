using Invo.izin.Yönetim.Sistemi.Application.DTOs.Base;

namespace Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee
{
    public class AddEmployeeDto
    {
        public string EmployeeName { get; set; }

        public string EmployeeSurName { get; set; }

        public string? UserId { get; set; }

        public bool IsHead { get; set; }

        public byte? DepartmentId { get; set; }
        public byte? TitleId { get; set; }

        public byte? BranchOfficeId { get; set; }

        public byte? LeavePermissionLevelId { get; set; }
    }
}
