using Learun.Application.Base.SystemModule;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2017.03.04
    /// 系统功能模块
    /// </summary>
    public class ModuleMap : EntityTypeConfiguration<ModuleEntity>
    {
        public ModuleMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_BASE_MODULE");
            //主键
            this.HasKey(t => t.F_ModuleId);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
