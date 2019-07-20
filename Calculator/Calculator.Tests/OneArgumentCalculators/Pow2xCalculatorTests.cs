using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    public class Pow2xCalculatorTests
    {


        [TestCase(1, 2)]
        [TestCase(4, 16)]
        [TestCase(8, 256)]
        public void CalculateTest(double firstValue, double expected)
        {
            var Calculator = new Pow2xCalculator();
            var result = Calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }

}