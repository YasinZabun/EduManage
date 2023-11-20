using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduManage.Api.Infrastructure.Interfaces
{
    public interface IRedisCacheService
    {
        Task<string> GetCachedValueAsync(string key);
        Task SetCacheValueAsync(string key, string value);
        Task<IEnumerable<string>> GetKeysByPrefixAsync(string prefix);
        Task RemoveKeysAsync(IEnumerable<string> keys);
    }
}
