#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Contracts.Redis;
using Invo.izin.Yönetim.Sistemi.Caching.Configuration;
using Newtonsoft.Json;
using StackExchange.Redis;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Caching.Redis
{
    public class RedisManager : IRedisService
    {
        #region FIELDS

        private IDatabase _db;


        #endregion

        #region CTOR
        public RedisManager()
        {
            ConfigureRedis();
        }
        #endregion

        #region METHODS

        private void ConfigureRedis()
        {
            _db = ConnectionHelper.Connection.GetDatabase();
        }
        public T GetData<T>(string key)
        {
            var value = _db.StringGet(key);
            if (!string.IsNullOrEmpty(value))
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            return default;
        }
        public bool SetData<T>(string key, T value, DateTimeOffset expirationTime)
        {
            TimeSpan expiryTime = expirationTime.DateTime.Subtract(DateTime.Now);
            var isSet = _db.StringSet(key, JsonConvert.SerializeObject(value), expiryTime);
            return isSet;
        }
        public object RemoveData(string key)
        {
            bool _isKeyExist = _db.KeyExists(key);
            if (_isKeyExist == true)
            {
                return _db.KeyDelete(key);
            }
            return false;
        }

        #endregion

    }

    #region HELPER
    public class ConnectionHelper : RedisConfiguration
    {
        static ConnectionHelper()
        {
            ConnectionHelper.lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
            {
                return ConnectionMultiplexer.Connect(RedisURL);
            });
        }
        private static Lazy<ConnectionMultiplexer> lazyConnection;
        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }
    }

    #endregion

}
