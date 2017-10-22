using Main.Structural_Patterns.Facade_Pattern;
using Main.Structural_Patterns.Facade_Pattern.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class FacadePatternTest
    {
        [TestMethod]
        public void TestShouldReturnTemperature()
        {
            var temperatureFacade = new TemperatureFacade();
            LocalTemperature localTemp = temperatureFacade.GetTemperature();
                        
            Assert.AreEqual(localTemp.Farenheit, 86);
            Assert.AreEqual(localTemp.Celcius, 30);
        }
    }
}
