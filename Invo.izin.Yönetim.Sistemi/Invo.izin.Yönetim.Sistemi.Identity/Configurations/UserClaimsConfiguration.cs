#region NAMESPACES
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Identity.Configurations
{
    public class UserClaimsConfiguration : IEntityTypeConfiguration<IdentityUserClaim<string>>
    {
        #region METHODS
        public void Configure(EntityTypeBuilder<IdentityUserClaim<string>> builder)
        {
            #region PROPERTIES

            builder.Property(p => p.Id).HasColumnName("Name").HasColumnOrder(2).IsRequired().HasMaxLength(50);

            #endregion

            #region RELATIONS


            #endregion

            #region TABLE & SCHEME

            builder.ToTable("UserClaims", "Identity");

            #endregion

        }

        #endregion

    }
}
