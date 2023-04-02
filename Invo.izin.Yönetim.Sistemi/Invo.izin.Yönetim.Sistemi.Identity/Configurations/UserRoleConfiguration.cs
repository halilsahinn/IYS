#region NAMESPACES
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        #region METHODS
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            #region PROPERTIES



            #endregion

            #region RELATIONS



            #endregion

            #region TABLE & SCHEME

            builder.ToTable("UserRoles", "Identity");

            #endregion
        }

        #endregion

    }
}
