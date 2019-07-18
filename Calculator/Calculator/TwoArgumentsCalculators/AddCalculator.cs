namespace Calculator.TwoArgumentsCalculators
{
    public class AddCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;

        }
    }
}
