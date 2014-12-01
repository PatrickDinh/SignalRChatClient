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
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        [AllowAnonymous]
        [Route("register")]
        public IHttpActionResult Register(UserModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //var repo = new EfRepository<User>(new ChatClientDbContext("ChatClientContext"));
            //repo.Insert(new User
            //{
            //    NickName = userModel.NickName
            //});

            return Ok();
        }

    }
}
