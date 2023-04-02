#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Parameter;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Persistance.Seed.EfCore
{
    public class EfLeaveTypeSeed : IEntityTypeConfiguration<LeaveTypeEntity>
    {
        #region CTOR
        public EfLeaveTypeSeed()
        {

        }
        #endregion

        #region METHODS
        public void Configure(EntityTypeBuilder<LeaveTypeEntity> builder)
        {
            builder.HasData(
                       new LeaveTypeEntity { Id = 1, LeaveTypeName = "Yıllık İzin"},
                       new LeaveTypeEntity { Id = 2, LeaveTypeName = "Süt İzni"},
                       new LeaveTypeEntity { Id = 3, LeaveTypeName = "Mazeret İzni"},
                       new LeaveTypeEntity { Id = 4, LeaveTypeName = "Doğum Sonrası İzin"},
                       new LeaveTypeEntity { Id = 5, LeaveTypeName = "Evilik İzni"},
                       new LeaveTypeEntity { Id = 6, LeaveTypeName = "Hastalık İzni"},
                       new LeaveTypeEntity { Id = 7, LeaveTypeName = "Askerlik"},
                       new LeaveTypeEntity { Id = 9, LeaveTypeName = "Ücretsiz İzin" },
                       new LeaveTypeEntity { Id = 10, LeaveTypeName = "Taşınma İzni" },
                       new LeaveTypeEntity { Id = 11, LeaveTypeName = "Devamsızlık" },
                       new LeaveTypeEntity { Id = 12, LeaveTypeName = "Hizmete Ara Verme" },
                       new LeaveTypeEntity { Id = 13, LeaveTypeName = "Zorunluluk Hali" },
                       new LeaveTypeEntity { Id = 14, LeaveTypeName = "Yol İzni" },
                       new LeaveTypeEntity { Id = 15, LeaveTypeName = "Mesai İzni" },
                       new LeaveTypeEntity { Id = 16, LeaveTypeName = "İş Aktivitesi" }

                       );
        }
        #endregion


    }
}
