using Main.Structural_Patterns.Bridge_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class BridgePatternTest
    {
        [TestMethod]
        public void TestCoachNameShouldBeInStandartText()
        {
            IFormater formater = new StandartFormater();
            var coach = new Coach(formater);
            coach.Name = "Steve Kerr";

            var result = coach.Print();

            Assert.AreEqual("Steve Kerr", result);
        }

        [TestMethod]
        public void TestCoachNameShouldBeWithStars()
        {
            IFormater formater = new StarsFormater();
            var coach = new Coach(formater);
            coach.Name = "Steve Kerr";

            var result = coach.Print();

            Assert.AreEqual("*Steve Kerr*", result);
        }

        [TestMethod]
        public void TestPlayerNameShouldBeInStandartText()
        {
            IFormater formater = new StandartFormater();
            var player = new Player(formater);
            player.Name = "Ricky Rubio";

            var result = player.Print();

            Assert.AreEqual("Ricky Rubio", result);
        }

        [TestMethod]
        public void TestPlayerNameShouldBeWithStars()
        {
            IFormater formater = new StarsFormater();
            var player = new Player(formater);
            player.Name = "Ricky Rubio";

            var result = player.Print();

            Assert.AreEqual("*Ricky Rubio*", result);
        }

        [TestMethod]
        public void TestPlayerShouldBePrintedInStandartAndCoachInStars()
        {
            IFormater starsFormater = new StarsFormater();
            IFormater standartFormater = new StandartFormater();

            IList<ITeamMember> teamMembers = new List<ITeamMember>();

            var player = new Player(standartFormater);
            player.Name = "Ricky Rubio";
            teamMembers.Add(player);
            var coach = new Coach(starsFormater);
            coach.Name = "Steve Kerr";
            teamMembers.Add(coach);

            var result = "";
            foreach (var teamMember in teamMembers)
            {
                result += teamMember.Print();
            }

            Assert.AreEqual("Ricky Rubio*Steve Kerr*", result);
        }
    }




}
