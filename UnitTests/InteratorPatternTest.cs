using Main.Behavioral_Patterns.Iterator_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class InteratorPatternTest
    {
        ConcreteAggregate _aggr = new ConcreteAggregate();
        [TestInitialize]
        public void Init()
        {            
            _aggr.Add("One");
            _aggr.Add("Two");
            _aggr.Add("Three");            
        }
        [TestMethod]
        public void ShouldInterateContainer()
        {
            Iterator iterator = _aggr.CreateIterator();
            iterator.Next();
            string item = (string)iterator.Current;
            Assert.AreEqual(item, "One");
            iterator.Next();
            item = (string)iterator.Current;
            Assert.AreEqual(item, "Two");
            iterator.Next();
            item = (string)iterator.Current;
            Assert.AreEqual(item, "Three");
            Assert.IsFalse(iterator.Next());
        }
    }
}