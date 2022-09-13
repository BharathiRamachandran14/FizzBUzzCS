using System;
using FizzBuzz.Rules;

namespace FizzBuzz
{
    class FizzBuzz
    {
        List<Rule> rules = new List<Rule> { new RuleFor3(), new RuleFor5(), new RuleFor7(), new Rule()}; 
        public string FizzBuzzfor(int n)
        {
            string result="";

            foreach ( Rule rule in rules)
            {
                result =rule.Apply(n,result);
            }

            return result;
        }
    }
}
