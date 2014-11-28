using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRChatClient.Web.Models
{
    public class MessageModel
    {
        public int UserId { get; set; }
        public int ChatRoomId { get; set; }
        public string Content { get; set; }
    }
}