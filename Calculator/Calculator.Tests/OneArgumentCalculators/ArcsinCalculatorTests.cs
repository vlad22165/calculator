﻿using System;
using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class ArcsinCalculatorTests
    {
        [TestCase(-1, -1.5707)]
        [TestCase(0, 0)]
        [TestCase(1, 1.5707)]
        public void CalculateTest(double firstValue, double expected)

        {

            var calculator = new ArcsinCalculator();
            var result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result, 0.0001);

        }

        [Test]

        public void ArcSinTest()
        {
            IOneArgumentCalculator calculator = new ArcsinCalculator();

            Assert.Throws<Exception>(() =>
                calculator.Calculate(2));


        }


    }
}