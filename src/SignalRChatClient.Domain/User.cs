using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChatClient.Domain
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string NickName { get; set; }
    }
}
