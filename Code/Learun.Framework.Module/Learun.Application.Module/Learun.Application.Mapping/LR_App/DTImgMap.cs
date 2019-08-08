﻿using Learun.Application.AppMagager;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping.LR_App
{
    /// <summary> 
 
 
    /// 创 建：超级管理员 
    /// 日 期：2018-07-02 15:31 
    /// App首页图片管理 
    /// </summary> 
    public class DTImgMap : EntityTypeConfiguration<DTImgEntity>
    {
        public DTImgMap()
        {
            #region  表、主键 
            //表 
            this.ToTable("LR_APP_DTIMG");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region  配置关系 
            #endregion
        }
    }
}
