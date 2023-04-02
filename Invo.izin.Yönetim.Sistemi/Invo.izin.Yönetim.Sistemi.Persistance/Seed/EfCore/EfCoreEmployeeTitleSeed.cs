#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Parameter;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Seed.EfCore
{
    public class EfCoreEmployeeTitleSeed : IEntityTypeConfiguration<EmployeeTitleEntity>
    {
        #region CTOR
        public EfCoreEmployeeTitleSeed()
        {

        }
        #endregion

        #region METHODS
        public void Configure(EntityTypeBuilder<EmployeeTitleEntity> builder)
        {
            builder.HasData(
                       new EmployeeTitleEntity { Id = 1, Title = "Müdür" },
                       new EmployeeTitleEntity { Id = 2, Title = "Şef" },
                       new EmployeeTitleEntity { Id = 3, Title = "Uzman" },
                       new EmployeeTitleEntity { Id = 4, Title = "Stajyer" },
                       new EmployeeTitleEntity { Id = 5, Title = "Genel Müdür" },
                       new EmployeeTitleEntity { Id = 6, Title = "CEO" }


                       );
        }
        #endregion
    }
}
