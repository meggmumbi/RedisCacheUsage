using RedisCacheUsage.Application.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisCacheUsage.Infrastracture.Service
{
    public class CacheService : ICacheService
    {
        private IDatabase _db;

        public CacheService()
        {
            ConfigureRedis();
        }

        private void ConfigureRedis()
        {
            _db = ConnectionHelper.Connection.GetDatabase();
        }

        public T GetData<T>(string key)
        {
            throw new NotImplementedException();
        }

        public object RemoveData(string Key)
        {
            throw new NotImplementedException();
        }

        public bool SetData<T>(string Key, T value, DateTimeOffset expirationTime)
        {
            throw new NotImplementedException();
        }
    }


}
