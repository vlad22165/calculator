using System;

namespace Calculator
{
    public class CosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);

        }
    }
}