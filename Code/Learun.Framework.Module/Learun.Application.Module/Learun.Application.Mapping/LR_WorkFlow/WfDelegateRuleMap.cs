using Learun.Application.WorkFlow;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2017.04.17
    /// 工作流委托规则
    /// </summary>
    public class WfDelegateRuleMap : EntityTypeConfiguration<WfDelegateRuleEntity>
    {
        public WfDelegateRuleMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_WF_DELEGATERULE");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
