namespace Main.Behavioral_Patterns.Command_Pattern
{
    public class Switch
    {
        public void StoreAndExecute(ICommand command)
        {
            command.Execute();
        }
    }
}
