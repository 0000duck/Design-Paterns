using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.Strategy_Pattern
{
    public class StandartDeliveryCalculator : IDeliveryCostCalculator
    {
        public double Calculate(double price)
        {
            return price + 5;
        }
    }
}
