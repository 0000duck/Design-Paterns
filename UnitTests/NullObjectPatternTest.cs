using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Behavioral_Patterns.Null_Object_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class NullObjectPatternTest
    {
        [TestMethod]
        public void ShouldReturnPremiumDiscount()
        {
            Order order = new Order(new PremiumDiscount());
            order.ProductCost = 10;
            var discount = order.CalculateDiscount();
            Assert.AreEqual(5, discount);
        }

        [TestMethod]
        public void ShouldNullDiscount()
        {
            Order order = new Order(new NullDiscount());
            order.ProductCost = 10;
            var discount = order.CalculateDiscount();
            Assert.AreEqual(0, discount);
        }
    }
}
