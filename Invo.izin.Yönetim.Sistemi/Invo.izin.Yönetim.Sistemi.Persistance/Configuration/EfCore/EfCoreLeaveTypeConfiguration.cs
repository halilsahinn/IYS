#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Parameter;
using Invo.izin.Yönetim.Sistemi.Persistance.Constant;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Configuration.EfCore
{
    public class EfCoreLeaveTypeConfiguration : IEntityTypeConfiguration<LeaveTypeEntity>
    {
        public void Configure(EntityTypeBuilder<LeaveTypeEntity> builder)
        {
            #region PROPERTIES

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnOrder(1);


            builder.Property(p => p.LeaveTypeName).HasColumnName("LeaveTypeName").HasColumnOrder(2).IsRequired().HasMaxLength(50);


            builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").HasColumnOrder(3);
            builder.Property(p => p.UpdatedDate).HasColumnName("UpatedDate").HasColumnOrder(4);

            builder.Property(p => p.Description).HasColumnName("Description").HasColumnOrder(5).HasMaxLength(500);
            builder.Property(p => p.IsActive).HasColumnName("IsActive").HasColumnOrder(6);

            #endregion

            #region RELATIONS



            #endregion

            #region TABLE & SCHEME

            builder.ToTable(DatabaseTableConstant.LeaveType, DatabaseSchemasConstant.Hr);

            #endregion
        }
    }
}
