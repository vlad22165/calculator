using System;

namespace Calculator.OneArgumentCalculators
{
    /// <summary>
    /// Calculate Ln
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class LnCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}