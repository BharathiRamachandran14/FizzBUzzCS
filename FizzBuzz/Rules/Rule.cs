namespace FizzBuzz.Rules
{
    class Rule
    {
        public virtual string Apply (int n, string prevResult )
        {
            if(prevResult == "")
            {
                return n.ToString();
            }
            
            return prevResult;
        }
    }
}