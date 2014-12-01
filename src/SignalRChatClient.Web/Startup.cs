using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Microsoft.Owin;
using Ninject;
using Owin;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Ninject.Modules;
using SIgnalRChatClient.IoC;

namespace SignalRChatClient.Web
{
    [assembly: OwinStartup(typeof(SignalRChatClient.Web.Startup))]
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            RouteConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);
            app.UseNinjectMiddleware(CreateKernel).UseNinjectWebApi(config);
            app.MapSignalR();
        }

        private IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            var modules = new List<INinjectModule>
            {
                new WebApiNinjectModule()
            };
            kernel.Load(modules);
            return kernel;
        }
    }
}