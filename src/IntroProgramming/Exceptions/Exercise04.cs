namespace IntroProgramming.Exceptions;

/// <summary>
/// Exercise 04: throw.
/// When n is negative, throw ArgumentException with message "Number must not be negative".
/// Otherwise return n. Zero is allowed.
/// </summary>
public static class Exercise04
{
    public static int RequirePositive(int n)
    {
        // TODO: throw ArgumentException for a negative n, otherwise return n
        if (n < 0)
        {
            throw new ArgumentException("Number must not be negative");
        }
        return n;
    }
}
