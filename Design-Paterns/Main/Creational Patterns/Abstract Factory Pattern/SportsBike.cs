using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Creational_Patterns.Abstract_Factory_Pattern
{
    public class SportsBike : IBike
    {
        public string Name()
        {
            return "Sports Bike";
        }
    }
}
