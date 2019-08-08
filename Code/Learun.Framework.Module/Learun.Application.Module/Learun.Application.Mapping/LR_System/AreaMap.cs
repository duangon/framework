﻿using Learun.Application.Base.SystemModule;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2017.04.01
    /// 行政区域
    /// </summary>
    public class AreaMap : EntityTypeConfiguration<AreaEntity>
    {
        public AreaMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_BASE_AREA");
            //主键
            this.HasKey(t => t.F_AreaId);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
