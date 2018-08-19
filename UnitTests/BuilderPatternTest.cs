using Main.Creational_Patterns.Builder_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class BuilderPatternTest
    {
        [TestMethod]
        public void TestShouldBuildCar()
        {
            var vehicleMaker = new VehicleMaker(new CarBuilder());
            vehicleMaker.BuildVehicle();
            Vehicle car = vehicleMaker.GetVehicle();
            Assert.AreEqual("Small car", car.Body);
            Assert.AreEqual("1300cc", car.Engine);
            Assert.AreEqual("Automatic", car.Transmission);
            Assert.AreEqual("Honda", car.Model);
        }

        [TestMethod]
        public void TestShouldBuildMotorCycle()
        {
            var vehicleMaker = new VehicleMaker(new MotorCycleBuilder());
            vehicleMaker.BuildVehicle();
            Vehicle bike = vehicleMaker.GetVehicle();
            Assert.AreEqual("Small bike", bike.Body);
            Assert.AreEqual("200cc", bike.Engine);
            Assert.AreEqual("Mechanic", bike.Transmission);
            Assert.AreEqual("Suzuki", bike.Model);
        }
    }








}
