using System;

namespace Calculator.OneArgumentCalculators
{
    /// <summary>
    /// Calculate cos
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class CosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);

        }
    }
}