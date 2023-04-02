#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Seed.EfCore
{
    public class EfCoreEmployeeSeed : IEntityTypeConfiguration<EmployeeEntity>
    {
        #region CTOR
        public EfCoreEmployeeSeed()
        {

        }
        #endregion

        #region METHODS
        public void Configure(EntityTypeBuilder<EmployeeEntity> builder)
        {
            builder.HasData(
                       new EmployeeEntity { Id = 1, 
                           EmployeeName = "Halil",
                           EmployeeSurName="ŞAHİN",
                           BranchOfficeId = 1,
                           LeavePermissionLevelId=1
                       }
                      
                       );
        }

        #endregion
    }
}
