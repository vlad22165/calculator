using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    public class Pow2XCalculatorTests
    {


        [TestCase(1, 2)]
        [TestCase(4, 16)]
        [TestCase(8, 256)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Pow2XCalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);
        }
    }

}