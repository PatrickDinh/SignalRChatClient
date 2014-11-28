using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChatClient.Domain
{
    public class Message : BaseEntity
    {
        public string Content { get; set; }
        public int UserId { get; set; }
        public int ChatRoomId { get; set; }
        public User User { get; set; }
        public ChatRoom ChatRoom { get; set; }
    }
}
