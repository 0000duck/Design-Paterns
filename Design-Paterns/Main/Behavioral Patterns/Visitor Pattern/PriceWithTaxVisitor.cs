namespace Main.Behavioral_Patterns.Visitor_Pattern
{
    public class PriceWithTaxVisitor : IVisitor
    {
        private const int VAT = 20;

        public decimal PriceAfterTax;

        public void Accept(Car car)
        {
            PriceAfterTax = car.Price + ((car.Price / 100) * VAT);
        }

        public void Accept(Bike bike)
        {
            PriceAfterTax = bike.Price + ((bike.Price / 100) * VAT);
        }
    }
}
