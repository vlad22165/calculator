using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class Pow10XCalculatorTests
    {


        [TestCase(1, 1)]
        [TestCase(4, 1048576)]
        [TestCase(8, 1073741824)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Pow10XCalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }
}