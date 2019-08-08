﻿using Learun.Application.Base.SystemModule;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2017.03.08
    /// 附件管理
    /// </summary>
    public class AnnexesFileMap : EntityTypeConfiguration<AnnexesFileEntity>
    {
        public AnnexesFileMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_BASE_ANNEXESFILE");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
