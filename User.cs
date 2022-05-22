namespace Mediator
{
    public abstract class User
    {
        protected IMediator Mediator;
        protected string UserName = string.Empty;

        public User(IMediator mediator, string userName)
        {
            Mediator = mediator;
            UserName = userName;
        }
        public string GetUserName() => UserName;


        public abstract void Send(string message);
        public abstract void Receive(string message);

    }
}
