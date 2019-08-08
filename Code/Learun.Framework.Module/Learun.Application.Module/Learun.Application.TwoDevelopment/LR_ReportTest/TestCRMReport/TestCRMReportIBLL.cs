using Learun.Util;
using System.Data;
using System.Collections.Generic;

namespace Learun.Application.TwoDevelopment.LR_ReportTest
{
    /// <summary>


    /// 创 建：超级管理员
    /// 日 期：2018-10-15 11:34
    /// 测试CRM报表
    /// </summary>
    public interface TestCRMReportIBLL
    {
        #region  获取数据

        /// <summary>
        /// 获取页面显示列表数据
        /// <summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        DataTable GetList(string queryJson);
    }
}
        #endregion 

