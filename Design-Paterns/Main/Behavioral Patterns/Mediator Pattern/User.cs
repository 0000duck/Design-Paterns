namespace Main.Behavioral_Patterns.Mediator_Pattern
{
    public class User : IUser
    {
        IMediator chatMediator;
        public string Message { get; set; }
        public string Name { get; set; }

        public User(IMediator mediator, string name)
        {
            Name = name;
            this.chatMediator = mediator;
        }

        public void SendMessage(string message)
        {
            chatMediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Message = message;
        }
    }
}
