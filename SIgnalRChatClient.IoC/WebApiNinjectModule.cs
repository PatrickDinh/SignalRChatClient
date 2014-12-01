using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using SignalRChatClient.Data;
using Ninject.Web.Common;

namespace SIgnalRChatClient.IoC
{
    public class WebApiNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ChatClientDbContext>().ToSelf().InRequestScope();
            Bind(typeof(IRepository<>)).To(typeof(EfRepository<>));
            Bind<IDbContext>().To<ChatClientDbContext>().InRequestScope();
        }
    }
}
