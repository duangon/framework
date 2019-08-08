﻿using Learun.Application.Excel;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>


    /// 创 建：超级管理员
    /// 日 期：2017-09-05 16:07
    /// Excel数据导出设置
    /// </summary>
    public class ExcelExportMap : EntityTypeConfiguration<ExcelExportEntity>
    {
        public ExcelExportMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_EXCEL_EXPORT");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion
 
            #region  配置关系
            #endregion
        }
    }
}
