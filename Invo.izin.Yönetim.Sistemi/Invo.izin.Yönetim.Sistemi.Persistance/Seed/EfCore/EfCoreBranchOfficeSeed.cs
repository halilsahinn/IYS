#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using Invo.izin.Yönetim.Sistemi.Domain.Parameter;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Seed.EfCore
{
    public class EfCoreBranchOfficeSeed : IEntityTypeConfiguration<BranchOfficeEntity>
    {
        #region CTOR
        public EfCoreBranchOfficeSeed()
        {

        }
        #endregion

        #region METHODS
        public void Configure(EntityTypeBuilder<BranchOfficeEntity> builder)
        {
            builder.HasData(
                       new BranchOfficeEntity { Id = 1, BranchOfficeName = "İstanbul"},
                       new BranchOfficeEntity { Id = 2, BranchOfficeName = "Ankara"},
                       new BranchOfficeEntity { Id = 3, BranchOfficeName = "İzmir"}
                      
                       );
        }

        #endregion

    }
}
