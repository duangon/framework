﻿using Learun.Util;
using System.Collections.Generic;

namespace Learun.Application.OA.Gantt
{
    /// <summary>
    /// 版 本 Learun-ADMS-Ultimate V7.0.0 力软敏捷开发框架
    /// Copyright (c) 2013-2017 

    /// 日 期：2018.06.20
    /// 项目计划
    /// </summary>
    public interface JQueryGanttIBLL
    {
        #region  获取数据
        /// <summary>
        /// 获取甘特图数据
        /// </summary>
        /// <param name="queryJson">关键词</param>
        /// <returns></returns>
        IEnumerable<JQueryGanttEntity> GetList(string queryJson);
        /// <summary>
        /// 获取甘特图实体
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        JQueryGanttEntity GetEntity(string keyValue);

        #endregion

        #region  提交数据
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="keyValue">主键</param>
        void DeleteEntity(string keyValue);
        /// <summary>
        /// 保存（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="entity">甘特图实体</param>
        /// <returns></returns>
        void SaveEntity(string keyValue, JQueryGanttEntity entity);
        #endregion
    }
}