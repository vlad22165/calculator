using System;

namespace Calculator.OneArgumentCalculators
{

    public class CtanCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate ctan
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return 1 / Math.Tan(first);
        }
    }
}