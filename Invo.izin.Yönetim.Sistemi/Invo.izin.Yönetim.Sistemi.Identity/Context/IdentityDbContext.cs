#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Identity.Configurations;
using Invo.izin.Yönetim.Sistemi.Identity.Models;
using Invo.izin.Yönetim.Sistemi.Identity.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Identity.Context
{
    public class IdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        #region CTOR
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
                  : base(options)
        {
        }

        #endregion

        #region METHODS
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            #region SEEDS

            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new UserRoleSeed());

            #endregion

            #region CONFIGURATION
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserClaimsConfiguration());
            modelBuilder.ApplyConfiguration(new UserLoginConfiguration());
            modelBuilder.ApplyConfiguration(new RoleClaimsConfiguration());
            modelBuilder.ApplyConfiguration(new UserTokenConfiguration());

            #endregion

        }
        #endregion
    }
}
