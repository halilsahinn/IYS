#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Base;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Domain.Parameter
{
    public class LeaveTypeEntity : BaseEntity<byte>
    {
        #region PROPERTIES
        public string LeaveTypeName { get; set; }
      

        #endregion

    }
}
