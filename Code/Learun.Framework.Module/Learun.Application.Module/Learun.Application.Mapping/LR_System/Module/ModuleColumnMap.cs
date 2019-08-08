﻿using Learun.Application.Base.SystemModule;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2017.03.04
    /// 系统功能模块视图列
    /// </summary>
    public class ModuleColumnMap : EntityTypeConfiguration<ModuleColumnEntity>
    {
        public ModuleColumnMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_BASE_MODULECOLUMN");
            //主键
            this.HasKey(t => t.F_ModuleColumnId);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
