using Calculator.TwoArgumentsCalculators;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculators
{
    [TestFixture]
    public class AverageGeometrikCalculatorTest
    {
        [TestCase(0, 1, 0)]
        [TestCase(3, 4, 3.4641)]
        [TestCase(-7, -2, 3.7416)]
        public void CalculateTest(double firstValue, double secondValue, double expected)

        {

            var Calculator = new AverageGeometrikCalculator();
            var result = Calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.0001);

        }

        // ...


    }
}