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
        [Route("add")]
        public IHttpActionResult Add(MessageModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var repo = new EfRepository<Message>(new ChatClientDbContext("ChatClientContext"));
            repo.Insert(new Message
            {
                UserId = model.UserId,
                ChatRoomId = model.ChatRoomId,
                Content = model.Content
            });

            return Ok();
        }
    }
}