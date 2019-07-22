namespace Calculator.TwoArgumentsCalculators
{
    public class AverageArifmetikCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Average Arifmetik
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first + second / 2;
        }
    }
}