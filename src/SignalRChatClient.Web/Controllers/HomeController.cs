using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignalRChatClient.Data;
using SignalRChatClient.Domain;

namespace SignalRChatClient.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Message> _messageRepo;

        public HomeController(IRepository<Message> messageRepo)
        {
            _messageRepo = messageRepo;
        }


        public ActionResult Index()
        {
            return View();
        }
    }
}