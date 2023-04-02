#region NAMESPACES
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Identity.Configurations
{
    public class UserTokenConfiguration : IEntityTypeConfiguration<IdentityUserToken<string>>
    {
        #region METHODS
        public void Configure(EntityTypeBuilder<IdentityUserToken<string>> builder)
        {
            #region PROPERTIES



            #endregion

            #region RELATIONS


            #endregion

            #region TABLE & SCHEME

            builder.ToTable("UserTokens", "Identity");

            #endregion
        }
        #endregion

    }
}
