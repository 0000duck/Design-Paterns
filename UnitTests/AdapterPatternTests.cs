using Main.Structural_Patterns.Adapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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
