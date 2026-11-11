namespace IntroProgramming.Functions;

/// <summary>
/// Exercise 04: optional parameters.
/// Return "{greeting}, {name}!".
/// Greet("Ada") returns "Hello, Ada!". Greet("Ada", "Hi") returns "Hi, Ada!".
/// </summary>
public static class Exercise04
{
    public static string Greet(string name, string greeting = "Hello")
    {
        // TODO: return the greeting
        return $"{greeting}, {name}!";
        throw new NotImplementedException();
    }
}
