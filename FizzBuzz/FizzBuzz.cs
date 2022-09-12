using System;

namespace FizzBuzz
{
    class FizzBuzz
    {
        private static bool IsDivisibleBy(int numerator, int denominator)
        {
            return numerator % denominator == 0;
        }
        public string FizzBuzzfor(int n)
        {
            string result="";

            if (IsDivisibleBy(n,3))
            {
                result += "Fizz";
            }

            if (IsDivisibleBy(n,5))
            {
                result += "Buzz";
            }

            if (IsDivisibleBy(n,7))
            {
                result += "Bang";
            }

            if (IsDivisibleBy(n,11))
            {
                result = "Bong";
            }

            if (result == "")
            {
                result = n.ToString();
            }

            return result;
        }
    }
}
