using System;

namespace Calculator.OneArgumentCalculators
{
    public class LnCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}