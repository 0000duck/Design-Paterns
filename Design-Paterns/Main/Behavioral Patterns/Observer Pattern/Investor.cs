using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Behavioral_Patterns.Observer_Pattern
{
    public class Investor : IInvestor
    {
        private string _name;
        private Stock _stock;
        public Investor(string name)
        {
            this._name = name;
        }
        public void Update(Stock stock)
        {
            Stock = stock;
        }
        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}
