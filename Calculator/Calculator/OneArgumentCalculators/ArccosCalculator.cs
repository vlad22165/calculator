using System;

namespace Calculator.OneArgumentCalculators
{
    public class ArccosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            if (first<-1 || first>1)
            {
                throw new Exception("арккосинус");
            }
            return Math.Acos(first);
        }
    }
}