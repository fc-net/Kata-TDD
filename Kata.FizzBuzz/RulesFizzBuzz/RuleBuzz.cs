namespace Kata.FizzBuzz.RulesFizzBuzz
{
    public class RuleBuzz : IRule
    {
        public string Value => ConstFizzBuzz.BUZZ;

        public bool Calculate(int number)
        {
            if (Divisor.IsDivisor(number, 5))
                return true;

            return false;
        }
    }
}
