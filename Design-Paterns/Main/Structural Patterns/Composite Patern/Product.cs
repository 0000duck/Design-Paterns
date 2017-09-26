using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Structural_Patterns.Composite_Patern
{
    public class Product : IItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
