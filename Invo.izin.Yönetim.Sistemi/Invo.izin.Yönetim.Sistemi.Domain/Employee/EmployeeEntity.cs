#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Base;
using Invo.izin.Yönetim.Sistemi.Domain.Parameter;
using System.ComponentModel.DataAnnotations.Schema;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Domain.Employee
{
    public class EmployeeEntity :BaseEntity <int>
    {
        #region PROPERTIES
     
        public string EmployeeName { get; set; }

        public string EmployeeSurName { get; set; }

        public bool IsHead { get; set; }
        #endregion

        #region NAVIGATION PROPERTIES
        public string? UserId { get; set; }

        #region Department
        [ForeignKey("DepartmentId")]
        public DepartmentEntity Department { get; set; }
        public byte? DepartmentId { get; set; }
        #endregion

        #region Title
        [ForeignKey("TitleId")]
        public byte? TitleId { get; set; }
        public EmployeeTitleEntity Title { get; set; }
        #endregion


        #region BranchOfficeId
        [ForeignKey("BranchOfficeId")]
        public byte? BranchOfficeId { get; set; }

        public BranchOfficeEntity BranchOffice { get; set; }
        #endregion

        #region LeavePermissionLevelId
        [ForeignKey("LeavePermissionLevelId")]
        public byte? LeavePermissionLevelId { get; set; }

        public LeavePermissionLevelEntity LeavePermissionLevel { get; set; }
        #endregion




        #endregion

    }
}
