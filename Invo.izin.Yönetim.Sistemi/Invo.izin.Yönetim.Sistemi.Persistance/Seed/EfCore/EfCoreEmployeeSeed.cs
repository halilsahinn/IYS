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
                       new EmployeeEntity
                       {
                           Id = 1,
                           EmployeeName = "Halil",
                           EmployeeSurName = "ŞAHİN",
                           UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                           DepartmentId = 1,
                           TitleId = 1,
                           BranchOfficeId = 1,
                           IsHead = true,
                           LeavePermissionLevelId = 1


                       },
                       new EmployeeEntity
                        {
                            Id = 2,
                            EmployeeName = "Ali",
                            EmployeeSurName = "ŞAHİN",
                            UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9",
                            DepartmentId = 2,
                            TitleId = 2,
                            BranchOfficeId = 2,
                            IsHead = false,
                            LeavePermissionLevelId = 2


                        }

                       );
        }

        #endregion
    }
}
