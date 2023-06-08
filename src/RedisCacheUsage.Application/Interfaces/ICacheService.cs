using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisCacheUsage.Application.Interfaces
{
    public interface ICacheService
    {

        /// <summery>
        /// Get Data using key
        /// </summery>
        /// <typeparam name="T"></typeparam>
        /// <param name="Key"></param>
        /// <returns></returns>
        
        T GetData<T>(string key);

        /// <summary>
        /// Set Data with value and expiration Time of key
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Key"></param>
        /// <param name="value"></param>
        /// <param name="expirationTime"></param>
        /// <returns></returns>

        bool SetData<T>(string Key, T value, DateTimeOffset expirationTime);

        /// <summary>
        /// Remove Data
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        
        object RemoveData(string Key);

    }
}
