using IntroProgramming.Functions;

namespace IntroProgramming.Tests;

public class FunctionsTests
{
    [Fact]
    public void Exercise01_Greet()
    {
        Assert.Equal("Hello, Ada!", Exercise01.Greet("Ada"));
        Assert.Equal("Hello, Alan!", Exercise01.Greet("Alan"));
    }

    [Fact]
    public void Exercise02_Add()
    {
        Assert.Equal(5, Exercise02.Add(2, 3));
        Assert.Equal(0, Exercise02.Add(-1, 1));
        Assert.Equal(0, Exercise02.Add(0, 0));
    }

    [Fact]
    public void Exercise03_Square()
    {
        Assert.Equal(16, Exercise03.Square(4));
        Assert.Equal(0, Exercise03.Square(0));
        Assert.Equal(9, Exercise03.Square(-3));
    }

    [Fact]
    public void Exercise04_GreetDefaultArgument()
    {
        Assert.Equal("Hello, Ada!", Exercise04.Greet("Ada"));
        Assert.Equal("Hi, Ada!", Exercise04.Greet("Ada", "Hi"));
    }

    [Fact]
    public void Exercise05_MinMax()
    {
        Assert.Equal((3, 8), Exercise05.MinMax(3, 8));
        Assert.Equal((1, 9), Exercise05.MinMax(9, 1));
        Assert.Equal((4, 4), Exercise05.MinMax(4, 4));
    }

    [Fact]
    public void Exercise06_Scope()
    {
        Assert.Equal(10, Exercise06.X);

        Assert.Equal(10, Exercise06.ReadGlobalX());

        var localValue = Exercise06.ReadLocalX();
        Assert.NotEqual(10, localValue);
    }
}
