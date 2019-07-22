using System;
using Calculator.TwoArgumentsCalculators;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentsCalculators
{
    public class TwoArgumentsFactoryTests
    {
        [TestCase("add", typeof(AddCalculator))]
        [TestCase("averagearifm", typeof(AverageArifmetikCalculator))]
        [TestCase("averagegeom", typeof(AverageGeometrikCalculator))]
        [TestCase("division", typeof(DivisionCalculator))]
        [TestCase("integer", typeof(IntegerCalculator))]
        [TestCase("max", typeof(MaxCalculator))]
        [TestCase("min", typeof(MinCalculator))]
        [TestCase("multiplication", typeof(MultiplicationCalculator))]
        [TestCase("subtraction", typeof(SubtractionCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }


        //
    }
}