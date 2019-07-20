using System;
using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class Div1xCalculatorTests
    {
        [TestCase(1, 1)]
        [TestCase(4, 0.25)]
        [TestCase(8, 0.125)]
        public void CalculateTest(double firstValue, double expected)

        {

            var Calculator = new Div1XCalculator();
            var result = Calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);

        }

        [Test]

        public void Div1xTest()
        {
            IOneArgumentCalculator Calculator = new Div1XCalculator();

            Assert.Throws<Exception>(() =>
                Calculator.Calculate(0));


        }


    }
}