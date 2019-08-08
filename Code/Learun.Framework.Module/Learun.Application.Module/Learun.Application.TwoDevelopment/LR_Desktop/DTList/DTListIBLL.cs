using Learun.Util;
using System.Data;
using System.Collections.Generic;

namespace Learun.Application.TwoDevelopment.LR_Desktop
{
    /// <summary>


    /// 创 建：超级管理员
    /// 日 期：2018-09-25 10:57
    /// 消息配置
    /// </summary>
    public interface DTListIBLL
    {
        #region  获取数据

        /// <summary>
        /// 获取页面显示列表数据
        /// <summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns></returns>
        IEnumerable<DTListEntity> GetList(string queryJson);
        /// <summary>
        /// 获取LR_DT_List表实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        DTListEntity GetLR_DT_ListEntity(string keyValue);
        #endregion

        #region  提交数据

        /// <summary>
        /// 删除实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        void DeleteEntity(string keyValue);
        /// <summary>
        /// 保存实体数据（新增、修改）
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        void SaveEntity(string keyValue, DTListEntity entity);
        IEnumerable<DTListEntity> GetPageList(Pagination paginationobj, string queryJson);
        #endregion

    }
}
