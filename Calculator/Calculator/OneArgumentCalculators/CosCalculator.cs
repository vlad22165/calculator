using System;

namespace Calculator.OneArgumentCalculators
{
    public class CosCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate cos
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Cos(first);

        }
    }
}