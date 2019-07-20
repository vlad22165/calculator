using System;
using Calculator.OneArgumentCalculators;
using Calculator.TwoArgumentsCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class ArccosCalculatorTests
    {
        [TestCase(-1, 3.1415)]
        [TestCase(0, 1.5707)]
        [TestCase(1, 0)]
        public void CalculateTest(double firstValue, double expected)

        {

            var Calculator = new ArccosCalculator();
            var result = Calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);

        }

        [Test]

        public void ArccosTest()
        {
            IOneArgumentCalculator Calculator = new ArccosCalculator();

            Assert.Throws<Exception>(() =>
                Calculator.Calculate(2));


        }


    }
}