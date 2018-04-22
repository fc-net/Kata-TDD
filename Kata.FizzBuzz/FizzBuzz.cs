using Kata.FizzBuzz.RulesFizzBuzz;
using System;
using System.Linq;

namespace Kata.FizzBuzz
{
    public class FizzBuzz
    {
        private Rules _rules = new Rules();

        public string Calculate(int number)
        {
            ThrowArgumentOutOfRange(number);

            var result = _rules.FirstOrDefault(x => x.Calculate(number)) ?? throw new ArgumentNullException();

            return result.Value;
        }

        private void ThrowArgumentOutOfRange(int number)
        {
            if (number < 1)
                throw new ArgumentOutOfRangeException();
        }
    }    
}
