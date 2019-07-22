namespace Calculator.TwoArgumentsCalculators
{
    /// <summary>
    /// Calculate Add(Cложение)
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class AddCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;

        }
    }
}
