#region NAMESPACES
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Identity.Configurations
{
    public class UserLoginConfiguration : IEntityTypeConfiguration<IdentityUserLogin<string>>
    {
        #region METHODS
        public void Configure(EntityTypeBuilder<IdentityUserLogin<string>> builder)
        {
            #region PROPERTIES



            #endregion

            #region RELATIONS


            #endregion

            #region TABLE & SCHEME

            builder.ToTable("UserLogins", "Identity");

            #endregion

        }

        #endregion
    }
}
