namespace Main.Behavioral_Patterns.Visitor_Pattern
{
    public interface IVisitor
    {
        void Accept(Car car);
        void Accept(Bike bike);
    }
}
