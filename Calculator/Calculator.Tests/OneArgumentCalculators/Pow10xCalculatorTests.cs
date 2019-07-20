using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class Pow10xCalculatorTests
    {


        [TestCase(1, 1)]
        [TestCase(4, 1048576)]
        [TestCase(8, 1073741824)]
        public void CalculateTest(double firstValue, double expected)
        {
            var Calculator = new Pow10XCalculator();
            var result = Calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}