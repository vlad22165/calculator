using Calculator.TwoArgumentsCalculators;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculators
{
    [TestFixture]
    public class AverageGeometrikCalculatorTests
    {
        [Test]

        public void CalculateTest()

        {

            ITwoArgumentsCalculator Calculator = new AverageGeometrikCalculator();
            double result = Calculator.Calculate(1, 2);

            Assert.AreEqual(1.4142, result, 0.0001);

        }

        // ...


    }
}