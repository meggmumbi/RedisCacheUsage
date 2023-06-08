using Newtonsoft.Json;
using RedisCacheUsage.Application.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisCacheUsage.WebApi
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
            var value = _db.StringGet(key);
            if(!string.IsNullOrEmpty(value))
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            return default;
        }

        public object RemoveData(string Key)
        {
            bool _isKeyExist = _db.KeyExists(Key);
            if(_isKeyExist==true)
            {
                return _db.KeyDelete(Key);
            }
            return false;
        }

        public bool SetData<T>(string Key, T value, DateTimeOffset expirationTime)
        {
            TimeSpan expiryTime = expirationTime.DateTime.Subtract(DateTime.Now);
            var isSet = _db.StringSet(Key,JsonConvert.SerializeObject(value),expiryTime);
            return isSet;
        }
    }


}
