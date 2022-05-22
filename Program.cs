using System;
using System.Threading;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mediator Pattern C#");
            string groupName = "La Chanclillas";
            IMediator mediator = new Mediator(groupName);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"GROUP '{mediator.GetGroupName()}' CREATED!");

            Console.WriteLine("### ADD SOME USER ###");

            Thread.Sleep(1000);
            User userOne = new ChatUser(mediator, Faker.Name.First());
            mediator.RegisterUser(userOne);
           

            Thread.Sleep(1000);
            User userTwo = new ChatUser(mediator, Faker.Name.First());
            mediator.RegisterUser(userTwo);

            Thread.Sleep(1000);
            User userThree = new ChatUser(mediator, Faker.Name.First());
            mediator.RegisterUser(userThree);
            

            

            userOne.Send("Holiiii que pasiii!!");
            Thread.Sleep(500);
            userTwo.Send("Ehhhh caña aquí!!");
            Thread.Sleep(500);
            userThree.Send("como estais???");
            Thread.Sleep(500);
            userOne.Send("Me piro");
            Thread.Sleep(500);

            mediator.UnregisterUser(userOne);

            userTwo.Send($"Ya la has liado {userThree.GetUserName()} jajajaja");
            Thread.Sleep(2000);

            mediator.RegisterUser(userOne);
            userOne.Send("Ya estoy aquí de nuevo!!!");
            
            Console.ResetColor();
            Console.WriteLine("\nPress any key to close\n");
            Console.ReadKey();
        }
    }
}
