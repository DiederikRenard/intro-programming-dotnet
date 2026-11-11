namespace IntroProgramming.Loops;

/// <summary>
/// Exercise 02: foreach.
/// Walk the items with foreach and return a new list with the same elements.
/// </summary>
public static class Exercise02
{
    public static List<T> CollectItems<T>(IEnumerable<T> items)
    {
        // TODO: loop over items, collect them, and return the new list
        var collectedItems = new List<T>();
        foreach (var item in items)
        {
            collectedItems.Add(item);
        }
        return collectedItems;
    }
}
