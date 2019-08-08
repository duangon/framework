﻿using Learun.Application.Base.AuthorizeModule;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2017.04.17
    /// IP过滤
    /// </summary>
    public class FilterIPMap : EntityTypeConfiguration<FilterIPEntity>
    {
        public FilterIPMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_BASE_FILTERIP");
            //主键
            this.HasKey(t => t.F_FilterIPId);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
