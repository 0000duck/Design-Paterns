namespace Main.Behavioral_Patterns.Visitor_Pattern
{
    public class Car : IStore
    {
        public decimal Price { get; set; }

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}
