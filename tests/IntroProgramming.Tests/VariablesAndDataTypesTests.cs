using IntroProgramming.VariablesAndDataTypes;

namespace IntroProgramming.Tests;

public class VariablesAndDataTypesTests
{
    [Fact]
    public void Exercise01_AgeAndHeight()
    {
        var (age, height) = Exercise01.GetAgeAndHeight();

        Assert.IsType<int>(age);
        Assert.IsType<double>(height);
        Assert.True(age > 0, "Age must be greater than 0");
        Assert.True(height > 0, "Height must be greater than 0");
    }

    [Fact]
    public void Exercise02_FormatGreeting()
    {
        Assert.Equal("Hello, Ada!", Exercise02.FormatGreeting("Ada"));
        Assert.Equal("Hello, Alan!", Exercise02.FormatGreeting("Alan"));
    }

    [Fact]
    public void Exercise03_CombineFlags()
    {
        Assert.Equal((true, true, false), Exercise03.CombineFlags(true, true));
        Assert.Equal((false, true, false), Exercise03.CombineFlags(true, false));
        Assert.Equal((false, true, true), Exercise03.CombineFlags(false, true));
        Assert.Equal((false, false, true), Exercise03.CombineFlags(false, false));
    }

    [Fact]
    public void Exercise04_ToInt()
    {
        Assert.Equal(42, Exercise04.ToInt("42"));
        Assert.Equal(3, Exercise04.ToInt(3.14));
        Assert.Equal(0, Exercise04.ToInt("0"));
    }

    [Fact]
    public void Exercise05_MaybeValue()
    {
        Assert.Null(Exercise05.MaybeValue(true));
        Assert.NotNull(Exercise05.MaybeValue(false));
    }

    [Fact]
    public void Exercise06_ExampleValues()
    {
        var (number, decimalValue, text, flag) = Exercise06.ExampleValues();

        Assert.IsType<int>(number);
        Assert.IsType<double>(decimalValue);
        Assert.IsType<string>(text);
        Assert.IsType<bool>(flag);
        Assert.True(number > 0, "Number must be greater than 0");
        Assert.True(decimalValue > 0, "Decimal must be greater than 0");
        Assert.False(string.IsNullOrEmpty(text), "Text must not be empty");
    }
}
