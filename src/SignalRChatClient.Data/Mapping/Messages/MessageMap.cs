using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalRChatClient.Domain;

namespace SignalRChatClient.Data.Mapping.Messages
{
    public class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            this.ToTable("Message");
            this.HasKey(c => c.Id);
            this.Property(u => u.Content).HasMaxLength(1000);
            this.HasRequired(x => x.User).WithMany().HasForeignKey(x => x.UserId).WillCascadeOnDelete(true);
            this.HasRequired(x => x.ChatRoom).WithMany().HasForeignKey(x => x.ChatRoomId).WillCascadeOnDelete(true);
        }
    }
}
