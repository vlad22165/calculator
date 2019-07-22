using System;

namespace Calculator.TwoArgumentsCalculators
{
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Max value
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.Max(first, second);
        }
    }
}