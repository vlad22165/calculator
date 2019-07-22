using System;

namespace Calculator.OneArgumentCalculators
{
    public class Div1XCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate Div1X
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            if (first == 0)
            {
                throw new Exception("Нельзя делить на ноль");
            }
            return 1 / (first);
        }
    }
}