﻿using Learun.Application.Form;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2017.04.01
    /// 表单模板信息
    /// </summary>
    public class FormSchemeInfoMap : EntityTypeConfiguration<FormSchemeInfoEntity>
    {
        public FormSchemeInfoMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_FORM_SCHEMEINFO");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
