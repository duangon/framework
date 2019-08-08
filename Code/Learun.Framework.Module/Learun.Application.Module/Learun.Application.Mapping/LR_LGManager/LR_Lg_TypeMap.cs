using Learun.Application.TwoDevelopment.LR_LGManager;
using System.Data.Entity.ModelConfiguration;

namespace  Learun.Application.Mapping
{
    /// <summary>


    /// 创 建：超级管理员
    /// 日 期：2018-09-29 15:01
    /// 多语言映射
    /// </summary>
    public class LgTypeMap : EntityTypeConfiguration<LgTypeEntity>
    {
        public LgTypeMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_LG_TYPE");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}

