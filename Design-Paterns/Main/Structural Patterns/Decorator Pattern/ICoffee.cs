using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Structural_Patterns.Decorator_Pattern
{
    public interface ICoffee
    {
        string GetDescription();
        double GetPrice();
    }
}
