
namespace Learun.Application.WorkFlow
{
    /// <summary>



    /// 日 期：2017.04.17
    /// 工作流引擎节点触发方法
    /// </summary>
    public class NodeMethod : INodeMethod
    {
        /// <summary>
        /// 节点审核通过执行方法
        /// </summary>
        /// <param name="processId">流程实例主键</param>
        public void Sucess(string processId)
        {

        }
        /// <summary>
        /// 节点审核失败执行方法
        /// </summary>
        /// <param name="processId">流程实例主键</param>
        public void Fail(string processId)
        {

        }
    }
}
