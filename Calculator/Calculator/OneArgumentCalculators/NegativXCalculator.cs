using System;

namespace Calculator.OneArgumentCalculators
{
    /// <summary>
    /// Calculate NegativX
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class NegativXCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return -first;

        }
    }
}