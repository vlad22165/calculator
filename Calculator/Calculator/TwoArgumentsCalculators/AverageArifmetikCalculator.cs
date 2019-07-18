using System;

namespace Calculator.TwoArgumentsCalculators
{
    public class AverageArifmetikCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first+second/2;
        }
    }
}