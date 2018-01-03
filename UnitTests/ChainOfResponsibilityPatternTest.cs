using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class ChainOfResponsibilityPatternTest
    {
        Approver clerk;
        Approver assistantManager;
        Approver manager;
        public ChainOfResponsibilityPatternTest()
        {
            // Setup Chain of Responsibility
            clerk = new Clerk();
            assistantManager = new AssistantManager();
            manager = new Manager();
        }

        [TestMethod]
        public void Test()
        {            
            
        }
    }

    internal class Manager : Approver
    {
    }

    internal class Approver
    {
    }

    internal class AssistantManager : Approver
    {
    }

    internal class Clerk : Approver
    {
    }
}
