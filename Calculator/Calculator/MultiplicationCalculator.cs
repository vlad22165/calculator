﻿namespace Calculator
{
    public class MultiplicationCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first * second;

        }
    }
}