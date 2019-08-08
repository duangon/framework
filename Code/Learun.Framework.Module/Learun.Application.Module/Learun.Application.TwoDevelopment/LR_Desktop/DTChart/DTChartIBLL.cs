﻿using Learun.Util;
using System.Data;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Learun.Application.TwoDevelopment.LR_Desktop
{
    /// <summary>


    /// 创 建：超级管理员
    /// 日 期：2018-09-25 11:32
    /// 图标配置
    /// </summary>
    public interface DTChartIBLL
    {
        #region  获取数据

        /// <summary>
        /// 获取页面显示列表数据
        /// <summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        IEnumerable<DTChartEntity> GetPageList(Pagination pagination, string queryJson);
        /// <summary>
        /// 获取LR_DT_Chart表实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        DTChartEntity GetLR_DT_ChartEntity(string keyValue);
        #endregion

        #region  提交数据

        /// <summary>
        /// 删除实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        void DeleteEntity(string keyValue);
        /// <summary>
        /// 保存实体数据（新增、修改）
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        void SaveEntity(string keyValue, DTChartEntity entity);
        List<NameValueCollection> GetSqlData(string id);
        #endregion

    }
}
