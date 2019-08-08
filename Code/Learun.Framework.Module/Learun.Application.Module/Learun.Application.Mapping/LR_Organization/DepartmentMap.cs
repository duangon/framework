﻿using Learun.Application.Organization;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2017.03.04
    /// 部门管理
    /// </summary>
    public class DepartmentMap : EntityTypeConfiguration<DepartmentEntity>
    {
        public DepartmentMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_BASE_DEPARTMENT");//Base_Department
            //主键
            this.HasKey(t => t.F_DepartmentId);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
