using System;

namespace Calculator.OneArgumentCalculators
{
    public class SinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);

        }
    }
}