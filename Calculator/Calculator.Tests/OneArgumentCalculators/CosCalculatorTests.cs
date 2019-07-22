using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class CosCalculatorTests
    {
        [Test]

        public void CalculateTest()

        {

            IOneArgumentCalculator calculator = new CosCalculator();
            double result = calculator.Calculate(1);

            Assert.AreEqual(0.5403, result, 0.0001);

        }

        // ...


    }
}