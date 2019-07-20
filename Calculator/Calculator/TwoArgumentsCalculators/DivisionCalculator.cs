using System;

namespace Calculator.TwoArgumentsCalculators
{
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