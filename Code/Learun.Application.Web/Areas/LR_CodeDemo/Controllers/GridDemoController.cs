using System.Web.Mvc;

namespace Learun.Application.Web.Areas.LR_CodeDemo.Controllers
{
    /// <summary>



    /// 日 期：2018.04.12
    /// 附件管理
    /// </summary>
    public class GridDemoController : MvcControllerBase
    {
        /// <summary>
        /// 普通表格
        /// </summary>
        /// <returns></returns>
        public ActionResult CommonIndex()
        {
            return View();
        }


        /// <summary>
        /// 编辑表格
        /// </summary>
        /// <returns></returns>
        public ActionResult EditIndex()
        {
            return View();
        }

        /// <summary>
        /// 报表表格
        /// </summary>
        /// <returns></returns>
        public ActionResult ReportIndex()
        {
            return View();
        }
    }
}