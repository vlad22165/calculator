using System;

namespace Calculator.OneArgumentCalculators
{
    /// <summary>
    /// Calculate Log10
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class Log10Calculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first,10);
        }
    }
}