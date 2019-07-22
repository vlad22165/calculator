using System;

namespace Calculator.OneArgumentCalculators
{
    /// <summary>
    /// Calculate ctan
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class CtanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return 1/Math.Tan(first);
        }
    }
}