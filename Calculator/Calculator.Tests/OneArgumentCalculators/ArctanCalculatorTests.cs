using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class ArctanCalculatorTests
    {
        [TestCase(-1, -0.7853)]
        [TestCase(0, 0)]
        [TestCase(1, 0.7853)]
        public void CalculateTest(double firstValue, double expected)

        {

            var calculator = new ArctanCalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);

        }

        // ...


    }
}