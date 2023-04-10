namespace Invo.izin.Yönetim.Sistemi.Application.DTOs.Employee
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeSurName { get; set; }
        public string DepartmentName { get; set; }

        public bool IsHead { get; set; }

        public string Title { get; set; }

        public string BranchOfficeName { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
