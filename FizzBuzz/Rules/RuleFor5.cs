using FizzBuzz.Rules;

namespace FizzBuzz.Rules
{
    class RuleFor5 : Rule
    {
         public override string Apply (int n, string prevResult )
        {
            if(n % 5 == 0)
            {
                return prevResult += "Buzz";
            }
            return prevResult;
        }
    }
}