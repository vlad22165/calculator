using Calculator.TwoArgumentsCalculators;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculators
{
    [TestFixture]
    public class AddCalculatorTests
    {
        [Test]

        public void CalculateTest()

        {

            ITwoArgumentsCalculator calculator=new AddCalculator();
            double result = calculator.Calculate(1,2);

            Assert.AreEqual(3, result);

        }

        // ...


    }
}