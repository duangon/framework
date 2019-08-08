
using System.Collections.Generic;
namespace Learun.Application.WorkFlow
{
    /// <summary>



    /// 日 期：2017.04.17
    /// 流程引擎返回结果数据
    /// </summary>
    public class WfResult
    {
        /// <summary>
        /// 状态:1-成功，2-失败
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string desc { get; set; }
    }
    /// <summary>



    /// 日 期：2017.04.17
    /// 流程引擎返回结果数据
    /// </summary>
    public class WfResult<T> where T : class
    {
        /// <summary>
        /// 状态:1-成功，2-失败
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public T data { get; set; }
    }

    /// <summary>



    /// 日 期：2017.04.17
    /// 流程引擎返回的数据内容
    /// </summary>
    public class WfContent {
        /// <summary>
        /// 当前节点信息
        /// </summary>
        public WfNodeInfo currentNode { get; set; }
        /// <summary>
        /// 当前正在执行的任务节点ID数据
        /// </summary>
        public List<string> currentNodeIds { get; set; }
        /// <summary>
        /// 流程模板信息
        /// </summary>
        public string scheme { get; set; }
        /// <summary>
        /// 审核记录
        /// </summary>
        public List<WfTaskHistoryEntity> history { get; set; } 
    }
}
