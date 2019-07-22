using System;

namespace Calculator.OneArgumentCalculators
{
    public class Log10Calculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate Log10
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Log(first, 10);
        }
    }
}