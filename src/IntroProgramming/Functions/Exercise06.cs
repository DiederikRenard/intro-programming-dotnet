namespace IntroProgramming.Functions;

/// <summary>
/// Exercise 06: scope.
/// Keep the shared X at 10.
/// ReadLocalX returns a different local value.
/// ReadGlobalX returns the shared X.
/// </summary>
public static class Exercise06
{
    public static int X = 10;

    public static int ReadLocalX()
    {
        // TODO: declare a local x that is not 10, and return it
        int x = 20;
        return x;
        throw new NotImplementedException();
    }

    public static int ReadGlobalX()
    {
        // TODO: return the shared X
        return X;
        throw new NotImplementedException();
    }
}
