#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.MemoryCache;
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Redis;
using Invo.izin.Yönetim.Sistemi.Caching.Configuration;
using Invo.izin.Yönetim.Sistemi.Caching.MemoryCache;
using Invo.izin.Yönetim.Sistemi.Caching.Redis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Caching
{
    public static class CacheServicesRegistration
    {
        public static IServiceCollection ConfigureCacheServices(this IServiceCollection services, IConfiguration configuration)
        {

            //services.AddMemoryCache();
            //services.AddTransient<IMemoryCacheService, MemoryCacheManager>();
           
             
            services.AddSingleton<IRedisService, RedisManager>();

            

            return services;

        }

    }
}
