namespace IntroProgramming.Collections;

/// <summary>
/// Exercise 06: collection methods.
/// SortedCopy returns a new sorted list and leaves the input unchanged.
/// MappingKeys returns the dictionary keys.
/// WithAdded returns a set of the input values plus extra.
/// </summary>
public static class Exercise06
{
    public static List<int> SortedCopy(List<int> values)
    {
        // TODO: return a sorted copy
        var copy = new List<int>(values);
        copy.Sort();
        return copy;
        throw new NotImplementedException();
    }

    public static List<TKey> MappingKeys<TKey, TValue>(Dictionary<TKey, TValue> mapping)
        where TKey : notnull
    {
        // TODO: return the keys
        return mapping.Keys.ToList();
        throw new NotImplementedException();
    }

    public static HashSet<T> WithAdded<T>(IEnumerable<T> values, T extra)
    {
        // TODO: copy the values into a set, add extra, and return the set
        var set = new HashSet<T>(values);
        set.Add(extra);
        return set;
        throw new NotImplementedException();
    }
}
