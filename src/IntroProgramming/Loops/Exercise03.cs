namespace IntroProgramming.Loops;

/// <summary>
/// Exercise 03: while loop.
/// Count down from 5 to 0 inclusive and return [5, 4, 3, 2, 1, 0].
/// </summary>
public static class Exercise03
{
    public static List<int> Countdown()
    {
        // TODO: return [5, 4, 3, 2, 1, 0] using while
        var countdownList = new List<int>();
        int i = 5;
        while (i >= 0)
        {
            countdownList.Add(i);
            i--;
        }

        return countdownList;
    }
}
