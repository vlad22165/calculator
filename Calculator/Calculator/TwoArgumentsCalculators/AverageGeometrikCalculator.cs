using System;

namespace Calculator.TwoArgumentsCalculators
{
    /// <summary>
    /// Calculate Средне-геометрическое
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class AverageGeometrikCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Sqrt(first * second);
        }
    }
}