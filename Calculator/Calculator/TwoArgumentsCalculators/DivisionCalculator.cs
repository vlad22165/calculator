using System;

namespace Calculator.TwoArgumentsCalculators
{
    /// <summary>
    /// Calculate Деление и деление на ноль
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на ноль");
            }
            return first / second;

        }
    }
}