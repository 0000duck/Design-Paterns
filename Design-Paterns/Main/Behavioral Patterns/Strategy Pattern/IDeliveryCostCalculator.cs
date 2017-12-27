using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.Strategy_Pattern
{
    public interface IDeliveryCostCalculator
    {
        double Calculate(double price);
    }
}
