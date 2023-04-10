using Invo.izin.Yönetim.Sistemi.Domain.Base;

namespace Invo.izin.Yönetim.Sistemi.Domain.Employee
{
    public class DepartmentEntity : BaseEntity<byte>
    {
        public DepartmentEntity()
        {
            Employee = new List<EmployeeEntity>();
        }

        public string DepartmentName { get; set; }

        public List<EmployeeEntity> Employee { get; set; }

    }
}
