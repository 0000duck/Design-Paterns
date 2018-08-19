using Main.Creational_Patterns.Singleton_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class SingletonPatternTest
    {
        [TestMethod]
        public void TestObjectSHouldHaveSameInstance()
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            Assert.IsTrue(s1 == s2);
        }
    }
}
