﻿using Main.Creational_Patterns.Abstract_Factory_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class AbstractFactoryPatternTest
    {
        [TestMethod]
        public void ShouldBuildSportBike()
        {
            IVehicleFactory factory = new HondaFactory();
            var client = new VehicleClient(factory, VehicleType.Sports);

            var name = client.GetBikeName();

            Assert.AreEqual("Sports Bike", name);
        }

        [TestMethod]
        public void ShouldBuildRegularBike()
        {
            IVehicleFactory factory = new HondaFactory();
            var client = new VehicleClient(factory, VehicleType.Regular);

            var name = client.GetBikeName();

            Assert.AreEqual("Regular Bike", name);
        }
    }
}
