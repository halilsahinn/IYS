#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Leave;
using Invo.izin.Yönetim.Sistemi.Persistance.Constant;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Configuration.EfCore
{
    public class EfCoreLeaveRequestConfiguration : IEntityTypeConfiguration<LeaveRequestEntity>
    {
        public void Configure(EntityTypeBuilder<LeaveRequestEntity> builder)
        {
            #region PROPERTIES

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnOrder(1);


            builder.Property(p => p.StartedDate).HasColumnName("StartedDate").HasColumnOrder(2).IsRequired();
            builder.Property(p => p.FinishedDate).HasColumnName("FinishedDate").HasColumnOrder(3).IsRequired();


            builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").HasColumnOrder(4);
            builder.Property(p => p.UpdatedDate).HasColumnName("UpatedDate").HasColumnOrder(5);

            builder.Property(p => p.Description).HasColumnName("Description").HasColumnOrder(6).HasMaxLength(500);
            builder.Property(p => p.IsActive).HasColumnName("IsActive").HasColumnOrder(7);

            #endregion

            #region RELATIONS



            #endregion

            #region TABLE & SCHEME

            builder.ToTable(DatabaseTableConstant.LeaveRequest, DatabaseSchemasConstant.Hr);

            #endregion
        }
    }
}
