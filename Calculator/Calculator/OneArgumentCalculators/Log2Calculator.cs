using System;

namespace Calculator.OneArgumentCalculators
{
    /// <summary>
    /// Calculate Log2
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class Log2Calculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first,2);
        }
    }
}