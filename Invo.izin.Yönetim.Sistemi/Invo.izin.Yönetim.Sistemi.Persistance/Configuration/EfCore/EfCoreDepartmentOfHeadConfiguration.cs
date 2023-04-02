#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using Invo.izin.Yönetim.Sistemi.Domain.Parameter;
using Invo.izin.Yönetim.Sistemi.Persistance.Constant;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Configuration.EfCore
{
    public class EfCoreDepartmentOfHeadConfiguration : IEntityTypeConfiguration<DepartmentOfHeadEntity>
    {
        public void Configure(EntityTypeBuilder<DepartmentOfHeadEntity> builder)
        {
            #region PROPERTIES

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnOrder(1);


            builder.Property(p => p.EmployeeId).HasColumnName("EmployeeId").HasColumnOrder(2).IsRequired();
            builder.Property(p => p.DepartmentId).HasColumnName("DepartmentId").HasColumnOrder(3).IsRequired();
            builder.Property(p => p.LeavePermissionLevelId).HasColumnName("LeavePermissionLevelId").HasColumnOrder(4).IsRequired();


            builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").HasColumnOrder(5);
            builder.Property(p => p.UpdatedDate).HasColumnName("UpatedDate").HasColumnOrder(6);

            builder.Property(p => p.Description).HasColumnName("Description").HasColumnOrder(7).HasMaxLength(500);
            builder.Property(p => p.IsActive).HasColumnName("IsActive").HasColumnOrder(8);

            #endregion

            #region RELATIONS



            #endregion

            #region TABLE & SCHEME

            builder.ToTable(DatabaseTableConstant.DepartmentOfHead, DatabaseSchemasConstant.Hr);

            #endregion
        }

    }
}
