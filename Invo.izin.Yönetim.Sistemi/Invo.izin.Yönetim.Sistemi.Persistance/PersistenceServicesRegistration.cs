#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Constants;
using Invo.izin.Yönetim.Sistemi.Persistance.Contex;
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


         


            return services;
        }


    }
}
