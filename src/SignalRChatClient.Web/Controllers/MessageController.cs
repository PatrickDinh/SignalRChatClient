using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using SignalRChatClient.Data;
using SignalRChatClient.Domain;
using SignalRChatClient.Web.Models;

namespace SignalRChatClient.Web.Controllers
{
    [RoutePrefix("api/message")]
    public class MessageController : ApiController
    {
        private IRepository<Message> _messageRepo;

        public MessageController(IRepository<Message> messageRepo)
        {
            _messageRepo = messageRepo;
        }

        [Route("add")]
        public IHttpActionResult Add(MessageModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _messageRepo.Insert(new Message
            {
                UserId = model.UserId,
                ChatRoomId = model.ChatRoomId,
                Content = model.Content
            });

            Microsoft.AspNet.SignalR.GlobalHost.ConnectionManager.GetHubContext<ChatHub>().Clients.All.addNewMessageToPage("admin", model.Content);

            return Ok();
        }
    }
}