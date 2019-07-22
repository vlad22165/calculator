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

            ITwoArgumentsCalculator calculator = new SubtractionCalculator();
            double result = calculator.Calculate(1, 2);

            Assert.AreEqual(-1, result);

        }

        // ...


    }
}