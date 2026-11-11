namespace IntroProgramming.Conditionals;

/// <summary>
/// Exercise 03: if / else if / else.
/// Score is from 0 to 100.
/// A: 90-100, B: 80-89, C: 70-79, D: 60-69, F: 0-59.
/// </summary>
public static class Exercise03
{
    public static string LetterGrade(int score)
    {
        // TODO: return "A", "B", "C", "D", or "F"
        if (score >= 90)
        {
            return "A";
        }
        else if (score >= 80)
        {
            return "B";
        }
        else if (score >= 70)
        {
            return "C";
        }
        else if (score >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
        throw new NotImplementedException();
    }
}
