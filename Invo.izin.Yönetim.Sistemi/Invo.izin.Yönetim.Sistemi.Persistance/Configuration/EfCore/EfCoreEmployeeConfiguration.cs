#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using Invo.izin.Yönetim.Sistemi.Persistance.Constant;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Configuration.EfCore
{
    public class EfCoreEmployeeConfiguration : IEntityTypeConfiguration<EmployeeEntity>
    {
        public void Configure(EntityTypeBuilder<EmployeeEntity> builder)
        {
            #region PROPERTIES

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnOrder(1);


            builder.Property(p => p.EmployeeName).HasColumnName("EmployeeName").HasColumnOrder(2).IsRequired().HasMaxLength(20).HasColumnOrder(2); ;
            builder.Property(p => p.EmployeeSurName).HasColumnName("EmployeeSurName").HasColumnOrder(2).IsRequired().HasMaxLength(15).HasColumnOrder(3); ;


            builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").HasColumnOrder(4);
            builder.Property(p => p.UpdatedDate).HasColumnName("UpatedDate").HasColumnOrder(5);

            builder.Property(p => p.Description).HasColumnName("Description").HasColumnOrder(6).HasMaxLength(500);
            builder.Property(p => p.IsActive).HasColumnName("IsActive").HasColumnOrder(7);

            #endregion

            #region RELATIONS



            #endregion

            #region TABLE & SCHEME

            builder.ToTable(DatabaseTableConstant.Employee, DatabaseSchemasConstant.Hr);

            #endregion
        }

    }
}
