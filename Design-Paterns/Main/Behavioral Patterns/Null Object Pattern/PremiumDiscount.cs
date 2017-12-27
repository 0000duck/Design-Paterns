using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.Null_Object_Pattern
{
    public class PremiumDiscount : IDiscount
    {
        public double CalculateDiscount(double productCost)
        {
            return (productCost * 0.5);
        }
    }
}
