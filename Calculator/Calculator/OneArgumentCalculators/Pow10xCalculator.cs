using System;

namespace Calculator.OneArgumentCalculators
{
    public class Pow10XCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate Pow10X
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Pow(first, 10);
        }
    }
}