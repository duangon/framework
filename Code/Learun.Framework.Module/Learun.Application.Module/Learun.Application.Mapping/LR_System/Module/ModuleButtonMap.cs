using Learun.Application.Base.SystemModule;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2017.03.04
    /// 系统功能模块按钮
    /// </summary>
    public class ModuleButtonMap : EntityTypeConfiguration<ModuleButtonEntity>
    {
        public ModuleButtonMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_BASE_MODULEBUTTON");
            //主键
            this.HasKey(t => t.F_ModuleButtonId);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
