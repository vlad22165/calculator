using System;
using Calculator.TwoArgumentsCalculators;

namespace Calculator.OneArgumentCalculators
{
    /// <summary>
    /// One argument Factory
    /// </summary>
    /// <returns></returns>
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "Cos":
                    return new CosCalculator();
                case "Sin":
                    return new SinCalculator();
                case "tan":
                    return new TanCalculator();
                case "Asin":
                    return new ArcsinCalculator();
                case "Acos":
                    return new ArccosCalculator();
                case "ctan":
                    return new CtanCalculator();
                case "atan":
                    return new ArctanCalculator();
                case "e":
                    return new ECalculator();
                case "ln":
                    return new LnCalculator();
                case "log2":
                    return new Log2Calculator();
                case "log10":
                    return new Log10Calculator();
                case "pow10x":
                    return new Pow10XCalculator();
                case "div1x":
                    return new Div1XCalculator();
                case "Abs":
                    return new ModuleXCalculator();
                case "pow2x":
                    return new Pow2xCalculator();
                case "negativx":
                    return new NegativXCalculator();

                default: throw new Exception(message: "Ошибка");
            }
        }
    }
}