﻿using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class NegativXCalculatorTests
    {
        [TestCase(1, -1)]
        [TestCase(4, -4)]
        [TestCase(8, -8)]
        public void CalculateTest(double firstValue, double expected)

        {

            IOneArgumentCalculator Calculator = new NegativXCalculator();
            var result = Calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);

        }

        // ...


    }
}