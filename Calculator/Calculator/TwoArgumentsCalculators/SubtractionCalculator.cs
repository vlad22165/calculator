namespace Calculator.TwoArgumentsCalculators
{
    /// <summary>
    /// Calculate Вычитание
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public class SubtractionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first - second;

        }
    }
}