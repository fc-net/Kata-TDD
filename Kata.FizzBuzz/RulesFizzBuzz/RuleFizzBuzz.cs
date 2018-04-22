namespace Kata.FizzBuzz.RulesFizzBuzz
{
    public class RuleFizzBuzz : IRule
    {
        public string Value => ConstFizzBuzz.FIZZBUZZ;

        public bool Calculate(int number)
        {
            if (Divisor.IsDivisor(number, 3) && Divisor.IsDivisor(number, 5))
                return true;

            return false;
        }
    }
}
