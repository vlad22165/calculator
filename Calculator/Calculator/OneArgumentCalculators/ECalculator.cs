using System;

namespace Calculator.OneArgumentCalculators
{
    /// <summary>
    /// Calculate E
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class ECalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(Math.E,first);
        }
    }
}