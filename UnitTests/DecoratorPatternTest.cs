using Main.Structural_Patterns.Decorator_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class DecoratorPatternTest
    {
        [TestMethod]
        public void TestGetEspresoCoffe()
        {
            ICoffee coffee = new EspressoCoffee();
            Assert.AreEqual("Espresso", coffee.GetDescription());
            Assert.AreEqual(1.00, coffee.GetPrice());
        }

        [TestMethod]
        public void TestGetEspresoCoffeWithMilk()
        {
            ICoffee espreso = new EspressoCoffee();
            ICoffee espresoWithMilk = new MilkCoffeeDecorator(espreso);

            Assert.AreEqual("Espresso, with milk", espresoWithMilk.GetDescription());
            Assert.AreEqual(1.50, espresoWithMilk.GetPrice());
        }

        [TestMethod]
        public void TestGetEspresoCoffeWithMilkAndChocolate()
        {
            ICoffee espreso = new EspressoCoffee();
            ICoffee espresoWithMilk = new MilkCoffeeDecorator(espreso);
            ICoffee espresoWithMilkAndChocolate = new ChocolateCoffeeDecorator(espresoWithMilk);

            Assert.AreEqual("Espresso, with milk, chocolate", espresoWithMilkAndChocolate.GetDescription());
            Assert.AreEqual(2.10, espresoWithMilkAndChocolate.GetPrice());
        }
    }
}
