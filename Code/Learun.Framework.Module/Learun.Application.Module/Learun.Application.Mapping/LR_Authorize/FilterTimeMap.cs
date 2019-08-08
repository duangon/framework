﻿using Learun.Application.Base.AuthorizeModule;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2017.04.17
    /// 时段过滤
    /// </summary>
    public class FilterTimeMap : EntityTypeConfiguration<FilterTimeEntity>
    {
        public FilterTimeMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_BASE_FILTERTIME");
            //主键
            this.HasKey(t => t.F_FilterTimeId);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
