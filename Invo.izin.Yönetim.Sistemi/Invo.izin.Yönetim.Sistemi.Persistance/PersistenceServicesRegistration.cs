#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Constants;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.DapperRepositories;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Base;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.Parameter;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Repositories.User;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.UnitOfWork;
using Invo.izin.Yönetim.Sistemi.Persistance.Contex;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.Dapper;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore.Base;
using Invo.izin.Yönetim.Sistemi.Persistance.Repositories.EfCore.Parameter;
using Invo.izin.Yönetim.Sistemi.Persistance.Uow;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection.Metadata;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Persistance
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<IYSDbContext>(options =>
            options.UseSqlServer(

             GlobalConstant.Database.CONNECTION_STRING
            
             ));

            services.AddScoped(typeof(IGenericBaseRepository<>), typeof(EfGenericBaseRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IDepartmentService, EfDepartmentRepository>();
            services.AddScoped<IEmployeeService, EfEmployeeRepository>();
            services.AddScoped<ILeaveRequestService, EfLeaveRequestRepository>();
            services.AddScoped<IBranchOfficeService, EfBranchOfficeRepository>();
            services.AddScoped<IEmployeeTitleService, EfEmployeeTitleRepository>();
            


            services.AddScoped<IDpUserService, DpUserRepository>();
            services.AddScoped<IDpDepartmentService, DpDepartmentRepository>();
            services.AddScoped<IDpEmployeeTitleService, DpEmployeeTitleRepository>();
            services.AddScoped<IDpBranchOfficeService, DpBranchOfficeRepository>();
            services.AddScoped<IDpLeaveRequestService, DpLeaveRequestRepository>();



            return services;
        }


    }
}
