namespace Main.Behavioral_Patterns.Strategy_Pattern
{
    public class OneDayDeliveryCalculator : IDeliveryCostCalculator
    {
        public double Calculate(double price)
        {
            return price + 15;
        }
    }
}
