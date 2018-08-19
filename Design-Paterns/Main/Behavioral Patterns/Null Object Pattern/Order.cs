namespace Main.Behavioral_Patterns.Null_Object_Pattern
{
    public class Order
    {
        public string ProductName { get; set; }
        public double ProductCost { get; set; }
        private readonly IDiscount _discount = null;

        public Order(IDiscount discount)
        {
            _discount = discount;
        }
        public double CalculateDiscount()
        {
            return _discount.CalculateDiscount(ProductCost);
        }
    }
}
