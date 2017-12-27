using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.Visitor_Pattern
{
    public interface IStore
    {
        void Visit(IVisitor visitor);
    }
}
