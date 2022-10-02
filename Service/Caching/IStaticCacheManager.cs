using Microsoft.Extensions.Caching.Memory;

namespace Service.Caching
{
    public interface IStaticCacheManager
    {
        T Get<T>(string cacheKey, Func<T> acquire);
        T Get<T>(string cacheKey, MemoryCacheEntryOptions memoryCacheEntryOptions, Func<T> acquire);
        MemoryCacheEntryOptions PrepareEntryOptions(int absoluteExpirationSeconds, CacheItemPriority cacheItemPriority, int slidingExpirationSettings);
        string PrepareCacheKey(string cacheKey, params object[] keyObjects);
        Task ClearCacheByKey(string cacheKey, params object[] keyObjects);
        void Dispose();
    }
}
