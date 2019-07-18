using System;

namespace Calculator.OneArgumentCalculators
{
    public class NegativXCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return -first;

        }
    }
}