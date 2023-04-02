#region NAMESPACES

#endregion

namespace Invo.izin.Yönetim.Sistemi.Domain.Base
{
    public abstract class BaseEntity<TIdentity>
    {

        #region CTOR
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            IsActive = true;
        }
        #endregion

        #region PROPERTIES
        public TIdentity Id { get; set; }

        public bool IsActive { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        #endregion


    }
}
