using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Structural_Patterns.Facade_Patern
{
    public class EnglishMetricConverter
    {
        public double FarenheitToCelcious(double degrees)
        {
            return ((degrees - 32) / 9.0) * 5.0;
        }
    }
}
