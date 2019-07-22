using System;

namespace Calculator.TwoArgumentsCalculators
{
    /// <summary>
    /// Calculate Максимального значения
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Max(first, second);
        }
    }
}