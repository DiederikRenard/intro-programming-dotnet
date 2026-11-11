namespace IntroProgramming.Functions;

/// <summary>
/// Exercise 05: multiple return values.
/// Return (smaller, larger).
/// </summary>
public static class Exercise05
{
    public static (int Smaller, int Larger) MinMax(int a, int b)
    {
        // TODO: return the smaller value and the larger value
        if (a < b)
        {
            return (a, b);
        }
        else
        {
            return (b, a);
        }
        throw new NotImplementedException();
    }
}
