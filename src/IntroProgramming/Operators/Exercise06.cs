namespace IntroProgramming.Operators;

/// <summary>
/// Exercise 06: operator precedence.
/// Return (2 + 3 * 4, (2 + 3) * 4).
/// The first value uses default precedence. The second uses parentheses.
/// </summary>
public static class Exercise06
{
    public static (int DefaultPrecedence, int WithParentheses) PrecedenceDemo()
    {
        // TODO: return (2 + 3 * 4, (2 + 3) * 4)
        return (2 + 3 * 4, (2 + 3) * 4);
        throw new NotImplementedException();
    }
}
