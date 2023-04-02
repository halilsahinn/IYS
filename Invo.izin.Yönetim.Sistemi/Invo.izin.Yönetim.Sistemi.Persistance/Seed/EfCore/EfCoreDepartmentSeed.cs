#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using Invo.izin.Yönetim.Sistemi.Domain.Parameter;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Seed.EfCore
{
    public class EfCoreDepartmentSeed : IEntityTypeConfiguration<DepartmentEntity>
    {
        #region CTOR
        public EfCoreDepartmentSeed()
        {

        }
        #endregion

        #region METHODS
        public void Configure(EntityTypeBuilder<DepartmentEntity> builder)
        {
            builder.HasData(
                       new DepartmentEntity { Id = 1, DepartmentName = "Bilgi İşlem", Description = "" },
                       new DepartmentEntity { Id = 2, DepartmentName = "Finans", Description = "" },
                       new DepartmentEntity { Id = 3, DepartmentName = "Muhasebe", Description = "" },
                       new DepartmentEntity { Id = 4, DepartmentName = "Satış / Pazarlama", Description = "" },
                       new DepartmentEntity { Id = 5, DepartmentName = "Sevkiyat", Description = "" },
                       new DepartmentEntity { Id = 6, DepartmentName = "Üretim", Description = "" },
                       new DepartmentEntity { Id = 7, DepartmentName = "Hukuk", Description = "" },
                       new DepartmentEntity { Id = 8, DepartmentName = "Halkla İlişkiler", Description = "" },
                       new DepartmentEntity { Id = 9, DepartmentName = "İnsan Kaynakları", Description = "" },
                       new DepartmentEntity { Id = 10, DepartmentName = "Ar-Ge", Description = "" }
                       );
        }

        #endregion
    }
}
