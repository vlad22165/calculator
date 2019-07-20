﻿using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class LnCalculatorTests

    {
            [TestCase(1, 0)]
                [TestCase(4, 1.3862)]
                [TestCase(8,  2.0794)]
            public void CalculateTest(double firstValue, double expected)

            {

                var Calculator = new LnCalculator();
                var result = Calculator.Calculate(firstValue);
                Assert.AreEqual(expected, result, 0.0001);

            }

            // ...


        }
}