using Learun.Application.Base.SystemModule;
using Learun.Loger;
using Learun.Util;
using Learun.Util.Operat;
using System;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;

namespace Learun.Application.Web
{
    /// <summary>
    /// 记录操作日志
    /// </summary>
    public class RecordLog : ActionFilterAttribute
    {
        /// <summary>
        /// 初始化拦截器
        /// </summary>
        /// <param name="ignore">是否忽略</param>
        public RecordLog(FilterMode ignore = FilterMode.Enforce)
        {
            Ignore = ignore;
        }
        /// <summary>
        /// 是否忽略
        /// </summary>
        public FilterMode Ignore { get; set; }
        /// <summary>
        /// Action执行前触发
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.Result is ViewResult) { } else {
                var userInfo = LoginUserInfo.Get();
                var log = LogFactory.GetLogger(context.Controller.ToString());
                LogMessage logMessage = new LogMessage();
                logMessage.OperationTime = DateTime.Now;
                logMessage.Url = context.HttpContext.Request.Path;
                logMessage.Class = context.Controller.ToString();
                logMessage.Ip = Net.Ip;
                logMessage.Host = Net.Host;
                logMessage.Browser = Net.Browser;
                if (userInfo != null)
                {
                    logMessage.UserName = userInfo.account + "（" + userInfo.realName + "）";
                }
                string strMessage = new LogFormat().InfoFormat(logMessage);
                log.Info(strMessage);

                LogEntity logEntity = new LogEntity();
                logEntity.F_CategoryId = 3;
                logEntity.F_OperateTypeId = ((int)OperationType.Submit).ToString();
                logEntity.F_OperateType = EnumAttribute.GetDescription(OperationType.Submit);
                logEntity.F_OperateAccount = logMessage.UserName;
                if (userInfo != null)
                {
                    logEntity.F_OperateUserId = userInfo.userId;
                }
                logEntity.F_ExecuteResult = 1;
                logEntity.F_ExecuteResultJson = strMessage;
                logEntity.WriteLog();
            }
        }
    }
}