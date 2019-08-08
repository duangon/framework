using Learun.Cache.Base;
using Learun.Cache.Redis;

namespace Learun.Cache.Factory
{
    /// <summary>



    /// 日 期：2017.03.06
    /// 定义缓存工厂类
    /// </summary>
    public class CacheFactory
    {
        public static ICache CaChe()
        {
            return new CacheByRedis();
        }
    }
}
