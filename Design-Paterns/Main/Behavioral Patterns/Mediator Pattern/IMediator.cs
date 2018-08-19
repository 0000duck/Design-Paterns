namespace Main.Behavioral_Patterns.Mediator_Pattern
{
    public interface IMediator
    {
        void AddUser(IUser user);
        void SendMessage(string message, IUser sender);
    }
}
