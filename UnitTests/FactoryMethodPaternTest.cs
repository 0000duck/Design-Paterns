using Main.Creational_Patterns.Factory_Method_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class FactoryMethodPaternTest
    {
        [TestMethod]
        public void TesteObjectShouldBeCreatedWihtoutExposingCreationLogic()
        {
            var bike = VehicleFactory.GetVehicle(VehicleType.Bike);
            var scooter = VehicleFactory.GetVehicle(VehicleType.Scooter);

            Assert.IsInstanceOfType(bike, typeof(Bike));
            Assert.IsInstanceOfType(scooter, typeof(Scooter));
        }
    }    
}
