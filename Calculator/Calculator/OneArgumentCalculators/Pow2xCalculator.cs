using System;

namespace Calculator.OneArgumentCalculators
{
    public class Pow2xCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(2,first);
        }
    }
}