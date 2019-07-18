using Calculator.OneArgumentCalculators;
using Calculator.TwoArgumentsCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class SinCalculatorTest
    {
        [Test]

        public void CalculateTest()

        {

            IOneArgumentCalculator Calculator = new SinCalculator();
            double result = Calculator.Calculate(1);

            Assert.AreEqual(0.8414, result, 0.0001);

        }

        // ...


    }
}