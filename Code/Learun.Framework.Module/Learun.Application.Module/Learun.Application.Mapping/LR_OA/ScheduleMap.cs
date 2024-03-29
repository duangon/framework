﻿using Learun.Application.OA;
using Learun.Application.OA.Schedule;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2017.04.17
    /// 新闻公告
    /// </summary>
    public class ScheduleMap : EntityTypeConfiguration<ScheduleEntity>
    {
        public ScheduleMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_OA_SCHEDULE");
            //主键
            this.HasKey(t => t.F_ScheduleId);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
