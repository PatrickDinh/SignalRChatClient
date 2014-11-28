using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using SignalRChatClient.Data;
using SignalRChatClient.Domain;
using SignalRChatClient.Web.Models;

namespace SignalRChatClient.Web.Controllers
{
    [RoutePrefix("api/chatroom")]
    public class ChatRoomController : ApiController
    {
        [Route("add")]
        public IHttpActionResult Add(ChatRoomModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var repo = new EfRepository<ChatRoom>(new ChatClientDbContext("ChatClientContext"));
            repo.Insert(new ChatRoom
            {
                Name = model.Name
            });

            return Ok();
        }
    }
}