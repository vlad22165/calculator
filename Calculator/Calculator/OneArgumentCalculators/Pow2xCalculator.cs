using System;

namespace Calculator.OneArgumentCalculators
{
    public class Pow2XCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate Pow2X
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Pow(2, first);
        }
    }
}