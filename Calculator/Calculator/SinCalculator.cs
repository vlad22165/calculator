using System;

namespace Calculator
{
    public class SinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);

        }
    }
}