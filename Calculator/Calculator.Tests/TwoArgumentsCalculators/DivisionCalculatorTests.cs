using System;
using Calculator.TwoArgumentsCalculators;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculators
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [Test]

        public void CalculateTest()

        {

            ITwoArgumentsCalculator calculator = new DivisionCalculator();
            double result = calculator.Calculate(1, 2);

            Assert.AreEqual(0.5, result);

        }

        [Test]

        public void DivisionByZeroTest()

        {

            ITwoArgumentsCalculator calculator = new DivisionCalculator();
            double result = calculator.Calculate(1, 2);

            Assert.Throws<Exception>(() =>
                calculator.Calculate(1, 0));


        }


    }

}