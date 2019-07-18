using Calculator.TwoArgumentsCalculators;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculators
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [Test]

        public void CalculateTest()

        {

            ITwoArgumentsCalculator Calculator = new DivisionCalculator();
            double result = Calculator.Calculate(1, 2);

            Assert.AreEqual(0.5, result);

        }

        // ...


    }
}