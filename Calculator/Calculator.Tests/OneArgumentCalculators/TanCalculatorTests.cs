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

            IOneArgumentCalculator Calculator = new TanCalculator();
            double result = Calculator.Calculate(1);

            Assert.AreEqual(0.7853, result, 0.0001);

        }

        // ...


    }
}