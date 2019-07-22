using System;

namespace Calculator.TwoArgumentsCalculators
{
    /// <summary>
    /// Calculate средне-арифметическое
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class AverageArifmetikCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first+second/2;
        }
    }
}