using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator
{
    public class Mediator : IMediator
    {

        private string _groupName = string.Empty;
        private List<User> _users = new List<User>();

        public Mediator(string groupName) => _groupName = groupName;
        public string GetGroupName() => _groupName;

        public void RegisterUser(User user)
        {
            var userIsFound = _users.Where(q => q == user).Count() > 0 ? true : false;

            if (!userIsFound)
            {
                _users.Add(user);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n{user.GetUserName()} (Has joined to the group '{_groupName}'!)");
            }
        }

        public void SendMessageToAllGroupMembers(User _user, string _message)
        {
            foreach (var user in _users)
            {
                if (user != _user)
                {
                    user.Receive(_message);
                }
            }
        }

        public void UnregisterUser(User _user)
        {
            foreach (var user in _users)
            {
                if (user == _user)
                {
                    _users.Remove(user);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{user.GetUserName()} (Has left the group '{_groupName}'!)");
                    break;
                }
            }
        }
    }
}
