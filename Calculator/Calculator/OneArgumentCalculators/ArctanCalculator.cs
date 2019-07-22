using System;

namespace Calculator.OneArgumentCalculators
{
    /// <summary>
    /// Calculate arctan
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class ArctanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}