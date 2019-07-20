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

            ITwoArgumentsCalculator Calculator = new IntegerCalculator();
            double result = Calculator.Calculate(1, 2);

            Assert.AreEqual(0, result);

        }

        // ...


    }
}