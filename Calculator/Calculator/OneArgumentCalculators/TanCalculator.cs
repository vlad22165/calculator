using System;

namespace Calculator.OneArgumentCalculators
{
    /// <summary>
    /// Calculate Tan
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class TanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}