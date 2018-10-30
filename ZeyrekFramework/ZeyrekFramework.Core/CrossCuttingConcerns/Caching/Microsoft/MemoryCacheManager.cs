using System;
using System.Linq;
using System.Runtime.Caching;
using System.Text.RegularExpressions;

namespace ZeyrekFramework.Core.CrossCuttingConcerns.Caching.Microsoft
{
    public class MemoryCacheManager : ICacheManager
    {
        protected ObjectCache Cache => MemoryCache.Default;

        public T Get<T>(string key)
        {
            return (T)Cache[key];
        }

        public void Add(string key, object data, int cacheTime = 60)
        {
            if (data == null)
            {
                return;
            }

            var policy = new CacheItemPolicy { AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime) };
            Cache.Add(new CacheItem(key, data), policy);
        }

        public bool IsAdd(string key)
        {
            return Cache.Contains(key);
        }

        public void Remove(string key)
        {
            Cache.Remove(key);
        }

        public void RemoveByPattern(string pattern)
        {
            var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var keysToRemove = Cache.Where(d => regex.IsMatch(d.Key)).Select(d => d.Key).ToList();

            foreach (var key in keysToRemove)
            {
                Remove(key);
            }
        }

        public void Clear()
        {
            foreach (var item in Cache)
            {
                Remove(item.Key);
            }
        }
        //public static Lazy<ConnectionMultiplexer> LazyConnection { get; } = new Lazy<ConnectionMultiplexer>(() =>
        //{
        //    string cacheConnection = ConfigurationManager.AppSettings["CacheConnection"].ToString();
        //    return ConnectionMultiplexer.Connect(cacheConnection);
        //});

        //public static ConnectionMultiplexer Connection
        //{
        //    get
        //    {
        //        return LazyConnection.Value;
        //    }
        //}
        //IDatabase _cache = LazyConnection.Value.GetDatabase();

        //public T Get<T>()
        //{
        //    return (T) _cache;
        //}
        //public void Add(string key, object data, int cacheTime = 60)
        //{
        //    if (data == null)
        //    {
        //        return; 
        //    }

        //    _cache.StringSet(key, JsonConvert.SerializeObject(data), TimeSpan.FromMinutes(cacheTime));  
        //}

        //public bool IsAdd(string key)
        //{
        //    return _cache.KeyExists(key);
        //}
        //public void RemoveByPattern(string pattern)
        //{
        //    var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
        //    _cache.KeyDelete(regex.ToString());
        //}
        //public void Remove(string key)
        //{
        //    _cache.KeyDelete(key);
        //}


    }
}
