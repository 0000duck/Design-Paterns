using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Behavioral_Patterns.Strategy_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    class StrategyPatternTest
    {
        [TestMethod]
        public void ShouldReturnCostForOneDayDelivery()
        {
            var calculator = new DeliveryCalculator(new OneDayDeliveryCalculator());
            var totalCost = calculator.CalculateShippingCost(10);
            Assert.AreEqual(25, totalCost);
        }

        [TestMethod]
        public void ShouldReturnCostForStandartDelivery()
        {
            var calculator = new DeliveryCalculator(new StandartDeliveryCalculator());
            var totalCost = calculator.CalculateShippingCost(10);
            Assert.AreEqual(15, totalCost);
        }
    }
}
