using System;
using Calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace Calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class OneArgumentFactoryTests
    {

        [TestCase("Sin", typeof(SinCalculator))]
        [TestCase("Cos", typeof(CosCalculator))]
        [TestCase("tan", typeof(TanCalculator))]
        [TestCase("atan", typeof(ArctanCalculator))]
        [TestCase("Asin", typeof(ArcsinCalculator))]
        [TestCase("Acos", typeof(ArccosCalculator))]
        [TestCase("ctan", typeof(CtanCalculator))]
        [TestCase("div1x", typeof(Div1XCalculator))]
        [TestCase("e", typeof(ECalculator))]
        [TestCase("ln", typeof(LnCalculator))]
        [TestCase("log10", typeof(Log10Calculator))]
        [TestCase("log2", typeof(Log2Calculator))]
        [TestCase("Abs", typeof(ModuleXCalculator))]
        [TestCase("negativx", typeof(NegativXCalculator))]
        [TestCase("pow10x", typeof(Pow10XCalculator))]
        [TestCase("pow2x", typeof(Pow2XCalculator))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }


        //
    }
}