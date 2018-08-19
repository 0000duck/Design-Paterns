using Microsoft.VisualStudio.TestTools.UnitTesting;
using Main.Behavioral_Patterns.Interpreter_Pattern;

namespace UnitTests
{
    [TestClass]
    public class InterpreterPatternTest
    {
        [TestMethod]
        public void ShouldPrintCorrectDecimalNumber()
        {
            var input = "MDCCCLIV";
            var expectedResult = 1854;

            var interpreter = new Interpreter();
            var result = interpreter.Conver(input);

            Assert.IsTrue(result == expectedResult);
        }
    }
}
