using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ChatUser:User
    {
        public ChatUser(IMediator mediator, string userName):base(mediator,userName)
        {

        }

        public override void Receive(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\t Chat User: {UserName} (Received Message) > {message}");
        }

        public override void Send(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n Chat User: {UserName} (Sending Message) > {message}");
            Mediator.SendMessageToAllGroupMembers(this, message);
        }
    }
}
