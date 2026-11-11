namespace IntroProgramming.VariablesAndDataTypes;

/// <summary>
/// Exercise 03: booleans.
/// Return (and, or, not isStudent), in that order.
/// </summary>
public static class Exercise03
{
    public static (bool And, bool Or, bool NotStudent) CombineFlags(bool isStudent, bool hasPassed)
    {
        // TODO: return (andResult, orResult, notStudent)
        return (isStudent && hasPassed, isStudent || hasPassed, !isStudent);
        throw new NotImplementedException();
    }
}
