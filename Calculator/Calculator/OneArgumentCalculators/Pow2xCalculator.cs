using System;

namespace Calculator.OneArgumentCalculators
{
    /// <summary>
    /// Calculate Pow2X
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class Pow2xCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(2,first);
        }
    }
}