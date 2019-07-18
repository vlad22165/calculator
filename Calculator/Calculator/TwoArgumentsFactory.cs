using System;

namespace Calculator
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string operation)
        {
            switch (operation)
            {
                case "add":
                    return new AddCalculator();
                case "subtraction":
                    return new SubtractionCalculator();
                case "multiplication":
                    return new MultiplicationCalculator();
                case "division":
                    return new DivisionCalculator();
                default: throw new Exception(message: "Ошибка");

            }
        }
    }
}