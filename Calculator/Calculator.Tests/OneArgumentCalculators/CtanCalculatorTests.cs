using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class CtanCalculatorTests
    {
        [TestCase(-1, -0.6420)]
        [TestCase(0.5, 1.8304)]
        [TestCase(1, 0.6420)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new CtanCalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);
        }

        // ...


    }
}