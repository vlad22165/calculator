using System;

namespace Calculator.OneArgumentCalculators
{
    /// <summary>
    /// Calculate ModuleX
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class ModuleXCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}
