namespace Kata.FizzBuzz.RulesFizzBuzz
{
    public class RuleDefault : IRule
    {
        private string _value;

        public string Value => _value;

        public bool Calculate(int number)
        {
            _value = number.ToString();

            return true;
        }
    }
}
