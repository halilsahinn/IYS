#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Parameter;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Persistance.Seed.EfCore
{
    public class EfCoreLeavePermissionLevelSeed : IEntityTypeConfiguration<LeavePermissionLevelEntity>
    {
        #region CTOR
        public EfCoreLeavePermissionLevelSeed()
        {

        }
        #endregion

        #region METHODS
        public void Configure(EntityTypeBuilder<LeavePermissionLevelEntity> builder)
        {
            builder.HasData(
                       new LeavePermissionLevelEntity
                       {
                           Id = 1,
                          Level="Birinci Seviye"
                       },
                       new LeavePermissionLevelEntity
                       {
                           Id = 2,
                           Level = "İkinci Seviye"
                       },
                       new LeavePermissionLevelEntity
                       {
                           Id = 3,
                           Level = "Üçüncü Seviye"
                       }

                       );
        }

        #endregion

    }
}
