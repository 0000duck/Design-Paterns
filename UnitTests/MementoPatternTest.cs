using Main.Behavioral_Patterns.Memento_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class MementoPatternTest
    {
        [TestMethod]
        public void ShouldUndoChanges()
        {
            //Here's a new supplier for our restaurant
            FoodSupplier s = new FoodSupplier();
            s.Name = "Tom";
            s.Phone = "666";
            s.Address = "Fleet street";
            
            SupplierMemory m = new SupplierMemory();
            m.Memento = s.SaveMemento();

            s.Name = "Peter";
            s.Phone = "888";
            s.Address = "Cannon street";

            Assert.IsTrue(s.Name == "Peter");
            Assert.IsTrue(s.Phone == "888");
            Assert.IsTrue(s.Address == "Cannon street");

            s.RestoreMemento(m.Memento);

            Assert.IsTrue(s.Name == "Tom");
            Assert.IsTrue(s.Phone == "666");
            Assert.IsTrue(s.Address == "Fleet street");
        }
    }






}
