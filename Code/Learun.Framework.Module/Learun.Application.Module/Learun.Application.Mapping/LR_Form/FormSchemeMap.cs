using Learun.Application.Form;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2017.04.01
    /// 表单模板
    /// </summary>
    public class FormSchemeMap : EntityTypeConfiguration<FormSchemeEntity>
    {
        public FormSchemeMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_FORM_SCHEME");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
