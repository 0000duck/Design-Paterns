using Main.Structural_Patterns.Proxy_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ProxyPatternTest
    {
        [TestMethod]
        public void TestShowImageShouldBeTrue()
        {
            IImage imageProxy = new HighResImageProxy("path");
            Assert.IsTrue(imageProxy.ShowImage());
        }

        [TestMethod]
        public void TestCallingShowImageTwiceExpensiveResourceShouldBeCalledOnce()
        {
            var imageProxy = new HighResImageProxy("path");
            imageProxy.ShowImage();
            imageProxy.ShowImage();

            Assert.IsTrue(imageProxy.Counter == 1);
        }
    }
}