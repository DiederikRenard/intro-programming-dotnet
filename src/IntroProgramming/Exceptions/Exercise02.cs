namespace IntroProgramming.Exceptions;

/// <summary>
/// Exercise 02: a specific exception.
/// Return int.Parse(text). When that throws FormatException, return "Invalid number".
/// </summary>
public static class Exercise02
{
    public static object ParseInt(string text)
    {
        // TODO: try int.Parse(text), catch FormatException
        try
        {
            return int.Parse(text);
        }
        catch (FormatException)
        {
            return "Invalid number";
        }
        throw new NotImplementedException();
    }
}
