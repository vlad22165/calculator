using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class SinCalculatorTest
    {
        [Test]

        public void CalculateTest()

        {

            IOneArgumentCalculator calculator = new SinCalculator();
            double result = calculator.Calculate(1);

            Assert.AreEqual(0.8414, result, 0.0001);

        }

        // ...


    }
}