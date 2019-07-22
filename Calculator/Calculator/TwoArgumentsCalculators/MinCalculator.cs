using System;

namespace Calculator.TwoArgumentsCalculators
{
    public class MinCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Min value
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.Min(first, second);
        }
    }
}