using Calculator.OneArgumentCalculators;
using Calculator.TwoArgumentsCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class TanCalculatorTest
    {
        [TestCase(1, 0.7853)]
        [TestCase(3, 1.2490)]
        [TestCase(7, 1.4288)]
        public void CalculateTest(double firstValue, double expected)

        {

            var Calculator = new TanCalculator();
            var result = Calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);

        }

        // ...


    }
}