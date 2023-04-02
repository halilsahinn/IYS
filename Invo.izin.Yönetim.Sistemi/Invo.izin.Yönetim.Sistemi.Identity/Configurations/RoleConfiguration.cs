#region NAMESPACES
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        #region METHODS
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            #region PROPERTIES

            builder.Property(p => p.Name).HasColumnName("Name").HasColumnOrder(2).IsRequired().HasMaxLength(150);

            #endregion

            #region RELATIONS



            #endregion

            #region TABLE & SCHEME

            builder.ToTable("Role", "Identity");

            #endregion


        }
        #endregion

    }
}
