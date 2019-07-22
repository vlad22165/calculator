namespace Calculator.TwoArgumentsCalculators
{
    public class MultiplicationCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Multiplication
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first * second;

        }
    }
}