using System;

namespace Calculator.OneArgumentCalculators
{
    public class TanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}