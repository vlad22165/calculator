using System;

namespace Calculator.OneArgumentCalculators
{
    public class ArctanCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate arctan
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}