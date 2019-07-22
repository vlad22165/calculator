namespace Calculator.TwoArgumentsCalculators
{
    /// <summary>
    /// Calculate Умножения
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class MultiplicationCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first * second;

        }
    }
}