namespace Calculator.TwoArgumentsCalculators
{
    public class SubtractionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Substraction
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first - second;

        }
    }
}