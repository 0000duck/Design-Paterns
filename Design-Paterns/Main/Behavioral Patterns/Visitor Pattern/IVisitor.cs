using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.Visitor_Pattern
{
    public interface IVisitor
    {
        void Accept(Car car);
        void Accept(Bike bike);
    }
}
