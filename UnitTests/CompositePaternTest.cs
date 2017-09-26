using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Main.Structural_Patterns.Composite_Patern;
using Main.Structural_Patterns.Decorator_Patern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class CompositePaternTest
    {
        [TestMethod]
        public void TestShouldGetProductPriceAndName()
        {
            IItem item = new Product();
            item.Name = "Phone";
            item.Price = 500;
            Assert.AreEqual("Phone", item.Name);
            Assert.AreEqual(500, item.Price);
        }

        [TestMethod]
        public void TestShouldGetBoxPriceAndProductsInsideBox()
        {
            IItem phone1 = new Product();
            phone1.Name = "Sony Phone";
            phone1.Price = 500;   

            IItem phone2 = new Product();
            phone2.Name = "Apple Phone";
            phone2.Price = 1000;
            
            IItem box = new Box() {Name = "Phone Box", Products = { phone1, phone2 }};
            
            Assert.AreEqual("Phone Box", box.Name);
            Assert.AreEqual(1500, box.Price);
        }
    }
}

