﻿using Learun.Application.TwoDevelopment.LR_Desktop;
using System.Data.Entity.ModelConfiguration;

namespace  Learun.Application.Mapping
{
    /// <summary>


    /// 创 建：超级管理员
    /// 日 期：2018-09-21 16:35
    /// 统计配置
    /// </summary>
    public class DTTargetMap : EntityTypeConfiguration<DTTargetEntity>
    {
        public DTTargetMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_DT_TARGET");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}

