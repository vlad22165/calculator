using System;

namespace Calculator.OneArgumentCalculators
{
    public class ArccosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            /// <summary>
            /// Calculate arccos
            /// </summary>
            /// <param name="first"></param>
            /// <returns></returns>
            if (first < -1 || first > 1)
            {
                throw new Exception("арккосинус");
            }
            return Math.Acos(first);
        }
    }
}