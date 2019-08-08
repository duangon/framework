using Learun.Cache.Base;
using Learun.Cache.Factory;
using Xq.SpireHelper;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Diagnostics;

namespace Learun.Application.Web
{
    /// <summary>
    /// 应用程序全局设置
    /// </summary>
    public class MvcApplication : HttpApplication
    {
        /// <summary>
        /// 启动应用程序
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            // 启动的时候清除全部缓存
            ICache cache = CacheFactory.CaChe();
            cache.RemoveAll(0);
            cache.RemoveAll(1);
            cache.RemoveAll(2);

            cache.RemoveAll(5);
            cache.RemoveAll(6);
            ModifyInMemory.ActivateMemoryPatching();
            var actions = ControllerHelper.GetALLPageByReflection();
            foreach (var item in actions)
            {
                Debug.WriteLine(item);
            }
        }

        /// <summary>
        /// 应用程序错误处理
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">EventArgs</param>
        protected void Application_Error(object sender, EventArgs e)
        {
            var lastError = Server.GetLastError();
        }
    }
}
