#region NAMESPACES
using Microsoft.Extensions.Caching.Memory;
#endregion


namespace Invo.izin.Yönetim.Sistemi.Application.Contracts.MemoryCache
{
    public interface IMemoryCacheService : IDisposable
    {
        ICacheEntry CreateEntry(object key);
        void Remove(object key);
        bool TryGetValue(object key, out object value);
    }
}
