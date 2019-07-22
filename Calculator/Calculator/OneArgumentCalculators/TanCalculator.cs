using System;

namespace Calculator.OneArgumentCalculators
{
    public class TanCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate Tan
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}