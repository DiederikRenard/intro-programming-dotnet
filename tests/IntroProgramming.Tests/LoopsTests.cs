using IntroProgramming.Loops;

namespace IntroProgramming.Tests;

public class LoopsTests
{
    [Fact]
    public void Exercise01_NumbersWithRange()
    {
        Assert.Equal(new[] { 0, 1, 2, 3, 4 }, Exercise01.NumbersWithRange());
    }

    [Fact]
    public void Exercise02_CollectItems()
    {
        Assert.Equal(new[] { "apple", "banana", "cherry" }, Exercise02.CollectItems(new[] { "apple", "banana", "cherry" }));
        Assert.Equal(Array.Empty<string>(), Exercise02.CollectItems(Array.Empty<string>()));
    }

    [Fact]
    public void Exercise03_Countdown()
    {
        Assert.Equal(new[] { 5, 4, 3, 2, 1, 0 }, Exercise03.Countdown());
    }

    [Fact]
    public void Exercise04_CollectUntilStop()
    {
        Assert.Equal(new[] { "a", "b" }, Exercise04.CollectUntilStop(new[] { "a", "b", "stop", "c" }));
        Assert.Equal(Array.Empty<string>(), Exercise04.CollectUntilStop(new[] { "stop" }));
        Assert.Equal(new[] { "x", "y" }, Exercise04.CollectUntilStop(new[] { "x", "y" }));
    }

    [Fact]
    public void Exercise05_OddNumbersUpTo9()
    {
        Assert.Equal(new[] { 1, 3, 5, 7, 9 }, Exercise05.OddNumbersUpTo9());
    }

    [Fact]
    public void Exercise06_IndexedItems()
    {
        Assert.Equal(new[] { (0, "a"), (1, "b"), (2, "c") }, Exercise06.IndexedItems(new[] { "a", "b", "c" }));
        Assert.Equal(Array.Empty<(int, string)>(), Exercise06.IndexedItems(Array.Empty<string>()));
    }
}
