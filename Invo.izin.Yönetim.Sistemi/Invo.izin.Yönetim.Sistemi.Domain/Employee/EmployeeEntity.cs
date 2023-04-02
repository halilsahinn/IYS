#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Base;
using Invo.izin.Yönetim.Sistemi.Domain.Parameter;
using System.ComponentModel.DataAnnotations.Schema;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Domain.Employee
{
    public class EmployeeEntity : BaseEntity<int>
    {
        #region PROPERTIES
        public string EmployeeName { get; set; }

        public string EmployeeSurName { get; set; }
        #endregion

        #region NAVIGATION PROPERTIES
        public int? UserId { get; set; }

        [ForeignKey("HeadId")]
        public int? HeadId { get; set; }
        public DepartmentOfHeadEntity DepartmentOfHead { get; set; }
       

        [ForeignKey("BranchOfficeId")]
        public byte? BranchOfficeId { get; set; }
        
        public BranchOfficeEntity BranchOffice { get; set; }

        [ForeignKey("LeavePermissionLevelId")]
        public byte? LeavePermissionLevelId { get; set; }

        public LeavePermissionLevelEntity LeavePermissionLevel { get; set; }


        #endregion

    }
}
