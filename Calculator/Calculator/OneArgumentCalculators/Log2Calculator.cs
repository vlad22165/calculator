using System;

namespace Calculator.OneArgumentCalculators
{
    public class Log2Calculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first,2);
        }
    }
}