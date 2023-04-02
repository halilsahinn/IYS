#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Base;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Domain.Parameter
{
    public class EmployeeTitleEntity : BaseEntity<byte>
    {
        #region PROPERTIES
        public string Title { get; set; }
        #endregion

    }
}
