using Learun.Util;
using System.Data;
using Learun.Application.TwoDevelopment.LR_ReportTest;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Learun.Application.Web.Areas.LR_ReportTest.Controllers
{
    /// <summary>


    /// 创 建：超级管理员
    /// 日 期：2018-10-15 11:34
    /// 测试CRM报表
    /// </summary>
    public class TestCRMReportController : MvcControllerBase
    {
        private TestCRMReportIBLL testCRMReportIBLL = new TestCRMReportBLL();

        #region  视图功能

        /// <summary>
        /// 主页面
        /// <summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
             return View();
        }
        /// <summary>
        /// 表单页
        /// <summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Form()
        {
             return View();
        }
        #endregion

        #region  获取数据

        /// <summary>
        /// 获取页面显示列表数据
        /// <summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        [HttpGet]
        [AjaxOnly]
        public ActionResult GetList(string queryJson)
        {
            var data = testCRMReportIBLL.GetList(queryJson);
            return Success(data);
        }
        #endregion

    }
}
