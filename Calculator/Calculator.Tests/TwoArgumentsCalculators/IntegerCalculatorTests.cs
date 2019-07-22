using Calculator.TwoArgumentsCalculators;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculators
{
    [TestFixture]
    public class IntegerCalculatorTests
    {
        [Test]

        public void CalculateTest()

        {

            ITwoArgumentsCalculator calculator = new IntegerCalculator();
            double result = calculator.Calculate(1, 2);

            Assert.AreEqual(0, result);

        }

        // ...


    }
}