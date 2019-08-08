using System.Web.Mvc;

namespace Learun.Application.Web.Areas.LR_CodeGeneratorModule.Controllers
{
    /// <summary>




    /// JS插件Demo
    /// </summary>
    public class PluginDemoController : MvcControllerBase
    {
        #region  视图功能
        /// <summary>
        /// JS插件展示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        #endregion
        
    }
}