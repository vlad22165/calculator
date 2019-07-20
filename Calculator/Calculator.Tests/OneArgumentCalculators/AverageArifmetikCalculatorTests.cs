using Calculator.OneArgumentCalculators;
using Calculator.TwoArgumentsCalculators;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculators
{
    [TestFixture]
    public class AverageArifmetikCalculatorTests
    {
        [TestCase(0, 1, 0.5)]
        [TestCase(3, 4, 5)]
        [TestCase(-7, -2, -8)]
        public void CalculateTest(double firstValue, double secondValue, double expected)

        {

            var Calculator = new AverageArifmetikCalculator();
            var result = Calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }

        // ...


    }
}