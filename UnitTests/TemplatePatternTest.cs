using Main.Behavioral_Patterns.Template_Method_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class TemplatePatternTest
    {
        ScoringAlgorithm algorithm;

        [TestMethod]
        public void TestShouldShouldGenerateMensScoring()
        {
            algorithm = new MensScoringAlgorithm();
            var result = algorithm.GenerateScore(8, new TimeSpan(0, 1, 31));
            Assert.AreEqual(782, result);
        }

        [TestMethod]
        public void TestShouldShouldGenerateWomensScoring()
        {
            algorithm = new WomensScoringAlgorithm();
            var result = algorithm.GenerateScore(9, new TimeSpan(0, 1, 49));
            Assert.AreEqual(873, result);
        }
    }
}
