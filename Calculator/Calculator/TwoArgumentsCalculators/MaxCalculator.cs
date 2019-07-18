using System;

namespace Calculator.TwoArgumentsCalculators
{
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Max(first, second);
        }
    }
}