using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class Log2CalculatorTests
    {

        [TestCase(1, 0)]
        [TestCase(4, 2)]
        [TestCase(8, 3)]
        public void CalculateTest(double firstValue, double expected)

        {

            var calculator = new Log2Calculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);

        }

        // ...

    }
}

