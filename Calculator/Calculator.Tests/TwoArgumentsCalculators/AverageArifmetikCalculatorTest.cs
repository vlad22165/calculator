using Calculator.TwoArgumentsCalculators;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculators
{
    [TestFixture]
    public class AverageArifmetikCalculatorTest
    {
        [Test]

            public void CalculateTest()

            {

                ITwoArgumentsCalculator Calculator = new AverageArifmetikCalculator();
                double result = Calculator.Calculate(1, 2);

                Assert.AreEqual(2, result);

            }

            // ...


    }
}