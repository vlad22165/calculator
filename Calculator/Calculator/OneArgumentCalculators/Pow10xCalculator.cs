using System;

namespace Calculator.OneArgumentCalculators
{
    /// <summary>
    /// Calculate Pow10X
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class Pow10XCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(first, 10);
        }
    }
}