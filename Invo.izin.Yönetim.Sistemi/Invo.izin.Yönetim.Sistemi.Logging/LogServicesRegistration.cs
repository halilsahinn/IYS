#region NAMESPACES
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Logging
{
    public static class LogServicesRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services, IConfiguration iConfig)
        {

            var logger = new LoggerConfiguration()
               .ReadFrom.Configuration(iConfig.GetSection("SeriLog"));
            return services;
        }

    }
}
