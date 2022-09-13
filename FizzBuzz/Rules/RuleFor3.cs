using FizzBuzz.Rules;

namespace FizzBuzz.Rules
{
    class RuleFor3 : Rule
    {
         public override string Apply (int n, string prevResult )
        {
            if(n % 3 == 0)
            {
                return prevResult + "Fizz";
            }
            return prevResult;
        }
    }
}