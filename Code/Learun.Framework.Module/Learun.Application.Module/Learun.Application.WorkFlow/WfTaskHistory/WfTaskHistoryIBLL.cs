﻿using System.Collections.Generic;

namespace Learun.Application.WorkFlow
{
    /// <summary>



    /// 日 期：2017.04.17
    /// 任务实例处理记录
    /// </summary>
    public interface WfTaskHistoryIBLL
    {
        #region  获取数据
        /// <summary>
        /// 获取流程实例
        /// </summary>
        /// <param name="processId">流程实例主键</param>
        /// <returns></returns>
        IEnumerable<WfTaskHistoryEntity> GetList(string processId);
        #endregion

        #region  提交数据
        /// <summary>
        /// 保存流程实例任务处理完记录
        /// </summary>
        /// <param name="entity">实体</param>
        void SaveEntity(WfTaskHistoryEntity entity);
        #endregion
    }
}
