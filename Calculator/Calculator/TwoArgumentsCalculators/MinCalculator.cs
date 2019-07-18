using System;
using Calculator.OneArgumentCalculators;

namespace Calculator.TwoArgumentsCalculators
{
    public class MinCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Min(first, second);
        }
    }
}