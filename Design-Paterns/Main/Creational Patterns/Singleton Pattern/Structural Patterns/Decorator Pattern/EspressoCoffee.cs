using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
