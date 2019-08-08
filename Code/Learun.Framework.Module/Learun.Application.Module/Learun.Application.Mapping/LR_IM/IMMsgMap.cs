﻿using Learun.Application.IM;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2018.05.31
    /// 即时通讯消息内容
    /// </summary>
    public class IMMsgMap : EntityTypeConfiguration<IMMsgEntity>
    {
        public IMMsgMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_IM_MSG");
            //主键
            this.HasKey(t => t.F_MsgId);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
