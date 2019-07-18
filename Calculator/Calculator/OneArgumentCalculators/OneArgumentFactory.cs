using System;

namespace Calculator.OneArgumentCalculators
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "Cos":
                    return new SinCalculator();
                case "Sin":
                    return new CosCalculator();
                case "tan":
                    return new TanCalculator();
                case "Asin":
                    return new TanCalculator();
                case "Acos":
                    return new TanCalculator();
                case "ctan":
                    return new TanCalculator();
                case "atan":
                    return new TanCalculator();
                case "e":
                    return new TanCalculator();
                case "ln":
                    return new TanCalculator();
                case "log2":
                    return new TanCalculator();
                case "log10":
                    return new TanCalculator();
                case "pow10x":
                    return new TanCalculator();
                case "div1x":
                    return new TanCalculator();
                case "Abs":
                    return new TanCalculator();
                case "pow2x":
                    return new TanCalculator();

                default: throw new Exception(message: "Ошибка");
            }
        }
    }
}