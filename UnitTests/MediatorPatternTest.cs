using Main.Behavioral_Patterns.Mediator_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class MediatorPatternTest
    {
        [TestMethod]
        public void ShouldReceiveCorrectMessages()
        {
            IMediator chatMediator = new ChatMediator();
            // create users and add them to chat mediator's user list
            IUser john = new User(chatMediator, "John");
            IUser tina = new User(chatMediator, "Tina");
            IUser lara = new User(chatMediator, "Lara");
            chatMediator.AddUser(john);
            chatMediator.AddUser(tina);
            chatMediator.AddUser(lara);
            // send message
            lara.SendMessage("Hello!");

            Assert.IsTrue(lara.Name == "Lara");
            Assert.IsNull(lara.Message);
            Assert.IsTrue(john.Message == "Hello!");
            Assert.IsTrue(john.Name == "John");            
            Assert.IsTrue(tina.Message == "Hello!");
            Assert.IsTrue(tina.Name == "Tina");
        }
    }
}
