using Microsoft.Extensions.Caching.Memory;

namespace Service.Caching
{
    public class StaticCacheManager : IStaticCacheManager
    {
        
        #region Fields
        // Flag: Has Dispose already been called?
        private bool _disposed;
        private readonly IMemoryCache memoryCache;
        private int _defaultAbsoluteExpirationSeconds = 3600;
        private CacheItemPriority _defaultCacheItemPriority = CacheItemPriority.Normal;
        private int _defaultSlidingExpirationSettings = 3600;
        #endregion
        #region ctor
        public StaticCacheManager(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }
        #endregion
        #region Methods
        public T Get<T>(string cacheKey, Func<T> acquire)
        {
            if(!memoryCache.TryGetValue(cacheKey, out T result))
            {
                result = acquire();
                if (result != null)
                    Set(cacheKey, result);
            }
            return result;
        }

        public T Get<T>(string cacheKey, MemoryCacheEntryOptions memoryCacheEntryOptions, Func<T> acquire)
        {
            if (memoryCache.TryGetValue(cacheKey, out T result))
                return result;

            result = acquire();

            if (result != null)
                Set(cacheKey, result, memoryCacheEntryOptions);

            return result;
        }

        public MemoryCacheEntryOptions PrepareEntryOptions(int absoluteExpirationSeconds, CacheItemPriority cacheItemPriority, int slidingExpirationSettings)
        {
            var cacheExpiryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddSeconds(absoluteExpirationSeconds),
                Priority = cacheItemPriority,
                SlidingExpiration = TimeSpan.FromSeconds(slidingExpirationSettings)
            };
            return cacheExpiryOptions;
        }

        public string PrepareCacheKey(string cacheKey, params object[] keyObjects)
        {
            cacheKey = string.Format(cacheKey, keyObjects.ToArray());
            return cacheKey;
        }

        public Task ClearCacheByKey(string cacheKey, params object[] keyObjects)
        {
            cacheKey = PrepareCacheKey(cacheKey, keyObjects);
            memoryCache.Remove(cacheKey);
            return Task.CompletedTask;
        }

        public MemoryCacheEntryOptions PrepareDefaultEntryOptions()
        {
            var cacheExpiryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddSeconds(_defaultAbsoluteExpirationSeconds),
                Priority = _defaultCacheItemPriority,
                SlidingExpiration = TimeSpan.FromSeconds(_defaultSlidingExpirationSettings)
            };
            return cacheExpiryOptions;
        }

        public void Set(string cacheKey, object data, MemoryCacheEntryOptions memoryCacheEntryOptions = null)
        {
            if (memoryCacheEntryOptions == null)
                memoryCache.Set(cacheKey, data, PrepareDefaultEntryOptions());
            else
                memoryCache.Set(cacheKey, data, memoryCacheEntryOptions);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
                memoryCache.Dispose();

            _disposed = true;
        }
        #endregion
    }
}
