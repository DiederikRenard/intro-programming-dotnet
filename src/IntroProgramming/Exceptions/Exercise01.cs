namespace IntroProgramming.Exceptions;

/// <summary>
/// Exercise 01: try/catch.
/// Return a / b using integer division.
/// When b is 0, catch DivideByZeroException and return "Cannot divide by zero".
/// </summary>
public static class Exercise01
{
    public static object SafeDivide(int a, int b)
    {
        // TODO: try the division, catch DivideByZeroException
        try
        {
            return a / b;
        }
        catch (DivideByZeroException)
        {
            return "Cannot divide by zero";
        }
        throw new NotImplementedException();
    }
}
