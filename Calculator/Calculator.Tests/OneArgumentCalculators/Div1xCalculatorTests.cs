using System;
using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class Div1XCalculatorTests
    {
        [TestCase(1, 1)]
        [TestCase(4, 0.25)]
        [TestCase(8, 0.125)]
        public void CalculateTest(double firstValue, double expected)

        {

            var calculator = new Div1XCalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);

        }

        [Test]

        public void Div1XTest()
        {
            IOneArgumentCalculator calculator = new Div1XCalculator();

            Assert.Throws<Exception>(() =>
                calculator.Calculate(0));


        }


    }
}