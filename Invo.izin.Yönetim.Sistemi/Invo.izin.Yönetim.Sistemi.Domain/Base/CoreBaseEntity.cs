namespace Invo.izin.Yönetim.Sistemi.Domain.Base
{
    public abstract class CoreBaseEntity
    {
        #region CTOR
        public CoreBaseEntity()
        {
            CreatedDate = DateTime.Now;
            IsActive = true;
        }
        #endregion

        #region PROPERTIES
         
        public bool IsActive { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        #endregion
    }
}
