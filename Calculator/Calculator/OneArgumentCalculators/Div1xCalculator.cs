using System;

namespace Calculator.OneArgumentCalculators
{
    public class Div1XCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return 1/(first);
        }
    }
}