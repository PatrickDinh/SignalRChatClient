using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalRChatClient.Domain;

namespace SignalRChatClient.Data.Mapping.ChatRooms
{
    public class ChatRoomMap : EntityTypeConfiguration<ChatRoom>
    {
        public ChatRoomMap()
        {
            this.ToTable("ChatRoom");
            this.HasKey(c => c.Id);
            this.Property(u => u.Name).HasMaxLength(1000);
        }
    }
}
