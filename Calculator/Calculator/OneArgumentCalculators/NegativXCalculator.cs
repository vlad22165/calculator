namespace Calculator.OneArgumentCalculators
{
    public class NegativXCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculate NegativX
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return -first;

        }
    }
}