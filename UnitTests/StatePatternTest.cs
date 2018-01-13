using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Behavioral_Patterns.State_Pattern;
using Main.Behavioral_Patterns.Visitor_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class StatePatternTest
    {
        [TestMethod]
        public void TestShouldReturnFirstGreenState()
        {
            TrafficLight trafficLight = new TrafficLight();
            trafficLight.State = new GreenLight();
            var state = trafficLight.ReportState();
            Assert.IsTrue(Lights.Green == state);
        }

        [TestMethod]
        public void TestShouldChangeStates()
        {
            TrafficLight trafficLight = new TrafficLight();
            trafficLight.State = new GreenLight();
            var state = trafficLight.ReportState();
            Assert.IsTrue(Lights.Green == state);
            trafficLight.Change();
            state = trafficLight.ReportState();
            Assert.IsTrue(Lights.Yellow == state);
            trafficLight.Change();
            state = trafficLight.ReportState();
            Assert.IsTrue(Lights.Red == state);
            trafficLight.Change();
            state = trafficLight.ReportState();
            Assert.IsTrue(Lights.Green == state);
        }
    }
}

