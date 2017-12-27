using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.Visitor_Pattern
{
    public class DiscountVisitor : IVisitor
    {
        private const int CAR_DISCOUNT = 20;
        private const int BIKE_DISCOUNT = 10;

        public decimal PriceAfterDicount;

        public void Accept(Car car)
        {
            PriceAfterDicount = car.Price - ((car.Price / 100) * CAR_DISCOUNT);
        }

        public void Accept(Bike bike)
        {
            PriceAfterDicount = bike.Price - ((bike.Price / 100) * BIKE_DISCOUNT);
        }
    }
}
