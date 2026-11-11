namespace IntroProgramming.Conditionals;

/// <summary>
/// Exercise 04: nested conditions.
/// Return "positive even", "positive odd", or "not positive".
/// </summary>
/// I am going to assume 0 is considered not positive.
public static class Exercise04
{
    public static string Classify(int n)
    {
        // TODO: return one of the three labels using nested ifs
        if (n > 0)
        {
            if (n % 2 == 0)
            {
                return "positive even";
            }
            else
            {
                return "positive odd";
            }
        }
        else
            {
                return "not positive";
            }
        
        // throw new NotImplementedException();
    }
}
