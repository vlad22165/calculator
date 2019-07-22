using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class ECalculatorTests
    {
        [TestCase(1, 2.7182)]
        [TestCase(4, 54.5981)]
        [TestCase(8, 2980.9579)]
        public void CalculateTest(double firstValue, double expected)

        {

            var calculator = new ECalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);

        }

        // ...


    }
}