namespace Calculator
{
    public class SubtractionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first - second;

        }
    }
}