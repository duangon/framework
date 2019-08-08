using Learun.Application.AppMagager;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2018.03.16
    /// 工作流模板
    /// </summary>
    public class FunctionMap : EntityTypeConfiguration<FunctionEntity>
    {
        public FunctionMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_APP_FUNCTION");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
