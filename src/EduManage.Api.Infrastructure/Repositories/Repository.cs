using EduManage.Api.Domain.Interfaces;
using EduManage.Api.Infrastructure.Data;
using EduManage.Api.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EduManage.Api.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;
        private readonly IRedisCacheService _cacheService; // Inject the caching service
        private readonly IConnectionMultiplexer _redisConnection; // Inject the Redis connection

        public Repository(ApplicationDbContext context, IRedisCacheService cacheService, IConnectionMultiplexer redisConnection)
        {
            _context = context;
            _dbSet = context.Set<T>();
            _cacheService = cacheService;
            _redisConnection = redisConnection;
        }

        public async Task<T> GetByIdAsync(string id)
        {
            // Check if data is cached in Redis
            var cacheKey = typeof(T).Name + "_" + id;
            var cachedData = await _cacheService.GetCachedValueAsync(cacheKey);

            if (cachedData != null)
            {
                // Data found in cache, deserialize and return
                return DeserializeFromJson<T>(cachedData);
            }
            try
            {

                // Data not found in cache, fetch from the database
                var entity = await _dbSet.FindAsync(id);

                // Cache the data in Redis
                if (entity != null)
                {
                    await _cacheService.SetCacheValueAsync(cacheKey, SerializeToJson(entity));
                }

                return entity;
            }
            catch (Exception)
            {
                return null;            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            // Check if data is cached in Redis
            var cacheKey = "all_" + typeof(T).Name;
            var cachedData = await _cacheService.GetCachedValueAsync(cacheKey);

            if (cachedData != null)
            {
                // Data found in cache, deserialize and return
                return DeserializeFromJson<IEnumerable<T>>(cachedData);
            }

            // Data not found in cache, fetch from the database
            var data = await _dbSet.ToListAsync();

            // Cache the data in Redis
            await _cacheService.SetCacheValueAsync(cacheKey, SerializeToJson(data));

            return data;
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            // Invalidate cache when adding a new entity
            await InvalidateCache();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChangesAsync();

            // Invalidate cache when updating an entity
            InvalidateCache();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChangesAsync();

            // Invalidate cache when deleting an entity
            InvalidateCache();
        }

        // Other repository methods...

        private string SerializeToJson(object data)
        {
            return JsonSerializer.Serialize(data);
        }

        private T DeserializeFromJson<T>(string jsonData)
        {
            return JsonSerializer.Deserialize<T>(jsonData);
        }

        private async Task InvalidateCache()
        {
            // Implement cache invalidation logic
            // Example: Remove cached data for all entities of type T
            var cacheKeyPrefix = typeof(T).Name + "_";
            var cacheKeysToRemove = await _cacheService.GetKeysByPrefixAsync(cacheKeyPrefix);

            if (cacheKeysToRemove.Any())
            {
                await _cacheService.RemoveKeysAsync(cacheKeysToRemove);
            }
        }
    }
}
