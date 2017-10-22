using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Structural_Patterns.Decorator_Pattern
{
    public class MilkCoffeeDecorator : ICoffee
    {
        ICoffee _coffee;

        public MilkCoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public string GetDescription()
        {
            return _coffee.GetDescription() + ", with milk";
        }

        public double GetPrice()
        {
            return _coffee.GetPrice() + 0.50;
        }
    }
}
