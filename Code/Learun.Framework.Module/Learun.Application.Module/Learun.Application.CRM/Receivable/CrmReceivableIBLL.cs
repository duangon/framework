﻿using Learun.Util;
using System.Collections.Generic;

namespace Learun.Application.CRM
{
    /// <summary>


    /// 创 建：超级管理员
    /// 日 期：2017-07-11 14:48
    /// 应收账款
    /// </summary>
    public interface CrmReceivableIBLL
    {
        #region  获取数据
        /// <summary>
        /// 获取收款单列表
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns>返回分页列表</returns>
        IEnumerable<CrmOrderEntity> GetPaymentPageList(Pagination pagination, string queryJson);
        /// <summary>
        /// 获取收款记录列表
        /// </summary>
        /// <param name="orderId">订单主键</param>
        /// <returns></returns>
        IEnumerable<CrmReceivableEntity> GetPaymentRecord(string orderId);
        #endregion

        #region  提交数据
        /// <summary>
        /// 保存表单（新增）
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        void SaveEntity(CrmReceivableEntity entity);
        #endregion

        #region  报表
        /// <summary>
        /// 获取收款列表
        /// </summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns>返回列表</returns>
        IEnumerable<ReceivableReportModel> GetReportList(string queryJson);
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns>返回分页列表</returns>
        IEnumerable<ReceivableReportModel> GetReportPageList(Pagination pagination, string queryJson);
        #endregion
    }
}
