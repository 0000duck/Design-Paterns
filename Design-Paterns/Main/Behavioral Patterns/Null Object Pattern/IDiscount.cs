using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.Null_Object_Pattern
{
    public interface IDiscount
    {
        double CalculateDiscount(double productCost);
    }
}
