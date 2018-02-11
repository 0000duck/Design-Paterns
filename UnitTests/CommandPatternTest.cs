using Main.Behavioral_Patterns.Command_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class CommandPatternTest
    {
        [TestMethod]
        public void TestCommands()
        {
            Light lamp = new Light();
            ICommand switchUp = new FlipUpCommand(lamp);
            ICommand switchDown = new FlipDownCommand(lamp);

            Switch s = new Switch();

            s.StoreAndExecute(switchUp);
            Assert.IsTrue(lamp.isLightOn);

            s.StoreAndExecute(switchDown);
            Assert.IsFalse(lamp.isLightOn);
        }
    }
}
