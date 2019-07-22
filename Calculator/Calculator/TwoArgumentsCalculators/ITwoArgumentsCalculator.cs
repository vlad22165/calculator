namespace Calculator.TwoArgumentsCalculators
{
    /// <summary>
    /// Calculate Two Arguments Interface
    /// </summary>
    /// <param name="first"></param>
    /// <returns></returns>
    public interface ITwoArgumentsCalculator
    {
        double Calculate(double first, double second);
    }
}