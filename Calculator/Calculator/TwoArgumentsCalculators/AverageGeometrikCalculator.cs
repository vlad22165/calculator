using System;

namespace Calculator.TwoArgumentsCalculators
{
    public class AverageGeometrikCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Sqrt(first * second);
        }
    }
}