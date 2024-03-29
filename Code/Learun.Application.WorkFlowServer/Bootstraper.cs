﻿using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace Learun.Application.WorkFlowServer
{
    /// <summary>



    /// 日 期：2017.05.12
    /// Nancy-初始化
    /// </summary>
    public class Bootstraper : DefaultNancyBootstrapper
    {
        /// <summary>
        /// 自定义请求启动函数
        /// </summary>
        /// <param name="container"></param>
        /// <param name="pipelines"></param>
        /// <param name="context"></param>
        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            //CORS Enable
            pipelines.AfterRequest.AddItemToEndOfPipeline((ctx) =>
            {
                var originlist = ctx.Request.Headers["Origin"];
                foreach (var origin in originlist)
                {
                    ctx.Response.WithHeader("Access-Control-Allow-Origin", origin);
                }
                ctx.Response.WithHeader("Access-Control-Allow-Methods", "POST,GET")
                    .WithHeader("Access-Control-Allow-Credentials", "true")
                    .WithHeader("Access-Control-Allow-Headers", "Accept, Origin, Content-type");
            });
        }
    }
}
