using System;

namespace Calculator.TwoArgumentsCalculators
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Division
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
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