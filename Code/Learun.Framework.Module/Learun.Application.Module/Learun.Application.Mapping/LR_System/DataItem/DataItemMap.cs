using Learun.Application.Base.SystemModule;
using System.Data.Entity.ModelConfiguration;

namespace Learun.Application.Mapping
{
    /// <summary>



    /// 日 期：2017.03.04
    /// 数据字典分类
    /// </summary>
    public class DataItemMap : EntityTypeConfiguration<DataItemEntity>
    {
        public DataItemMap()
        {
            #region  表、主键
            //表
            this.ToTable("LR_BASE_DATAITEM");
            //主键
            this.HasKey(t => t.F_ItemId);
            #endregion

            #region  配置关系
            #endregion
        }
    }
}
