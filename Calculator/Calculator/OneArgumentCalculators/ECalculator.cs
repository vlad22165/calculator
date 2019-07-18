using System;

namespace Calculator.OneArgumentCalculators
{
    public class ECalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(Math.E,first);
        }
    }
}