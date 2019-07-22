using System;

namespace Calculator.OneArgumentCalculators
{
    public class Log2Calculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate Log2
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Log(first, 2);
        }
    }
}