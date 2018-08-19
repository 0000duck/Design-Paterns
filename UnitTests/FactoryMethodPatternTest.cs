using Main.Creational_Patterns.Factory_Method_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class FactoryMethodPatternTest
    {
        [TestMethod]
        public void TesteObjectShouldBeCreatedWihtoutExposingCreationLogic()
        {
            var bike = VehicleFactory.GetVehicle(VehicleType.Bike);
            var scooter = VehicleFactory.GetVehicle(VehicleType.Scooter);

            Assert.IsInstanceOfType(bike, typeof(Main.Creational_Patterns.Factory_Method_Pattern.Bike));
            Assert.IsInstanceOfType(scooter, typeof(Main.Creational_Patterns.Factory_Method_Pattern.Scooter));
        }
    }    
}
