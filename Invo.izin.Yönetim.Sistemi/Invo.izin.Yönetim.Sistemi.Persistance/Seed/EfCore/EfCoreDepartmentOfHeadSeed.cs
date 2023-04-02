#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Seed.EfCore
{
    public class EfCoreDepartmentOfHeadSeed : IEntityTypeConfiguration<DepartmentOfHeadEntity>
    {
        #region CTOR
        public EfCoreDepartmentOfHeadSeed()
        {

        }
        #endregion

        #region METHODS
        public void Configure(EntityTypeBuilder<DepartmentOfHeadEntity> builder)
        {
            builder.HasData(
                       new DepartmentOfHeadEntity { Id = 1, DepartmentId = 1, EmployeeId = 1, LeavePermissionLevelId = 1 }

                       );
        }

        #endregion
    }
}
