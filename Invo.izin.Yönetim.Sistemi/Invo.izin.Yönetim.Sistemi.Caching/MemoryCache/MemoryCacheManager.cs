#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.MemoryCache;
using Invo.izin.Yönetim.Sistemi.Caching.Configuration;
using Microsoft.Extensions.Caching.Memory;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Caching.MemoryCache
{
    public class MemoryCacheManager : MemoryCacheConfiguration, IMemoryCacheService
    {
        #region FIELDS
        private readonly IMemoryCacheService _memoryCache;
        #endregion

        #region CTOR
        public MemoryCacheManager(IMemoryCacheService memoryCache) => _memoryCache = memoryCache;
        #endregion

        #region METHODS
        public ICacheEntry CreateEntry(object key)
        {
            return _memoryCache.CreateEntry(key);
        }

        public void Dispose()
        {
            _memoryCache.Dispose();
        }

        public void Remove(object key)
        {
            _memoryCache.Remove(key);
        }

        public bool TryGetValue(object key, out object value)
        {
            return _memoryCache.TryGetValue(key, out value);
        }
        #endregion
    }
}
