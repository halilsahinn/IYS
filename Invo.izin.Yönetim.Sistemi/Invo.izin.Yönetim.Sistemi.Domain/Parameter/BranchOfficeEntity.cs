#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Base;
#endregion

namespace Invo.izin.Yönetim.Sistemi.Domain.Parameter
{
    public class BranchOfficeEntity : BaseEntity<byte>
    {
        #region PROPERTIES
        public string BranchOfficeName { get; set; }
        #endregion

    }
}
