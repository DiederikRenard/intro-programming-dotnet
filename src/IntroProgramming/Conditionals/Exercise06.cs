namespace IntroProgramming.Conditionals;

/// <summary>
/// Exercise 06: multiple conditions.
/// Return true when x is greater than 0 and less than 10, or x equals 100.
/// </summary>
public static class Exercise06
{
    public static bool Matches(int x)
    {
        // TODO: return whether x is between 0 and 10 (exclusive) or equal to 100
        return (x > 0 && x < 10) || x == 100;
        throw new NotImplementedException();
    }
}
