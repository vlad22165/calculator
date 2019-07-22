using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class TanCalculatorTests
    {
        [Test]

        public void CalculateTest()

        {

            IOneArgumentCalculator calculator = new TanCalculator();
            double result = calculator.Calculate(1);

            Assert.AreEqual(0.7853, result, 0.0001);

        }

        // ...


    }
}