using System;

namespace Calculator.OneArgumentCalculators
{
    public class Pow10XCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(first, 10);
        }
    }
}