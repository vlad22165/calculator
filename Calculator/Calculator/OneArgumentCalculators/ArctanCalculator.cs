using System;

namespace Calculator.OneArgumentCalculators
{
    public class ArctanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}