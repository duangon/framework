using Learun.Application.Organization;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2017.03.04
    /// 角色管理
    /// </summary>
    public class RoleMap : EntityTypeConfiguration<RoleEntity>
    {
        public RoleMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_BASE_ROLE");
            //主键
            this.HasKey(t => t.F_RoleId);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
