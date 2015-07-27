using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace SignalRChatClient.App.Modules
{
    public class Home : NancyModule
    {
        public Home()
        {
            Get["/"] = _ =>
            {
                return View["index"];
            };
        }
    }
}
