using System.Collections.Generic;

namespace Kata.FizzBuzz.RulesFizzBuzz
{
    public class Rules : List<IRule>
    {
        public Rules()
        {
            Add(new RuleFizzBuzz());
            Add(new RuleFizz());
            Add(new RuleBuzz());
            Add(new RuleDefault());
        }
    }
}
