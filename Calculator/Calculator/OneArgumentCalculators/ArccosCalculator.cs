using System;

namespace Calculator.OneArgumentCalculators
{
    public class ArccosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }
}