namespace IntroProgramming.Collections;

/// <summary>
/// Exercise 02: indexing.
/// Return (first element, last element, elements from index 1 up to but not including index 3).
/// </summary>
public static class Exercise02
{
    public static (T First, T Last, List<T> Slice) FirstLastSlice<T>(IList<T> items)
    {
        // TODO: return (items[0], the last item, items from index 1 through 2)
        var first = items[0];
        var last = items[items.Count - 1];
        var slice = new List<T>();
        for (int i = 1; i < 3 && i < items.Count; i++)
        {
            slice.Add(items[i]);
        }
        return (first, last, slice);
        throw new NotImplementedException();
    }
}
