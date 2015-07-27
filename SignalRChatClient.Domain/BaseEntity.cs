using System;

namespace SignalRChatClient.Domain
{
    public abstract partial class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime? CreatDateTime { get; set; }
        public DateTime? ModifyDateTime { get; set; }
    }
}
