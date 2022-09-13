using FizzBuzz.Rules;

namespace FizzBuzz.Rules
{
    class RuleFor7 : Rule
    {
         public override string Apply (int n, string prevResult )
        {
            if(n % 7 == 0)
            {
                return prevResult += "Bang";
            }
            return prevResult;
        }
    }
}