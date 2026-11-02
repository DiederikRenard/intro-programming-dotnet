using IntroProgramming.Collections;

namespace IntroProgramming.Tests;

public class CollectionsTests
{
    [Fact]
    public void Exercise01_AddItem()
    {
        Assert.Equal(new[] { 1, 2, 3, 4 }, Exercise01.AddItem(new List<int> { 1, 2, 3 }, 4));
        Assert.Equal(new[] { "a" }, Exercise01.AddItem(new List<string>(), "a"));
    }

    [Fact]
    public void Exercise02_FirstLastSlice()
    {
        var (firstNumber, lastNumber, numberSlice) = Exercise02.FirstLastSlice(new List<int> { 10, 20, 30, 40 });
        Assert.Equal(10, firstNumber);
        Assert.Equal(40, lastNumber);
        Assert.Equal(new[] { 20, 30 }, numberSlice);

        var (firstText, lastText, textSlice) = Exercise02.FirstLastSlice(new List<string> { "a", "b", "c", "d" });
        Assert.Equal("a", firstText);
        Assert.Equal("d", lastText);
        Assert.Equal(new[] { "b", "c" }, textSlice);
    }

    [Fact]
    public void Exercise03_GetAge()
    {
        var ages = new Dictionary<string, int>
        {
            ["Ada"] = 36,
            ["Alan"] = 41,
        };

        Assert.Equal(36, Exercise03.GetAge(ages, "Ada"));
        Assert.Equal(41, Exercise03.GetAge(ages, "Alan"));
    }

    [Fact]
    public void Exercise04_Unpack()
    {
        Assert.Equal((1, 2, 3), Exercise04.Unpack((1, 2, 3)));
        Assert.Equal(("a", "b", "c"), Exercise04.Unpack(("a", "b", "c")));
    }

    [Fact]
    public void Exercise05_Unique()
    {
        Assert.True(new HashSet<int> { 1, 2, 3 }.SetEquals(Exercise05.Unique(new[] { 1, 2, 2, 3, 3, 3 })));
        Assert.True(new HashSet<string> { "a", "b" }.SetEquals(Exercise05.Unique(new[] { "a", "a", "b" })));
    }

    [Fact]
    public void Exercise06_CollectionMethods()
    {
        var original = new List<int> { 3, 1, 2 };
        Assert.Equal(new[] { 1, 2, 3 }, Exercise06.SortedCopy(original));
        Assert.Equal(new[] { 3, 1, 2 }, original);

        var keys = Exercise06.MappingKeys(new Dictionary<string, int>
        {
            ["a"] = 1,
            ["b"] = 2,
        });
        Assert.Equal(2, keys.Count);
        Assert.Contains("a", keys);
        Assert.Contains("b", keys);

        Assert.True(new HashSet<int> { 1, 2, 3 }.SetEquals(Exercise06.WithAdded(new HashSet<int> { 1, 2 }, 3)));
        Assert.True(new HashSet<string> { "x" }.SetEquals(Exercise06.WithAdded(new HashSet<string>(), "x")));
    }
}
