namespace Main.Behavioral_Patterns.Strategy_Pattern
{
    public class DeliveryCalculator
    {
        private readonly IDeliveryCostCalculator _strategy;

        public DeliveryCalculator(IDeliveryCostCalculator strategy)
        {
            _strategy = strategy;
        }

        public double CalculateShippingCost(double price)
        {
            return _strategy.Calculate(price);
        }
    }
}
