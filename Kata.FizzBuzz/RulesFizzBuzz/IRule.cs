namespace Kata.FizzBuzz.RulesFizzBuzz
{
    public interface IRule
    {
        string Value { get; }

        bool Calculate(int number);
    }
}
