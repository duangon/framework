﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Learun.Application.WorkFlow
{
    /// <summary>



    /// 日 期：2017.04.17
    /// 工作流委托规则与工作流模板关联规则
    /// </summary>
    public class WfDelegateRuleRelationEntity
    {
        #region  实体成员
        /// <summary>
        /// 主键
        /// </summary>
        /// <returns></returns>
        [Column("F_ID")]
        public string F_Id { get; set; }
        /// <summary>
        /// 委托规则主键
        /// </summary>
        /// <returns></returns>
        [Column("F_DELEGATERULEID")]
        public string F_DelegateRuleId { get; set; }
        /// <summary>
        /// 流程模板信息主键
        /// </summary>
        /// <returns></returns>
        [Column("F_SCHEMEINFOID")]
        public string F_SchemeInfoId { get; set; }
        #endregion

        #region  扩展操作
        /// <summary>
        /// 新增调用
        /// </summary>
        public void Create()
        {
            this.F_Id = Guid.NewGuid().ToString();
        }
        #endregion
    }
}