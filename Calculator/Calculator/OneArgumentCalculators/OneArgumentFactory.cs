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
                default: throw new Exception(message: "Ошибка");

            }
        }
    }
}