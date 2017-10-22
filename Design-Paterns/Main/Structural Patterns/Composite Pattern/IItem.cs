using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Structural_Patterns.Composite_Pattern
{
    public interface IItem
    {
        string Name { get; set; }
        double Price { get; set; }
    }
}
