using System;

namespace Calculator.OneArgumentCalculators
{
    public class ECalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate E
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Pow(Math.E, first);
        }
    }
}