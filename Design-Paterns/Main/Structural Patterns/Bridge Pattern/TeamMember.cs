namespace Main.Structural_Patterns.Bridge_Pattern
{
    public interface ITeamMember
    {
        string Print();
    }

    public class Player : ITeamMember
    {
        private IFormater _formater;

        public Player(IFormater formater)
        {
            _formater = formater;
        }

        public string Name { get; set; }
        public string Age { get; set; }

        public string Print()
        {
            return _formater.SetFormat(Name);
        }
    }

    public class Coach : ITeamMember
    {
        IFormater _format;

        public Coach(IFormater format)
        {
            _format = format;
        }

        public string Name { get; set; }

        public string Print()
        {
            return _format.SetFormat(Name);
        }
    }
}
