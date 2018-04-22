namespace Kata.FizzBuzz.RulesFizzBuzz
{
    public class RuleFizz : IRule
    {
        public string Value => ConstFizzBuzz.FIZZ;

        public bool Calculate(int number)
        {
            if (Divisor.IsDivisor(number, 3))
                return true;

            return false;
        }
    }
}
