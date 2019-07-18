using Calculator.TwoArgumentsCalculators;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculators
{
    [TestFixture]
    public class SubtractionCalculatorTests
    {
        [Test]

        public void CalculateTest()

        {

            ITwoArgumentsCalculator Calculator = new SubtractionCalculator();
            double result = Calculator.Calculate(1, 2);

            Assert.AreEqual(-1, result);

        }

        // ...


    }
}