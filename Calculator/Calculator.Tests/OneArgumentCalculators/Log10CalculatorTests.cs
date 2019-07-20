using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class Log10CalculatorTests
    {

        [TestCase(1, 0)]
        [TestCase(4, 0.6020)]
        [TestCase(8, 0.9030)]
        public void CalculateTest(double firstValue, double expected)

        {

            var Calculator = new Log10Calculator();
            var result = Calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);

        }

        // ...

    }
}