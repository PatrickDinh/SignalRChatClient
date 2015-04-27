using System;
using SignalRChatClient.Domain;

namespace SignalRChatClient.Business
{
    public interface IUserService
    {
        void CreateUser(User user);
    }
}
