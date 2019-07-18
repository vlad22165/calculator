using System;

namespace Calculator.TwoArgumentsCalculators
{
    public class IntegerCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return (int)first / (int)second;
        }
    }
}