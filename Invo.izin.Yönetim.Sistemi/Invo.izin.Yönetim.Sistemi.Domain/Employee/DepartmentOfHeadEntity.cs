#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Base;
using Invo.izin.Yönetim.Sistemi.Domain.Parameter;
using System.ComponentModel.DataAnnotations.Schema;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Domain.Employee
{
    public class DepartmentOfHeadEntity : BaseEntity<byte>
    {
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public EmployeeEntity Employee { get; set; }


        [ForeignKey("DepartmentId")]
        public byte DepartmentId { get; set; }
        public DepartmentEntity Department { get; set; }


        [ForeignKey("LeavePermissionLevelId")]
        public byte LeavePermissionLevelId { get; set; }
        public LeavePermissionLevelEntity LeavePermissionLevel { get; set; }

    }
}
