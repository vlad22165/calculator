using System;

namespace Calculator.OneArgumentCalculators
{
    public class ArcsinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }
    }
}