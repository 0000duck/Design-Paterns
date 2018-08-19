namespace Main.Structural_Patterns.Decorator_Pattern
{
    public class EspressoCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Espresso";
        }

        public double GetPrice()
        {
            return 1.00;
        }
    }
}
