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
                    break;
                case "multiplication":
                    return new MultiplicationCalculator();
                    break;
                case "division":
                    return new DivisionCalculator();
                    break;
                default: throw new Exception(message: "Ошибка");

            }
        }
    }
}