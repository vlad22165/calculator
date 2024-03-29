﻿using System;

namespace Calculator.TwoArgumentsCalculators
{
    public static class TwoArgumentsFactory
    {
        /// <summary>
        /// Two Arguments Factory
        /// </summary>
        /// <returns></returns>
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
                case "min":
                    return new MinCalculator();
                case "max":
                    return new MaxCalculator();
                case "averagearifm":
                    return new AverageArifmetikCalculator();
                case "averagegeom":
                    return new AverageGeometrikCalculator();
                case "integer":
                    return new IntegerCalculator();
                default: throw new Exception(message: "Ошибка");

            }
        }
    }
}