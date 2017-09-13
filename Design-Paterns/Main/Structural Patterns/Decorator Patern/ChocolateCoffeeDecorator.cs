using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Structural_Patterns.Decorator_Patern
{
    public class ChocolateCoffeeDecorator : ICoffee
    {
        ICoffee _coffee;

        public ChocolateCoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public string GetDescription()
        {
            return _coffee.GetDescription() + ", chocolate";
        }

        public double GetPrice()
        {
            return _coffee.GetPrice() + 0.60;
        }
    }
}
