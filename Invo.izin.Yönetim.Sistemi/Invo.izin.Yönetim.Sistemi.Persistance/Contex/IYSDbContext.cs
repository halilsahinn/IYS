#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Persistance.Contex.Base;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Invo.izin.Yönetim.Sistemi.Domain.Employee;
using Invo.izin.Yönetim.Sistemi.Domain.Parameter;
using Invo.izin.Yönetim.Sistemi.Persistance.Configuration.EfCore;
using Invo.izin.Yönetim.Sistemi.Persistance.Seed.EfCore;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance.Contex
{
    public class IYSDbContext : ContextBase
    {

        #region SUMMARY
        /// <summary>
        /// Entitilerin veritabanındaki tablo karşılığı olan sınıf. Bu sınıf contextbase sınıfından miras alır
        /// o ise DbContext  sınıfından miras alır böylelikle ef core'un method larına erişim sağlanır.
        /// dbset tipinde tanımladığımız sınıflar veritabanında sınıflara karşılık gelecek şekilde işaretlenir.
        /// </summary>
        /// <param name="options"></param>

        #endregion

        #region CTOR

        public IYSDbContext(DbContextOptions<IYSDbContext> options) : base(options)
        {

        }


        #endregion

        #region DBSET

        #region MASTER TABLES
        public DbSet<DepartmentEntity> Departments { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }

        #endregion

        #region INTERMEDIATE TABLES
    
        #endregion

        #region PARAMETERS
        public DbSet<BranchOfficeEntity> BranchOffices { get; set; }
        public DbSet<EmployeeTitleEntity> EmployeeTitles { get; set; }
        public DbSet<LeaveTypeEntity> LeaveTypes { get; set; }



        #endregion


        #endregion

        #region METHODS
        /// <summary>
        /// Model Oluşturulurken Ve Konfigürasyonu Yapırlırken ezilen metodlar
        /// </summary>
        /// <param name="modelBuilder">@modelBuilder</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region MAPPING
            modelBuilder.ApplyConfiguration(new EfCoreDepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new EfCoreBranchOfficeConfiguration());
         
            modelBuilder.ApplyConfiguration(new EfCoreEmployeeTitleConfiguration());
            modelBuilder.ApplyConfiguration(new EfCoreLeavePermissionLevelConfiguration());
            modelBuilder.ApplyConfiguration(new EfCoreLeaveRequestConfiguration());
            modelBuilder.ApplyConfiguration(new EfCoreLeaveTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EfCoreEmployeeConfiguration());

            #endregion

            #region SEEDS

            #region PARAMETER
            modelBuilder.ApplyConfiguration(new EfCoreDepartmentSeed());
            modelBuilder.ApplyConfiguration(new EfLeaveTypeSeed());
            modelBuilder.ApplyConfiguration(new EfCoreBranchOfficeSeed());
            modelBuilder.ApplyConfiguration(new EfCoreLeavePermissionLevelSeed());
       
            modelBuilder.ApplyConfiguration(new EfCoreEmployeeTitleSeed());
            modelBuilder.ApplyConfiguration(new EfCoreEmployeeSeed());

            #endregion

            #endregion

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           


        }
         
        #endregion

    }
}
