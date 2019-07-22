using Calculator.TwoArgumentsCalculators;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculators
{
    [TestFixture]
    public class MultiplicationCalculatorTests
    {
        [Test]

        public void CalculateTest()

        {

            ITwoArgumentsCalculator calculator = new MultiplicationCalculator();
            double result = calculator.Calculate(1, 2);

            Assert.AreEqual(2, result);

        }

        // ...


    }
}