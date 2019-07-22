namespace Calculator.TwoArgumentsCalculators
{
    public class IntegerCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Integer
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return (int)first / (int)second;
        }
    }
}