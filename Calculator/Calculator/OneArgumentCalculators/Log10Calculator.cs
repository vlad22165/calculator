using System;

namespace Calculator.OneArgumentCalculators
{
    public class Log10Calculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first,10);
        }
    }
}