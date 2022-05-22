using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IMediator
    {
        string GetGroupName();
        void RegisterUser(User user);
        void SendMessageToAllGroupMembers(User user, string message);
        void UnregisterUser(User user);
    }
}
