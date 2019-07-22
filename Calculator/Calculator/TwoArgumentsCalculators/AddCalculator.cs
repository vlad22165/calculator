namespace Calculator.TwoArgumentsCalculators
{
    public class AddCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Add
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first + second;

        }
    }
}
