using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalRChatClient.Data;
using SignalRChatClient.Domain;

namespace SignalRChatClient.Business
{
    public class UserService : SignalRChatClient.Business.IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(User user)
        {
            user.CreatDateTime = DateTime.UtcNow;

            _userRepository.Insert(user);
        }
    }
}
