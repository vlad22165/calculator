using System;
using Calculator.OneArgumentCalculators;

namespace Calculator.TwoArgumentsCalculators
{
    /// <summary>
    /// Calculate Максимальное значение
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class MinCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Min(first, second);
        }
    }
}