namespace Main.Structural_Patterns.Bridge_Pattern
{
    public interface IFormater
    {
        string SetFormat(string text);
    }

    public class StandartFormater : IFormater
    {
        public string SetFormat(string text)
        {
            return text;
        }
    }

    public class StarsFormater : IFormater
    {
        public string SetFormat(string text)
        {
            return "*" + text + "*";
        }
    }
}
