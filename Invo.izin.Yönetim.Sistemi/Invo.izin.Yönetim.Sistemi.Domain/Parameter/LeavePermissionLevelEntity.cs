#region NAVIGATION PROPERTIES
using Invo.izin.Yönetim.Sistemi.Domain.Base;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Domain.Parameter
{
    public class LeavePermissionLevelEntity : BaseEntity<byte>
    {
        #region CTOR
        public LeavePermissionLevelEntity()
        {

        }
        #endregion

        #region PROPERTIES
        public string Level { get; set; }
        #endregion

    }
}
