using Main.Structural_Patterns.Adapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class AdapterPatternTests
    {
        [TestMethod]
        public void TestSocketAdapterShouldReturn12Volt()
        {
            var socket = new Main.Structural_Patterns.Adapter.Socket();
            ISocketAdapter adapter = new SocketAdapter(socket);
            var result = adapter.Get12Volt();
            Assert.AreEqual(12, result);
        }
    }
}
