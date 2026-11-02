using IntroProgramming.Exceptions;

namespace IntroProgramming.Tests;

public class ExceptionsTests
{
    [Fact]
    public void Exercise01_SafeDivide()
    {
        AssertNumeric(Exercise01.SafeDivide(10, 2), 5);
        Assert.Equal("Cannot divide by zero", Exercise01.SafeDivide(10, 0));
    }

    [Fact]
    public void Exercise02_ParseInt()
    {
        AssertNumeric(Exercise02.ParseInt("42"), 42);
        Assert.Equal("Invalid number", Exercise02.ParseInt("invalid"));
    }

    [Fact]
    public void Exercise03_ConvertAndDivide()
    {
        AssertNumeric(Exercise03.ConvertAndDivide("10", "2"), 5);
        Assert.Equal("zero", Exercise03.ConvertAndDivide("10", "0"));
        Assert.Equal("invalid", Exercise03.ConvertAndDivide("x", "2"));
        Assert.Equal("invalid", Exercise03.ConvertAndDivide("10", "y"));
    }

    [Fact]
    public void Exercise04_RequirePositive()
    {
        Assert.Equal(3, Exercise04.RequirePositive(3));
        Assert.Equal(0, Exercise04.RequirePositive(0));

        var exception = Assert.Throws<ArgumentException>(() => Exercise04.RequirePositive(-1));
        Assert.Contains("Number must not be negative", exception.Message);
    }

    [Fact]
    public void Exercise05_RunWithFinally()
    {
        Assert.Equal(new[] { "try", "finally" }, Exercise05.RunWithFinally(false));
        Assert.Equal(new[] { "try", "except", "finally" }, Exercise05.RunWithFinally(true));
    }

    [Fact]
    public void Exercise06_GetErrorMessage()
    {
        Assert.Equal("something went wrong", Exercise06.GetErrorMessage("something went wrong"));
        Assert.Equal("boom", Exercise06.GetErrorMessage("boom"));
    }

    private static void AssertNumeric(object? actual, double expected)
    {
        Assert.NotNull(actual);
        Assert.Equal(expected, Convert.ToDouble(actual));
    }
}
