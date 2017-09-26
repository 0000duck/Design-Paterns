using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Structural_Patterns.Composite_Patern
{
    public class Box : IItem
    {
        public List<IItem> Products = new List<IItem>();
        public string Name { get; set; }
        public double Price
        {
            get
            {
                double total = 0;
                foreach (var product in Products)
                {
                    total += product.Price;
                }

                return total;
            }
            set { }
        }
    }
}
