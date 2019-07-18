using System;

namespace Calculator.OneArgumentCalculators
{
    public class CosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);

        }
    }
}