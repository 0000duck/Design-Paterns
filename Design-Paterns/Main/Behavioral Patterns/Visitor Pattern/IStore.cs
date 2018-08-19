namespace Main.Behavioral_Patterns.Visitor_Pattern
{
    public interface IStore
    {
        void Visit(IVisitor visitor);
    }
}
