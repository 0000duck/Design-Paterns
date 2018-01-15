using Main.Behavioral_Patterns.Observer_Pattern;
using Main.Creational_Patterns.Abstract_Factory_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{   
    [TestClass]
    public class ObserverPatternTest
    {
        [TestMethod]
        public void ShouldNotifyAllInvestors()
        {
            // Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);

            var sorros = new Investor("Sorros");
            var berkshire = new Investor("Berkshire");
            ibm.Attach(sorros);
            ibm.Attach(berkshire);

            ibm.Notify();

            Assert.IsTrue(sorros.Stock.Price == 120.00);
            Assert.IsTrue(berkshire.Stock.Price == 120.00);

            // Fluctuating prices will notify investors            
            ibm.Price = 121.00;

            Assert.IsTrue(sorros.Stock.Price == 121.00);
            Assert.IsTrue(berkshire.Stock.Price == 121.00);

        }
    }
}
