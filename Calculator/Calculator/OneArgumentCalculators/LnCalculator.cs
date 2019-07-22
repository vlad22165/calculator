using System;

namespace Calculator.OneArgumentCalculators
{
    public class LnCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate Ln
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}