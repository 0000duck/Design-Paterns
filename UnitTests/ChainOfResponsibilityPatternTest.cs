using Main.Behavioral_Patterns.Chain_of_Resp_Pattern;
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
        IRequestHandler cashier;
        IRequestHandler manager;
        
        public ChainOfResponsibilityPatternTest()
        {
            // Setup Chain of Responsibility            
            manager = new Manager() { };
            cashier = new Cashier() { Successor = manager };
        }

        [TestMethod]
        public void RequestShouldBeDenied()
        {
            var request = new LoanRequest() { Amount = 50000 };
            var status = cashier.HandleRequest(request);
            Assert.IsTrue(ApprovalStatus.Denied == status);
        }

        [TestMethod]
        public void RequestShouldBeApproved()
        {
            var request = new LoanRequest() { Amount = 500 };
            var status = cashier.HandleRequest(request);
            Assert.IsTrue(ApprovalStatus.Approved == status);
        }

        [TestMethod]
        public void RequestShouldBeApproved2()
        {
            var request = new LoanRequest() { Amount = 5000 };
            var status = cashier.HandleRequest(request);
            Assert.IsTrue(ApprovalStatus.Approved == status);
        }
    }
}
