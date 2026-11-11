namespace IntroProgramming.VariablesAndDataTypes;

/// <summary>
/// Exercise 05: null.
/// Return null when empty is true, otherwise return any non-null value.
/// </summary>
public static class Exercise05
{
    public static object? MaybeValue(bool empty)
    {
        // TODO: return null or a real value depending on empty
        return empty ? null : new object();
        throw new NotImplementedException();
    }
}
