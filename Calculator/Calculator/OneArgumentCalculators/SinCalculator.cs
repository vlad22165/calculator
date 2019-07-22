using System;

namespace Calculator.OneArgumentCalculators
{
    public class SinCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate Sin
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Sin(first);

        }
    }
}