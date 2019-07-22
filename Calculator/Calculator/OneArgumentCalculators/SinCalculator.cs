using System;

namespace Calculator.OneArgumentCalculators
{
    /// <summary>
    /// Calculate Sin
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class SinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);

        }
    }
}