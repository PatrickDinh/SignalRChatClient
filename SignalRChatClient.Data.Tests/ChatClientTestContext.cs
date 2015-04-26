using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChatClient.Data.Tests
{
    public class ChatClientTestContext : ChatClientDbContext
    {
        public ChatClientTestContext()
        {
            Database.SetInitializer<ChatClientDbContext>(new DropCreateDatabaseAlways<ChatClientDbContext>());
        }
    }
}
