namespace IntroProgramming.Collections;

/// <summary>
/// Exercise 04: tuple deconstruction.
/// Unpack a 3-tuple into three variables and return them.
/// </summary>
public static class Exercise04
{
    public static (T First, T Second, T Third) Unpack<T>((T First, T Second, T Third) values)
    {
        // TODO: var (first, second, third) = values; return them
        var (first, second, third) = values;
        return (first, second, third);
        throw new NotImplementedException();
    }
}
