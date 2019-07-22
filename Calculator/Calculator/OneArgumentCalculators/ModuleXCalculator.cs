using System;

namespace Calculator.OneArgumentCalculators
{
    public class ModuleXCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate ModuleX
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}
