using System;

namespace Calculator.OneArgumentCalculators
{
    public class ArcsinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            if (first < -1 || first > 1)
            {
                throw new Exception("арксинус");
            }
            return Math.Asin(first);
        }
    }
}