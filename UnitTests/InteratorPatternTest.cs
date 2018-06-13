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
        [TestMethod]
        public void ShouldInterateContainer()
        {
            ConcreteAggregate aggr = new ConcreteAggregate();
            aggr.Add("One");
            aggr.Add("Two");
            aggr.Add("Three");
            aggr.Add("Four");
            aggr.Add("Five");

            Iterator iterator = aggr.CreateIterator();
            while (iterator.Next())
            {
                string item = (string)iterator.Current;
                    Console.WriteLine(item);
            }            
        }
    }
}