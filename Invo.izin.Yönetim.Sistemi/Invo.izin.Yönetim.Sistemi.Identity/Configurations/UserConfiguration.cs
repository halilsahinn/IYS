#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Identity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        #region METHODS
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            #region PROPERTIES

            builder.Property(p => p.UserName).HasColumnName("Name").HasColumnOrder(2).IsRequired().HasMaxLength(50);

            #endregion

            #region RELATIONS



            #endregion

            #region TABLE & SCHEME

            builder.ToTable("User", "Identity");

            #endregion


        }
        #endregion

    }
}
