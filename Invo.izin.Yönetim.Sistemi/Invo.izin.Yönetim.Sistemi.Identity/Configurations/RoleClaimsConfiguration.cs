#region NAMESPACES
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Identity.Configurations
{
    public class RoleClaimsConfiguration : IEntityTypeConfiguration<IdentityRoleClaim<string>>
    {
        #region METHODS
        public void Configure(EntityTypeBuilder<IdentityRoleClaim<string>> builder)
        {
            #region PROPERTIES



            #endregion

            #region RELATIONS


            #endregion

            #region TABLE & SCHEME

            builder.ToTable("RoleClaims", "Identity");

            #endregion
        }

        #endregion

    }
}
