namespace IntroProgramming.Operators;

/// <summary>
/// Exercise 04: assignment operators.
/// Apply += 5, then -= 3, then *= 2.
/// Return the value after each of those three operations.
/// Example: ApplyAssignments(10) returns [15, 12, 24].
/// </summary>
public static class Exercise04
{
    public static List<int> ApplyAssignments(int x)
    {
        // TODO: update x with +=, -=, and *=, and collect each result
        var results = new List<int>();
        x += 5;
        results.Add(x);
        x -= 3;
        results.Add(x);
        x *= 2;
        results.Add(x);
        return results;
        throw new NotImplementedException();
    }
}
