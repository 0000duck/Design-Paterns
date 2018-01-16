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
    public class MediatorPatternTest
    {
        [TestMethod]
        public void Test()
        {
            
        }
    }

    public abstract class Group
    {
        protected IMediator _mediator;

        public Group(IMediator mediator)
        {
            _mediator = mediator;
        }
    }

    public class GroupA : Group
    {
        public GroupA(IMediator mediator) : base(mediator) { }

        public void Send(string msg)
        {
            _mediator.SendMessage(this, msg);
        }

        public void Receive(string msg)
        {
            Console.WriteLine("A receive message:" + msg);
        }
    }

    public class GroupB : Group
    {
        public GroupB(IMediator mediator) : base(mediator) { }

        public void Send(string msg)
        {
            _mediator.SendMessage(this, msg);
        }

        public void Receive(string msg)
        {
            Console.WriteLine("B receive message:" + msg);
        }
    }

    public interface IMediator
    {
        void SendMessage(Group caller, string msg);
    }

    public class ChatRoom : IMediator
    {
        public GroupA Colleague1 { get; set; }

        public GroupB Colleague2 { get; set; }

        public void SendMessage(Group caller, string msg)
        {
            if (caller == Colleague1)
                Colleague2.Receive(msg);
            else
                Colleague1.Receive(msg);
        }
    }

}
