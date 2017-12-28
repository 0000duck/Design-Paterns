using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Behavioral_Patterns.Visitor_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class VisitorPatternTest
    {
        List<IStore> store = new List<IStore>();
        public VisitorPatternTest()
        {            
            store.Add(new Car() { Price = 200 });
            
            store.Add(new Bike() { Price = 100 });
        }

        [TestMethod]
        public void PricesWithDiscountTest()
        {
            DiscountVisitor visitor = new DiscountVisitor();
            store[0].Visit(visitor);
            Assert.IsTrue(visitor.PriceAfterDicount == 160);
            store[1].Visit(visitor);
            Assert.IsTrue(visitor.PriceAfterDicount == 90);
        }

        [TestMethod]
        public void PricesWithTaxTest()
        {
            PriceWithTaxVisitor visitor = new PriceWithTaxVisitor();
            store[0].Visit(visitor);
            Assert.IsTrue(visitor.PriceAfterTax == 240);
            store[1].Visit(visitor);
            Assert.IsTrue(visitor.PriceAfterTax == 120);
        }
    }
}
