using System;

namespace Calculator.OneArgumentCalculators
{
    public class CtanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return 1/Math.Tan(first);
        }
    }
}