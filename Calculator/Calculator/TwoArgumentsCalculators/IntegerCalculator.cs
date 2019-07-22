using System;

namespace Calculator.TwoArgumentsCalculators
{
    /// <summary>
    /// Calculate Integer
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class IntegerCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return (int)first / (int)second;
        }
    }
}