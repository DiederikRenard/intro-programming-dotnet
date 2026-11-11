namespace IntroProgramming.Loops;

/// <summary>
/// Exercise 04: break.
/// Append each value until you see "stop", then break.
/// Do not include "stop".
/// </summary>
public static class Exercise04
{
    public static List<string> CollectUntilStop(IEnumerable<string> items)
    {
        // TODO: return the items before "stop"
        var collectedItems = new List<string>();
        foreach (var item in items)
        {
            if (item == "stop")
            {
                break;
            }
            collectedItems.Add(item);
        }

        return collectedItems;
    }
}
