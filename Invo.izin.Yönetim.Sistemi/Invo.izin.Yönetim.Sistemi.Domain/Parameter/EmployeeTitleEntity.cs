#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Base;
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Domain.Parameter
{
    public class EmployeeTitleEntity : BaseEntity<byte>
    {
        #region CTOR

        public EmployeeTitleEntity()
        {
            Employees=new List<EmployeeEntity>();
        }
        #endregion

        #region PROPERTIES
        public string TitleName { get; set; }
        #endregion

        #region NAVIGATION PROPERTIES

        public List<EmployeeEntity> Employees { get; set; }

        #endregion

    }
}
