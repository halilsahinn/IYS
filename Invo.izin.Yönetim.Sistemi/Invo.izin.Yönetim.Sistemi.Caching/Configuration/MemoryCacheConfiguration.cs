using Microsoft.Extensions.Caching.Memory;

namespace Invo.izin.Yönetim.Sistemi.Caching.Configuration
{
    public abstract class MemoryCacheConfiguration : MemoryCacheEntryOptions
    {
        public MemoryCacheConfiguration()
        {
            AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(1);
            Priority = CacheItemPriority.High;
        }

    }
}
