using System;

namespace Calculator.OneArgumentCalculators
{
    public class ArccosCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate arccos
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
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