namespace Main.Behavioral_Patterns.Null_Object_Pattern
{
    public class NullDiscount : IDiscount
    {
        public double CalculateDiscount(double productCost)
        {
            return 0;
        }
    }
}
