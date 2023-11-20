using EduManage.Api.Infrastructure.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Api.Infrastructure.Services
{
    public class RedisCacheService : IRedisCacheService
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;

        public RedisCacheService(IConnectionMultiplexer connectionMultiplexer)
        {
            _connectionMultiplexer = connectionMultiplexer;
        }

        public async Task<string> GetCachedValueAsync(string key)
        {
            var db = _connectionMultiplexer.GetDatabase();
            return await db.StringGetAsync(key);
        }

        public async Task SetCacheValueAsync(string key, string value)
        {
            var db = _connectionMultiplexer.GetDatabase();
            await db.StringSetAsync(key, value);
        }

        public async Task<IEnumerable<string>> GetKeysByPrefixAsync(string prefix)
        {
            var keys = new List<string>();

            // Get the Redis server
            var server = _connectionMultiplexer.GetServer(_connectionMultiplexer.GetEndPoints().First());

            // Scan for keys with the specified prefix
            foreach (var key in server.Keys(pattern: prefix + "*"))
            {
                keys.Add(key.ToString());
            }

            return keys;
        }

        public async Task RemoveKeysAsync(IEnumerable<string> keys)
        {
            // Get the Redis database
            var db = _connectionMultiplexer.GetDatabase();

            // Delete the specified keys
            foreach (var key in keys)
            {
                await db.KeyDeleteAsync(key);
            }
        }
    }
}
