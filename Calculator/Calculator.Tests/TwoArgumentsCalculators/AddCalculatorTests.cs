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

            ITwoArgumentsCalculator Calculator=new AddCalculator();
            double result = Calculator.Calculate(1,2);

            Assert.AreEqual(3, result);

        }

        // ...


    }
}